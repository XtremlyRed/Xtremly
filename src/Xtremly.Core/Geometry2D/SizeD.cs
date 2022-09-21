
using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Xtremly.Core.Geometry2D
{
    /// <summary>
    /// <see cref="SizeD"/>
    /// </summary>
    [TypeConverter(typeof(TargetTypeConverter<SizeD, double>))]
    [Serializable]
    [DataContract]
    [StructLayout(LayoutKind.Sequential)]
    [ComVisible(true)]
    public struct SizeD
    {
        /// <summary>
        /// empty size
        /// </summary>
        public static readonly SizeD Empty = new(0, 0);

        /// <summary>
        /// create new size object
        /// </summary>
        /// <param name="width"></param>
        /// <param name="height"></param>
        public SizeD(double width, double height)
        {
            Width = width;
            Height = height;
        }

        /// <summary>
        /// is empty
        /// </summary>
        [Browsable(false)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool IsEmpty => Width == 0d && Height == 0d;


        /// <summary>
        /// width
        /// </summary>
        [DataMember]
        public double Width { get; set; }

        /// <summary>
        /// height
        /// </summary>
        [DataMember]
        public double Height { get; set; }


        /// <summary>
        /// size get area
        /// </summary>
        /// <param name="size"></param>
        /// <returns></returns>
        public static double GetArea(SizeD size)
        {
            return size.Width * size.Height;
        }

        /// <summary>
        /// string format
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"({Width},{Height})";
        }

        /// <summary>
        /// +
        /// </summary>
        /// <param name="sz1"></param>
        /// <param name="sz2"></param>
        /// <returns></returns>
        public static SizeD operator +(SizeD sz1, SizeD sz2)
        {
            return new SizeD(sz1.Width + sz2.Width, sz1.Height + sz2.Height);
        }

        /// <summary>
        /// -
        /// </summary>
        /// <param name="sz1"></param>
        /// <param name="sz2"></param>
        /// <returns></returns>
        public static SizeD operator -(SizeD sz1, SizeD sz2)
        {
            return new SizeD(sz1.Width - sz2.Width, sz1.Height - sz2.Height);
        }

        /// <summary>
        /// ==
        /// </summary>
        /// <param name="sz1"></param>
        /// <param name="sz2"></param>
        /// <returns></returns>
        public static bool operator ==(SizeD sz1, SizeD sz2)
        {
            return sz1.Width == sz2.Width && sz1.Height == sz2.Height;
        }

        /// <summary>
        /// !=
        /// </summary>
        /// <param name="sz1"></param>
        /// <param name="sz2"></param>
        /// <returns></returns>
        public static bool operator !=(SizeD sz1, SizeD sz2)
        {
            return sz1.Width != sz2.Width || sz1.Height != sz2.Height;
        }

        /// <summary>
        /// equale
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            return obj is SizeD size && Width == size.Width && Height == size.Height;
        }

        /// <summary>
        /// hash code
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode()
        {
            return Width.GetHashCode() ^ Height.GetHashCode();
        }


        /// <summary>
        /// string format 
        /// </summary>
        /// <param name="retainDecimalPlaces"></param>
        /// <returns></returns>
        public string Format(int retainDecimalPlaces = 2)
        {
            return $"{Math.Round(Width, retainDecimalPlaces)},{Math.Round(Height, retainDecimalPlaces)}";
        }

        /// <summary>
        /// round
        /// </summary>
        /// <param name="retainDecimalPlaces"></param>
        /// <returns></returns>
        public SizeD Round(int retainDecimalPlaces = 2)
        {
            return new SizeD(Math.Round(Width, retainDecimalPlaces), Math.Round(Height, retainDecimalPlaces));
        }

        /// <summary>
        /// to pointd
        /// </summary>
        /// <returns></returns>
        public PointD ToPoint()
        {
            return new PointD(Width, Height);
        }
    }
}
