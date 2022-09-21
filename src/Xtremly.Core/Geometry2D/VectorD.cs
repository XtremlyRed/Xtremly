
using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Xtremly.Core.Geometry2D
{
    /// <summary>
    /// 
    /// </summary>
    [TypeConverter(typeof(TargetTypeConverter<VectorD, double>))]
    [Serializable]
    [DataContract]
    [StructLayout(LayoutKind.Sequential)]
    [ComVisible(true)]
    public struct VectorD
    {

        /// <summary>
        /// 
        /// </summary>
        public static readonly VectorD Empty = new(0, 0);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        public VectorD(double x, double y)
        {
            X = x;
            Y = y;
        }

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
        /// 
        /// </summary>
        [Browsable(false)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        public bool IsEmpty => X == 0f && Y == 0f;

        /// <summary>
        ///  length
        /// </summary>
        [Browsable(false)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        public double Length => Math.Sqrt(X * X + Y * Y);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="vector"></param>
        /// <returns></returns>
        [Browsable(false)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        public VectorD Add(VectorD vector)
        {
            return new VectorD(X + vector.X, Y + vector.Y);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="vector"></param>
        /// <returns></returns>
        [Browsable(false)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        public VectorD Subtract(VectorD vector)
        {
            return new VectorD(X - vector.X, Y - vector.Y);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="scalar"></param>
        /// <returns></returns>
        [Browsable(false)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        public VectorD Multiply(double scalar)
        {
            return new VectorD(X * scalar, Y * scalar);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="scalar"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        [Browsable(false)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        public VectorD Divide(double scalar)
        {
            return scalar == 0d
                ? throw new ArgumentOutOfRangeException(nameof(scalar))
                : new VectorD(X / scalar, Y / scalar);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="dx"></param>
        /// <param name="dy"></param>
        [Browsable(false)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        public VectorD Offset(double dx, double dy)
        {
            X += dx;
            Y += dy;

            return new VectorD(X + dx, Y + dy);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="vector"></param>
        [Browsable(false)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        public VectorD Offset(VectorD vector)
        {
            return Offset(vector.X, vector.Y);
        }


        /// <summary>
        /// Normalize
        /// </summary>
        /// <returns></returns>
        public static VectorD Normalize(VectorD vector)
        {
            double length = vector.Length;

            return Math.Abs(length) <= 0 ? new VectorD(vector.X, vector.Y) : new VectorD(vector.X / length, vector.Y / length);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="vector1"></param>
        /// <param name="vector2"></param>
        /// <returns></returns>
        public static double CrossProduct(VectorD vector1, VectorD vector2)
        {
            return vector1.X * vector2.Y - vector1.Y * vector2.X;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="vector1"></param>
        /// <param name="vector2"></param>
        /// <returns></returns>
        public static double AngleBetween(VectorD vector1, VectorD vector2)
        {
            double y = vector1.X * vector2.Y - vector2.X * vector1.Y;
            double x = vector1.X * vector2.X + vector1.Y * vector2.Y;
            return Math.Atan2(y, x) * 57.295779513082323;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="current"></param>
        /// <param name="other"></param>
        /// <returns></returns>
        public static double GetDistance(VectorD current, VectorD other)
        {
            double x2 = Math.Pow(current.X - other.X, 2);
            double y2 = Math.Pow(current.Y - other.Y, 2);

            return Math.Sqrt(x2 + y2);
        }


        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"({X},{Y})";
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="v1"></param>
        /// <param name="v2"></param>
        /// <returns></returns>
        public static VectorD operator +(VectorD v1, VectorD v2)
        {
            return new VectorD(v1.X + v2.X, v1.Y + v2.Y);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="v1"></param>
        /// <param name="v2"></param>
        /// <returns></returns>
        public static VectorD operator -(VectorD v1, VectorD v2)
        {
            return new VectorD(v1.X - v2.X, v1.Y - v2.Y);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="vetcor"></param>
        /// <returns></returns>
        public static VectorD operator -(VectorD vetcor)
        {
            return new VectorD(-vetcor.X, -vetcor.Y);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="vector"></param>
        /// <param name="scalar"></param>
        /// <returns></returns>
        public static VectorD operator *(VectorD vector, double scalar)
        {
            return new VectorD(vector.X * scalar, vector.Y * scalar);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="vector"></param>
        /// <param name="scalar"></param>
        /// <returns></returns>
        public static VectorD operator *(double scalar, VectorD vector)
        {
            return new VectorD(vector.X * scalar, vector.Y * scalar);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="vector"></param>
        /// <param name="scalar"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public static VectorD operator /(VectorD vector, double scalar)
        {
            return scalar == 0d
                ? throw new ArgumentOutOfRangeException(nameof(scalar))
                : new VectorD(vector.X / scalar, vector.Y / scalar);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="left"></param>
        /// <param name="right"></param>
        /// <returns></returns>
        public static bool operator ==(VectorD left, VectorD right)
        {
            return left.X == right.X && left.Y == right.Y;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="left"></param>
        /// <param name="right"></param>
        /// <returns></returns>
        public static bool operator !=(VectorD left, VectorD right)
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
            return obj is VectorD p1 && X == p1.X && Y == p1.Y;
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
        /// <returns></returns>
        public PointD ToPoint()
        {
            return new PointD(X, Y);
        }
    }
}
