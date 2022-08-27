using System;

namespace SAMP.API {
	public struct Vector3 {
		#region Struct Variables
		
		private float
			m_fpX,
			m_fpY,
			m_fpZ;
		
		#endregion
		
		#region Constructor
		
		/// <summary>
		/// Initializes a new instance of the <see cref="SAMP.API.Vector3"/> struct.
		/// </summary>
		/// <param name="x">X position.</param>
		/// <param name="y">Y position.</param>
		/// <param name="z">Z position.</param>
		public Vector3(float x, float y, float z) {
			this.m_fpX = x;
			this.m_fpY = y;
			this.m_fpZ = z;
		}
		
		/// <summary>
		/// Initializes a new instance of the <see cref="SAMP.API.Vector3"/> struct.
		/// </summary>
		/// <param name="v">Uniform position.</param>
		public Vector3(float v) {
			this.m_fpX = v;
			this.m_fpY = v;
			this.m_fpZ = v;
		}
		
		/// <summary>
		/// Initializes a new instance of the <see cref="SAMP.API.Vector3"/> struct.
		/// </summary>
		/// <param name="v">The <see cref="SAMP.API.Vector2"/> to copy.</param>
		public Vector3(Vector2 v) {
			this.m_fpX = v.X;
			this.m_fpY = v.Y;
			this.m_fpZ = 0f;
		}
		
		/// <summary>
		/// Initializes a new instance of the <see cref="SAMP.API.Vector3"/> struct.
		/// </summary>
		/// <param name="v">The <see cref="SAMP.API.Vector3"/> to copy.</param>
		public Vector3(Vector3 v) {
			this.m_fpX = v.X;
			this.m_fpY = v.Y;
			this.m_fpZ = v.Z;
		}
		
		#endregion
		
		#region Accessors & Mutators
		
		/// <summary>
		/// Gets the zero-pointed <see cref="SAMP.API.Vector3"/>.
		/// </summary>
		public static Vector3 Zero {
			get {
				return new Vector3(0.0f, 0.0f, 0.0f);
			}
		}
		
		/// <summary>
		/// Gets or sets the X position of this <see cref="SAMP.API.Vector3"/>.
		/// </summary>
		public float X {
			get {
				return this.m_fpX;
			} set {
				this.m_fpX = value;
			}
		}
		
		/// <summary>
		/// Gets or sets the Y position of this <see cref="SAMP.API.Vector3"/>.
		/// </summary>
		public float Y {
			get {
				return this.m_fpY;
			} set {
				this.m_fpY = value;
			}
		}
		
		/// <summary>
		/// Gets or sets the Z position of this <see cref="SAMP.API.Vector3"/>.
		/// </summary>
		public float Z {
			get {
				return this.m_fpZ;
			} set {
				this.m_fpZ = value;
			}
		}
		
		#endregion
		
		#region Operator Overloads
		
		/// <summary>
		/// Adds a <see cref="Vector3"/> to a <see cref="Vector3"/>, yielding a new <see cref="Vector3"/>.
		/// </summary>
		/// <param name="v1">The first <see cref="Vector3"/> to add.</param>
		/// <param name="v2">The second <see cref="Vector3"/> to add.</param>
		/// <returns>The <see cref="Vector3"/> that is the sum of the values of <c>v1</c> and <c>v2</c>.</returns>
		public static Vector3 operator +(Vector3 v1, Vector3 v2) {
			return new Vector3(v1.X + v2.X, v1.Y + v2.Y, v1.Z + v2.Z);
		}
		
		/// <summary>
		/// Subtracts a <see cref="Vector3"/> from a <see cref="Vector3"/>, yielding a new <see cref="Vector3"/>.
		/// </summary>
		/// <param name="v1">The <see cref="Vector3"/> to subtract from (the minuend).</param>
		/// <param name="v2">The <see cref="Vector3"/> to subtract (the subtrahend).</param>
		/// <returns>The <see cref="Vector3"/> that is the <c>v1</c> minus <c>v2</c>.</returns>
		public static Vector3 operator -(Vector3 v1, Vector3 v2) {
			return new Vector3(v1.X + v2.X, v1.Y + v2.Y, v1.Z + v2.Z);
		}
		
