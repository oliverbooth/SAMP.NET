using System;

namespace SAMP.API
{
    public struct Vector2
    {
        #region Class Variables

        private float _x, _y;

        #endregion

        #region Constructor

        /// <summary>
        /// Creates a new Vector2 object.
        /// </summary>
        /// <param name="x">X position.</param>
        /// <param name="y">Y position.</param>
        public Vector2(float x, float y)
        {
            this._x = x;
            this._y = y;
        }

        /// <summary>
        /// Creates a new Vector2 object.
        /// </summary>
        /// <param name="v">Uniform position.</param>
        public Vector2(float v)
        {
            this._x = v;
            this._y = v;
        }

        /// <summary>
        /// Creates a new Vector2 object.
        /// </summary>
        /// <param name="v">Vector2 to copy.</param>
        public Vector2(Vector2 v)
        {
            this._x = v.X;
            this._y = v.Y;
        }

        /// <summary>
        /// Creates a new Vector2 object.
        /// </summary>
        /// <param name="v">Vector3 to copy.</param>
        public Vector2(Vector3 v)
        {
            this._x = v.X;
            this._y = v.Y;
        }

        #endregion

        #region Accessors & Mutators

        /// <summary>
        /// Gets a zero-pointed Vector2.
        /// </summary>
        public static Vector2 Zero
        {
            get { return new Vector2(0f, 0f); }
        }

        /// <summary>
        /// Gets or sets the X position of this Vector2.
        /// </summary>
        public float X
        {
            get { return this._x; }
            set { this._x = value; }
        }

        /// <summary>
        /// Gets or sets the Y position of this Vector2.
        /// </summary>
        public float Y
        {
            get { return this._y; }
            set { this._y = value; }
        }

        #endregion

        #region Operator Overloads

        /// <summary>
        /// Add two Vector2 objects.
        /// </summary>
        /// <param name="v1">The base term Vector2.</param>
        /// <param name="v2">The factor term Vector2</param>
        /// <returns>Returns the sum of v1 and v2.</returns>
        public static Vector2 operator +(Vector2 v1, Vector2 v2)
        {
            return new Vector2(v1.X + v2.X, v1.Y + v2.Y);
        }

        /// <summary>
        /// Subtract two Vector2 objects.
        /// </summary>
        /// <param name="v1">The base term Vector2.</param>
        /// <param name="v2">The factor term Vector2</param>
        /// <returns>Returns the value of v2 subratcted from v1.</returns>
        public static Vector2 operator -(Vector2 v1, Vector2 v2)
        {
            return new Vector2(v1.X + v2.X, v1.Y + v2.Y);
        }

        /// <summary>
        /// Add two Vector2 objects.
        /// </summary>
        /// <param name="v1">The base term Vector2.</param>
        /// <param name="v2">The factor term Vector2</param>
        /// <returns>Returns the sum of v1 and v2.</returns>
        public static Vector2 operator *(Vector2 v1, Vector2 v2)
        {
            return new Vector2(v1.X * v2.X, v1.Y * v2.Y);
        }

        /// <summary>
        /// Subtract two Vector2 objects.
        /// </summary>
        /// <param name="v1">The base term Vector2.</param>
        /// <param name="v2">The factor term Vector2</param>
        /// <returns>Returns the value of v2 subratcted from v1.</returns>
        public static Vector2 operator /(Vector2 v1, Vector2 v2)
        {
            return new Vector2(v1.X / v2.X, v1.Y / v2.Y);
        }

        #endregion

        #region Method Overrides

        /// <summary>
        /// Returns a System.String that represents the Vector2.
        /// </summary>
        /// <returns>A System.String that represents the current Vector2.</returns>
        public override string ToString()
        {
            return string.Format("{{X: {0}, Y: {1}}}", this.X, this.Y);
        }

        #endregion

        #region Static Methods

        /// <summary>
        /// Determines the distance between two Vector2 objects.
        /// </summary>
        /// <param name="v1">The base Vector2 term.</param>
        /// <param name="v2">The factor Vector2 term.</param>
        /// <returns>Returns a double precision decimal representing the distance between v1 and v2.</returns>
        public static double Distance(Vector2 v1, Vector2 v2)
        {
            return Math.Sqrt(Math.Pow((double)v1.X - (double)v2.X, 2) + Math.Pow((double)v1.Y - (double)v2.Y, 2));
        }

        #endregion

        #region Public Methods

        /// <summary>
        /// Determines the distance between this Vector2 and another Vector3.
        /// </summary>
        /// <param name="v">The Vector2 term.</param>
        /// <returns>Returns a double precision decimal representing the distance between v and this Vector2.</returns>
        public double Distance(Vector2 v)
        {
            return Vector2.Distance(this, v);
        }

        /// <summary>
        /// Calculates the dot product of two vectors.
        /// </summary>
        /// <param name="v1">The base Vector2 term.</param>
        /// <param name="v2">The factor Vector2 term.</param>
        /// <returns>Returns the dot product of v1 and v2.</returns>
        public Vector2 Dot(Vector2 v1, Vector2 v2)
        {
            return new Vector2(
                x: v1.X * v2.X,
                y: v1.Y * v2.Y);
        }

        #endregion
    };
};