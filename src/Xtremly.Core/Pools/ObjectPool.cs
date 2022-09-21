using System;
using System.Threading;

namespace Xtremly.Core
{


    /// <summary>
    /// simple object pool
    /// </summary>
    /// <typeparam name="Target"></typeparam>
    public class ObjectPool<Target> where Target : class
    {

        public int Capacity { get; }

        private Item[] items;
        private Target _current;

        private struct Item
        {
            public Target Value;
        }

        /// <summary>
        ///  create a new pool by pool size
        /// </summary>
        /// <param name="capacity"></param>
        public ObjectPool(int capacity = 0)
        {
            if (capacity <= 0)
            {
                capacity = Environment.ProcessorCount * 2;
            }

            Capacity = capacity;
        }

        private void Init()
        {
            if (items != null)
            {
                return;
            }

            lock (this)
            {
                if (items != null)
                {
                    return;
                }

                items = new Item[Capacity - 1];
            }
        }



        /// <summary>
        /// Rent object
        /// </summary>
        /// <returns></returns>
        public virtual Target Rent()
        {

            Target val = _current;
            if (val != null && Interlocked.CompareExchange(ref _current, null, val) == val)
            {
                return val;
            }

            Init();


            for (int i = 0; i < items.Length; i++)
            {
                val = items[i].Value;
                if (val != null && Interlocked.CompareExchange(ref items[i].Value, null, val) == val)
                {
                    return val;
                }
            }

            return OnCreate();
        }

        /// <summary>Return</summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public virtual bool Return(Target value)
        {

            if (_current == null && Interlocked.CompareExchange(ref _current, value, null) == null)
            {
                return true;
            }

            Init();


            for (int i = 0; i < items.Length; ++i)
            {
                if (Interlocked.CompareExchange(ref items[i].Value, value, null) == null)
                {
                    return true;
                }
            }

            return false;
        }

        /// <summary>
        /// clear pool
        /// </summary>
        /// <returns></returns>
        public virtual int Clear()
        {
            int count = 0;

            if (_current != null)
            {
                _current = null;
                count++;
            }


            for (int i = 0; i < items.Length; ++i)
            {
                if (items[i].Value != null)
                {
                    items[i].Value = null;
                    count++;
                }
            }
            items = null;

            return count;
        }


        protected virtual Target OnCreate()
        {
            return Activator.CreateInstance<Target>();
        }
    }
}
