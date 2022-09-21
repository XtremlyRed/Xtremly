
using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Xtremly.Core.Geometry2D
{
    /// <summary>
    /// point
    /// </summary>
    [TypeConverter(typeof(TargetTypeConverter<PointD, double>))]
    [Serializable]
    [DataContract]
    [StructLayout(LayoutKind.Sequential)]
    [ComVisible(true)]
    public struct PointD
    {
        /// <summary>
        ///  Origin point
        /// </summary>
        public static readonly PointD Empty = new(0, 0);

        /// <summary>
        /// create  new point
        /// </summary>
        public PointD()
        {
            X = Y = 0;
        }

        /// <summary>
        /// create  new point
        /// </summary>
        public PointD(double x, double y)
        {
            X = x;
            Y = y;
        }

        /// <summary>
        /// empty point
        /// </summary>
        [Browsable(false)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool IsEmpty => X == 0d && Y == 0d;

        /// <summary>
        /// X
        /// </summary>
        [DataMember]
        public double X { get; set; }

        /// <summary>
        /// Y
        /// </summary>
        [DataMember]
        public double Y { get; set; }

        /// <summary>
        /// add
        /// </summary>
        /// <param name="vector"></param>
        /// <returns></returns>
        [Browsable(false)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        public PointD Add(VectorD vector)
        {
            return new PointD(X + vector.X, Y + vector.Y);
        }

        /// <summary>
        /// Subtract
        /// </summary>
        /// <param name="vector"></param>
        /// <returns></returns>
        [Browsable(false)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        public PointD Subtract(VectorD vector)
        {
            return new PointD(X - vector.X, Y - vector.Y);
        }

        /// <summary>
        /// offset
        /// </summary>
        /// <param name="dx"></param>
        /// <param name="dy"></param>
        [Browsable(false)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        public void Offset(double dx, double dy)
        {
            X += dx;
            Y += dy;
        }

        /// <summary>
        /// offset
        /// </summary>
        /// <param name="p"></param>
        [Browsable(false)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        public void Offset(PointD p)
        {
            X += p.X;
            Y += p.Y;
        }

        /// <summary>
        /// string format
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"({X},{Y})";
        }

        /// <summary>
        /// subtract
        /// </summary>
        /// <param name="pt"></param>
        /// <param name="vector"></param>
        /// <returns></returns>
        public static PointD operator +(PointD pt, VectorD vector)
        {
            return new PointD(pt.X + vector.X, pt.Y + vector.Y);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pt"></param>
        /// <param name="point"></param>
        /// <returns></returns>
        public static PointD operator -(PointD pt, VectorD point)
        {
            return new PointD(pt.X - point.X, pt.Y - point.Y);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="point"></param>
        /// <returns></returns>
        public static PointD operator -(PointD point)
        {
            return new PointD(-point.X, -point.Y);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pt"></param>
        /// <param name="point"></param>
        /// <returns></returns>
        public static PointD operator +(PointD pt, PointD point)
        {
            return new PointD(pt.X + point.X, pt.Y + point.Y);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pt"></param>
        /// <param name="vector"></param>
        /// <returns></returns>
        public static PointD operator -(PointD pt, PointD vector)
        {
            return new PointD(pt.X - vector.X, pt.Y - vector.Y);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="left"></param>
        /// <param name="right"></param>
        /// <returns></returns>
        public static bool operator ==(PointD left, PointD right)
        {
            return left.X == right.X && left.Y == right.Y;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="left"></param>
        /// <param name="right"></param>
        /// <returns></returns>
        public static bool operator !=(PointD left, PointD right)
        {
            return left.X != right.X || left.Y != right.Y;
        }



        /// <summary>
        /// 
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            if (obj is not PointD p1)
            {
                return false;
            }

            return X == p1.X && Y == p1.Y;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode()
        {
            return X.GetHashCode() ^ Y.GetHashCode();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="retainDecimalPlaces"></param>
        /// <returns></returns>
        public string Format(int retainDecimalPlaces = 2)
        {
            return $"{Math.Round(X, retainDecimalPlaces)},{Math.Round(Y, retainDecimalPlaces)}";
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="retainDecimalPlaces"></param>
        /// <returns></returns>
        public PointD Round(int retainDecimalPlaces = 2)
        {
            return new PointD(Math.Round(X, retainDecimalPlaces), Math.Round(Y, retainDecimalPlaces));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public VectorD ToVector()
        {
            return new VectorD(X, Y);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="point2"></param>
        /// <returns></returns>
        public double GetDistance(PointD point2)
        {
            double x2 = Math.Pow(X - point2.X, 2);
            double y2 = Math.Pow(Y - point2.Y, 2);

            return Math.Sqrt(x2 + y2);
        }
    }
}
