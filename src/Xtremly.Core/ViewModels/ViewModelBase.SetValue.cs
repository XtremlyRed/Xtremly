﻿using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Xtremly.Core
{
    public abstract partial class ViewModelBase
    {

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        private readonly ConcurrentDictionary<string, object> PropertyValueMapper = new();

        /// <summary>
        /// set value with Ref  by propertyName
        /// </summary>
        /// <typeparam name="TType"></typeparam>
        /// <param name="field">old value</param>
        /// <param name="newValue">new value</param>
        /// <param name="propertyName">propertyName</param> 
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        protected bool SetValue<TType>(ref TType field, TType newValue, [CallerMemberName] string propertyName = null)
        {
            if (propertyName is null)
            {
                throw new ArgumentNullException(nameof(propertyName));
            }

            if (EqualityComparer<TType>.Default.Equals(field, newValue))
            {
                return false;
            }

            field = newValue;
            RaisePropertyChanged(propertyName);
            return true;
        }


        /// <summary>
        /// set value by propertyName
        /// </summary>
        /// <typeparam name="TType"></typeparam> 
        /// <param name="newValue">new value</param>
        /// <param name="propertyName">propertyName</param> 
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        protected bool SetValue<TType>(TType newValue, [CallerMemberName] string propertyName = null)
        {
            if (propertyName is null)
            {
                throw new ArgumentNullException(nameof(propertyName));
            }

            if (PropertyValueMapper.TryGetValue(propertyName, out object oldValue) && oldValue is TType old)
            {
                if (EqualityComparer<TType>.Default.Equals(old, newValue))
                {
                    return false;
                }
            }

            PropertyValueMapper[propertyName] = newValue;
            RaisePropertyChanged(propertyName);
            return true;
        }


        /// <summary>
        /// set value by propertyName
        /// </summary>
        /// <typeparam name="TType"></typeparam>
        /// <param name="newValue">new value</param>
        /// <param name="comparer">property value comparer</param>
        /// <param name="propertyName">propertyName</param> 
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        protected bool SetValue<TType>(TType newValue, IEqualityComparer<TType> comparer,
            [CallerMemberName] string propertyName = null)
        {
            if (propertyName is null)
            {
                throw new ArgumentNullException(nameof(propertyName));
            }

            if (comparer is null)
            {
                throw new ArgumentNullException(nameof(comparer));
            }

            if (PropertyValueMapper.TryGetValue(propertyName, out object oldValue) && oldValue is TType old)
            {
                if (comparer.Equals(old, newValue))
                {
                    return false;
                }
            }

            PropertyValueMapper[propertyName] = newValue;
            RaisePropertyChanged(propertyName);
            return true;
        }

        /// <summary>
        /// get value by propertyName
        /// </summary>
        /// <typeparam name="TType"></typeparam>
        /// <param name="defaultValue">default Value</param>
        /// <param name="propertyName">propertyName</param> 
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        protected TType GetValue<TType>(TType defaultValue = default, [CallerMemberName] string propertyName = null)
        {
            if (propertyName is null)
            {
                throw new ArgumentNullException(nameof(propertyName));
            }

            object value = PropertyValueMapper.GetOrAdd(propertyName, i => defaultValue);
            return (TType)value;
        }
    }
}