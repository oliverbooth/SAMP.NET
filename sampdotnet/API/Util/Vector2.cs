using System;

namespace SAMP.API {
	public struct Vector2 {
		#region Struct Variables
		
		private float
			m_fpX,
			m_fpY;
		
		#endregion
		
		#region Constructor
		
		/// <summary>
		/// Initializes a new instance of the <see cref="SAMP.API.Vector2"/> struct.
		/// </summary>
		/// <param name="x">X position.</param>
		/// <param name="y">Y position.</param>
		public Vector2(float x, float y) {
			this.m_fpX = x;
			this.m_fpY = y;
		}
		
		/// <summary>
		/// Initializes a new instance of the <see cref="SAMP.API.Vector2"/> struct.
		/// </summary>
		/// <param name="v">Uniform position.</param>
		public Vector2(float v) {
			this.m_fpX = v;
			this.m_fpY = v;
		}
		
		/// <summary>
		/// Initializes a new instance of the <see cref="SAMP.API.Vector2"/> struct.
		/// </summary>
		/// <param name="v">The <see cref="SAMP.API.Vector2"/> to copy.</param>
		public Vector2(Vector2 v) {
			this.m_fpX = v.X;
			this.m_fpY = v.Y;
		}
		
		/// <summary>
		/// Initializes a new instance of the <see cref="SAMP.API.Vector2"/> struct.
		/// </summary>
		/// <param name="v">The <see cref="SAMP.API.Vector3"/> to copy.</param>
		public Vector2(Vector3 v) {
			this.m_fpX = v.X;
			this.m_fpY = v.Y;
		}
		
		#endregion
		
		#region Accessors & Mutators
		
		/// <summary>
		/// Gets the zero-pointed <see cref="SAMP.API.Vector2"/>.
		/// </summary>
		public static Vector2 Zero {
			get {
				return new Vector2(0.0f, 0.0f);
			}
		}
		
		/// <summary>
		/// Gets or sets the X position of this <see cref="SAMP.API.Vector2"/>.
		/// </summary>
		public float X {
			get {
				return this.m_fpX;
			} set {
				this.m_fpX = value;
			}
		}
		
		/// <summary>
		/// Gets or sets the Y position of this <see cref="SAMP.API.Vector2"/>.
		/// </summary>
		public float Y {
			get {
				return this.m_fpY;
			} set {
				this.m_fpY = value;
			}
		}
		
		#endregion
		
		#region Operator Overloads
		
		/// <summary>
		/// Adds a <see cref="Vector2"/> to a <see cref="Vector2"/>, yielding a new <see cref="Vector2"/>.
		/// </summary>
		/// <param name="v1">The first <see cref="Vector2"/> to add.</param>
		/// <param name="v2">The second <see cref="Vector2"/> to add.</param>
		/// <returns>The <see cref="Vector2"/> that is the sum of the values of <c>v1</c> and <c>v2</c>.</returns>
		public static Vector2 operator +(Vector2 v1, Vector2 v2) {
			return new Vector2(v1.X + v2.X, v1.Y + v2.Y);
		}
		
		/// <summary>
		/// Subtracts a <see cref="Vector2"/> from a <see cref="Vector2"/>, yielding a new <see cref="Vector2"/>.
		/// </summary>
		/// <param name="v1">The <see cref="Vector2"/> to subtract from (the minuend).</param>
		/// <param name="v2">The <see cref="Vector2"/> to subtract (the subtrahend).</param>
		/// <returns>The <see cref="Vector2"/> that is the <c>v1</c> minus <c>v2</c>.</returns>
		public static Vector2 operator -(Vector2 v1, Vector2 v2) {
			return new Vector2(v1.X + v2.X, v1.Y + v2.Y);
		}
		
		/// <summary>
		/// Computes the product of <c>v1</c> and <c>v2</c>, yielding a new <see cref="Vector2"/>.
		/// </summary>
		/// <param name="v1">The <see cref="Vector2"/> to multiply.</param>
		/// <param name="v2">The <see cref="Vector2"/> to multiply.</param>
		/// <returns>The <see cref="Vector2"/> that is the <c>v1</c> * <c>v2</c>.</returns>
		public static Vector2 operator *(Vector2 v1, Vector2 v2) {
			return new Vector2(v1.X * v2.X, v1.Y * v2.Y);
		}
		
		/// <summary>
		/// Computes the division of <c>v1</c> and <c>v2</c>, yielding a new <see cref="Vector2"/>.
		/// </summary>
		/// <param name="v1">The <see cref="Vector2"/> to divide (the divident)./param>
		/// <param name="v2">The <see cref="Vector2"/> to divide (the divisor).</param>
		/// <returns>The <see cref="Vector2"/> that is the <c>v1</c> / <c>v2</c>.</returns>
		public static Vector2 operator /(Vector2 v1, Vector2 v2) {
			return new Vector2(v1.X / v2.X, v1.Y / v2.Y);
		}
		
		#endregion
		
		#region Method Overrides
		
		/// <summary>
		/// Returns a <see cref="System.String"/> that represents the current <see cref="SAMP.API.Vector2"/>.
		/// </summary>
		/// <returns>A <see cref="System.String"/> that represents the current <see cref="SAMP.API.Vector2"/>.</returns>
		public override string ToString() {
			return string.Format("{{X: {0}, Y: {1}}}", this.X, this.Y);
		}
		
		#endregion
		
		#region Static Methods
		
		/// <summary>
		/// Calculates the distance between two <see cref="SAMP.API.Vector2"/> objects.
		/// </summary>
		/// <param name="v1">The base <see cref="SAMP.API.Vector2"/> term.</param>
		/// <param name="v2">The factor <see cref="SAMP.API.Vector2"/> term.</param>
		/// <returns>Returns a <see cref="System.Double"/> representing the distance between <c>v1</c> and <c>v2</c>.</returns>
		public static double Distance(Vector2 v1, Vector2 v2) {
			return Math.Sqrt(
				Math.Pow((double)v1.X - (double)v2.X, 2) +
				Math.Pow((double)v1.Y - (double)v2.Y, 2));
		}
		
		/// <summary>
		/// Calculates the dot product of two vectors.
		/// </summary>
		/// <param name="v1">The base <see cref="SAMP.API.Vector2"/> term.</param>
		/// <param name="v2">The factor <see cref="SAMP.API.Vector2"/> term.</param>
		/// <returns>Returns a <see cref="SAMP.API.Vector2"/> representing the dot product of <c>v1</c> and <c>v2</c>.</returns>
		public static Vector2 Dot(Vector2 v1, Vector2 v2) {
			return new Vector2(
				x: v1.X * v2.X,
				y: v1.Y * v2.Y);
		}
		
		#endregion
		
		#region Public Methods
		
		/// <summary>
		/// Calculates the distance between the current <see cref="SAMP.API.Vector2"/> and another.
		/// </summary>
		/// <param name="v">The <see cref="SAMP.API.Vector2"/> term.</param>
		/// <returns>Returns a <see cref="System.Double"/> representing the distance between <c>v</c> and the current <see cref="SAMP.API.Vector2"/>.</returns>
		public double Distance(Vector2 v) {
			return Vector2.Distance(this, v);
		}
		
		#endregion
	};
};