		/// <summary>
		/// Computes the product of <c>v1</c> and <c>v2</c>, yielding a new <see cref="Vector3"/>.
		/// </summary>
		/// <param name="v1">The <see cref="Vector3"/> to multiply.</param>
		/// <param name="v2">The <see cref="Vector3"/> to multiply.</param>
		/// <returns>The <see cref="Vector3"/> that is the <c>v1</c> * <c>v2</c>.</returns>
		public static Vector3 operator *(Vector3 v1, Vector3 v2) {
			return new Vector3(v1.X * v2.X, v1.Y * v2.Y, v1.Z * v2.Z);
		}
		
		/// <summary>
		/// Computes the division of <c>v1</c> and <c>v2</c>, yielding a new <see cref="Vector3"/>.
		/// </summary>
		/// <param name="v1">The <see cref="Vector3"/> to divide (the divident).</param>
		/// <param name="v2">The <see cref="Vector3"/> to divide (the divisor).</param>
		/// <returns>The <see cref="Vector3"/> that is the <c>v1</c> / <c>v2</c>.</returns>
		public static Vector3 operator /(Vector3 v1, Vector3 v2) {
			return new Vector3(v1.X / v2.X, v1.Y / v2.Y, v1.Z / v2.Z);
		}
		
		#endregion
		
		#region Method Overrides
		
		/// <summary>
		/// Returns a <see cref="System.String"/> that represents the current <see cref="SAMP.API.Vector3"/>.
		/// </summary>
		/// <returns>A <see cref="System.String"/> that represents the current <see cref="SAMP.API.Vector3"/>.</returns>
		public override string ToString() {
			return string.Format("({0}, {1}, {2})", this.X, this.Y, this.Z);
		}
		
		#endregion
		
		#region Static Methods
		
		/// <summary>
		/// Calculates the distance between two <see cref="SAMP.API.Vector3"/> objects.
		/// </summary>
		/// <param name="v1">The base <see cref="SAMP.API.Vector3"/> term.</param>
		/// <param name="v2">The factor <see cref="SAMP.API.Vector3"/> term.</param>
		/// <returns>Returns a <see cref="System.Double"/> representing the distance between <c>v1</c> and <c>v2</c>.</returns>
		public static double Distance(Vector3 v1, Vector3 v2) {
			return Math.Sqrt(
				Math.Pow((double)v1.X - (double)v2.X, 2) +
				Math.Pow((double)v1.Y - (double)v2.Y, 2) +
				Math.Pow((double)v1.Z - (double)v2.Z, 2));
		}
		
		/// <summary>
		/// Calculates the dot product of two <see cref="SAMP.API.Vector3"/> objects.
		/// </summary>
		/// <param name="v1">The base <see cref="SAMP.API.Vector3"/> term.</param>
		/// <param name="v2">he factor <see cref="SAMP.API.Vector3"/> term./param>
		/// <returns>Returns the dot product of <c>v1</c> and <c>v2</c>.</returns>
		public static Vector3 Dot(Vector3 v1, Vector3 v2) {
			return new Vector3(
				x: v1.X * v2.X,
				y: v1.Y * v2.Y,
				z: v1.Z * v2.Z);
		}
		
		#endregion
		
		#region Public Methods
		
		/// <summary>
		/// Calculates the distance between the current <see cref="SAMP.API.Vector3"/> and another.
		/// </summary>
		/// <param name="v">The <see cref="SAMP.API.Vector3"/> term.</param>
		/// <returns>Returns a <see cref="System.Double"/> representing the distance between <c>v</c> and the current <see cref="SAMP.API.Vector3"/>.</returns>
		public double Distance(Vector3 v) {
			return Vector3.Distance(this, v);
		}
		
		#endregion
	};
};
