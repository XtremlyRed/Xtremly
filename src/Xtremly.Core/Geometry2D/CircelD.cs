
using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Xtremly.Core.Geometry2D
{
    /// <summary>
    /// <see cref="CircleD"/>
    /// </summary>
    [TypeConverter(typeof(TargetTypeConverter<CircleD, double>))]
    [Serializable]
    [DataContract]
    [StructLayout(LayoutKind.Sequential)]
    [ComVisible(true)]
    public struct CircleD
    {
        /// <summary>
        /// empty circle
        /// </summary>
        public static readonly CircleD Empty = new(new PointD(0d, 0d), 0d);

        /// <summary>
        /// create new circle
        /// </summary>
        /// <param name="center"></param>
        /// <param name="radius"></param>
        public CircleD(PointD center, double radius)
        {
            Center = center;
            X = center.X;
            Y = center.Y;
            Radius = radius;
        }

        /// <summary>
        /// create new circle
        /// </summary>
        /// <param name="centerX"></param>
        /// <param name="centerY"></param>
        /// <param name="radius"></param>
        public CircleD(double centerX, double centerY, double radius) : this(new PointD(centerX, centerY), radius)
        {

        }

        /// <summary>
        /// is empty
        /// </summary>
        [Browsable(false)]
        public bool IsEmpty => X == 0 && Y == 0 && Radius == 0;

        /// <summary>
        /// center
        /// </summary>
        [Browsable(false)]
        public PointD Center { get; set; }

        /// <summary>
        /// center x
        /// </summary>
        [DataMember]
        public double X { get; set; }

        /// <summary>
        /// center y
        /// </summary>
        [DataMember]
        public double Y { get; set; }

        /// <summary>
        /// radius
        /// </summary>
        [DataMember]
        public double Radius { get; set; }

        /// <summary>
        /// circle bound
        /// </summary>
        [Browsable(false)]
        public RectangleD Bound => new(X - Radius, Y - Radius, Radius * 2, Radius * 2);

        /// <summary>
        /// offset circle
        /// </summary>
        /// <param name="dx"></param>
        /// <param name="dy"></param>
        public CircleD Offset(double dx, double dy)
        {
            CircleD circle = new(X + dx, Y + dy, Radius);

            return circle;
        }

        /// <summary>
        /// offset circle
        /// </summary>
        /// <param name="p"></param>
        public CircleD Offset(VectorD p)
        {
            return Offset(p.X, p.Y);
        }

        /// <summary>
        /// Get Perimeter 
        /// </summary>
        /// <param name="circel"></param>
        /// <returns></returns>
        [Browsable(false)]
        public static double GetPerimeter(CircleD circel)
        {
            return 2 * Math.PI * circel.Radius;
        }

        /// <summary>
        /// Get Area
        /// </summary>
        /// <param name="circel"></param>
        /// <returns></returns>
        [Browsable(false)]
        public static double GetArea(CircleD circel)
        {
            return Math.PI * circel.Radius * circel.Radius;
        }

        /// <summary>
        /// string format
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"({X},{Y}) {Radius}";
        }

        /// <summary>
        ///  Inflate radio
        /// </summary>
        /// <param name="radius"></param>
        public void Inflate(double radius)
        {
            Radius += radius;
        }

        /// <summary>
        /// offset circel
        /// </summary>
        /// <param name="circel"></param>
        /// <param name="vector"></param>
        /// <returns></returns>
        public static CircleD operator +(CircleD circel, VectorD vector)
        {
            return new CircleD(circel.X + vector.X, circel.Y + vector.Y, circel.Radius);
        }

        /// <summary>
        /// offset circel
        /// </summary>
        /// <param name="circel"></param>
        /// <param name="vector"></param>
        /// <returns></returns>
        public static CircleD operator -(CircleD circel, VectorD vector)
        {
            return new CircleD(circel.X - vector.X, circel.Y - vector.Y, circel.Radius);
        }

        /// <summary>
        ///  scaler circle radius
        /// </summary>
        /// <param name="circel"></param>
        /// <param name="scaler"></param>
        /// <returns></returns>
        public static CircleD operator *(CircleD circel, double scaler)
        {
            return new CircleD(circel.X, circel.Y, circel.Radius * scaler);
        }

        /// <summary>
        /// scaler circle radius
        /// </summary>
        /// <param name="circel"></param>
        /// <param name="scaler"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentOutOfRangeException">scaler is zero</exception>
        public static CircleD operator /(CircleD circel, double scaler)
        {
            return scaler == 0d
                ? throw new ArgumentOutOfRangeException(nameof(scaler))
                : new CircleD(circel.X, circel.Y, circel.Radius / scaler);
        }

        /// <summary>
        /// ==
        /// </summary>
        /// <param name="left"></param>
        /// <param name="right"></param>
        /// <returns></returns>
        public static bool operator ==(CircleD left, CircleD right)
        {
            return left.Center == right.Center && left.Radius == right.Radius;
        }

        /// <summary>
        /// !=
        /// </summary>
        /// <param name="left"></param>
        /// <param name="right"></param>
        /// <returns></returns>
        public static bool operator !=(CircleD left, CircleD right)
        {
            return left.Center != right.Center || left.Radius != right.Radius;
        }

        /// <summary>
        /// equals
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            return obj is CircleD p1 && X == p1.X && Y == p1.Y && Radius == p1.Radius;
        }

        /// <summary>
        /// hash code
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode()
        {
            return Center.GetHashCode() ^ Radius.GetHashCode();
        }

        /// <summary>
        /// string format
        /// </summary>
        /// <param name="retainDecimalPlaces"></param>
        /// <returns></returns>
        public string Format(int retainDecimalPlaces = 2)
        {
            return $"({Math.Round(X, retainDecimalPlaces)},{Math.Round(Y, retainDecimalPlaces)}) {Math.Round(Radius, retainDecimalPlaces)}";
        }

        /// <summary>
        /// round
        /// </summary>
        /// <param name="retainDecimalPlaces"></param>
        /// <returns></returns>
        public CircleD Round(int retainDecimalPlaces = 2)
        {
            return new CircleD(Math.Round(X, retainDecimalPlaces), Math.Round(Y, retainDecimalPlaces), Math.Round(Radius, retainDecimalPlaces));
        }
    }
}
