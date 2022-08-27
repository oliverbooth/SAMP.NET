using System;

namespace SAMP.API
{
    public struct Vector3
    {
        #region Class Variables

        private float _x, _y, _z;

        #endregion

        #region Constructor

        /// <summary>
        /// Creates a new Vector3 object.
        /// </summary>
        /// <param name="x">X position.</param>
        /// <param name="y">Y position.</param>
        /// <param name="z">Z position.</param>
        public Vector3(float x, float y, float z)
        {
            this._x = x;
            this._y = y;
            this._z = z;
        }

        /// <summary>
        /// Creates a new Vector3 object.
        /// </summary>
        /// <param name="v">Uniform position.</param>
        public Vector3(float v)
        {
            this._x = v;
            this._y = v;
            this._z = v;
        }

        /// <summary>
        /// Creates a new Vector3 object.
        /// </summary>
        /// <param name="v">Vector2 to copy.</param>
        public Vector3(Vector2 v)
        {
            this._x = v.X;
            this._y = v.Y;
            this._z = 0f;
        }

        /// <summary>
        /// Creates a new Vector3 object.
        /// </summary>
        /// <param name="v">Vector3 to copy.</param>
        public Vector3(Vector3 v)
        {
            this._x = v.X;
            this._y = v.Y;
            this._z = v.Z;
        }

        #endregion

        #region Accessors & Mutators

        /// <summary>
        /// Gets a zero-pointed Vector3.
        /// </summary>
        public static Vector3 Zero
        {
            get { return new Vector3(0f, 0f, 0f); }
        }

        /// <summary>
        /// Gets or sets the X position of this Vector3.
        /// </summary>
        public float X
        {
            get { return this._x; }
            set { this._x = value; }
        }

        /// <summary>
        /// Gets or sets the Y position of this Vector3.
        /// </summary>
        public float Y
        {
            get { return this._y; }
            set { this._y = value; }
        }

        /// <summary>
        /// Gets or sets the Z position of this Vector3.
        /// </summary>
        public float Z
        {
            get { return this._z; }
            set { this._z = value; }
        }

        #endregion

        #region Operator Overloads

        /// <summary>
        /// Add two Vector3 objects.
        /// </summary>
        /// <param name="v1">The base term Vector3.</param>
        /// <param name="v2">The factor term Vector3</param>
        /// <returns>Returns the sum of v1 and v2.</returns>
        public static Vector3 operator +(Vector3 v1, Vector3 v2)
        {
            return new Vector3(v1.X + v2.X, v1.Y + v2.Y, v1.Z + v2.Z);
        }

        /// <summary>
        /// Subtract two Vector3 objects.
        /// </summary>
        /// <param name="v1">The base term Vector3.</param>
        /// <param name="v2">The factor term Vector3</param>
        /// <returns>Returns the value of v2 subratcted from v1.</returns>
        public static Vector3 operator -(Vector3 v1, Vector3 v2)
        {
            return new Vector3(v1.X + v2.X, v1.Y + v2.Y, v1.Z + v2.Z);
        }

        /// <summary>
        /// Add two Vector3 objects.
        /// </summary>
        /// <param name="v1">The base term Vector3.</param>
        /// <param name="v2">The factor term Vector3</param>
        /// <returns>Returns the sum of v1 and v2.</returns>
        public static Vector3 operator *(Vector3 v1, Vector3 v2)
        {
            return new Vector3(v1.X * v2.X, v1.Y * v2.Y, v1.Z * v2.Z);
        }

        /// <summary>
        /// Subtract two Vector3 objects.
        /// </summary>
        /// <param name="v1">The base term Vector3.</param>
        /// <param name="v2">The factor term Vector3</param>
        /// <returns>Returns the value of v2 subratcted from v1.</returns>
        public static Vector3 operator /(Vector3 v1, Vector3 v2)
        {
            return new Vector3(v1.X / v2.X, v1.Y / v2.Y, v1.Z / v2.Z);
        }

        #endregion

        #region Method Overrides

        /// <summary>
        /// Returns a System.String that represents the Vector3.
        /// </summary>
        /// <returns>A System.String that represents the current Vector3.</returns>
        public override string ToString()
        {
            return string.Format("({0}, {1}, {2})", this.X, this.Y, this.Z);
        }

        #endregion

        #region Static Methods

        /// <summary>
        /// Determines the distance between two Vector3 objects.
        /// </summary>
        /// <param name="v1">The base Vector3 term.</param>
        /// <param name="v2">The factor Vector3 term.</param>
        /// <returns>Returns a double precision decimal representing the distance between v1 and v2.</returns>
        public static double Distance(Vector3 v1, Vector3 v2)
        {
            return Math.Sqrt(Math.Pow((double)v1.X - (double)v2.X, 2) + Math.Pow((double)v1.Y - (double)v2.Y, 2) + Math.Pow((double)v1.Z - (double)v2.Z, 2));
        }

        #endregion

        #region Public Methods

        /// <summary>
        /// Determines the distance between this Vector3 and another Vector3.
        /// </summary>
        /// <param name="v">The Vector3 term.</param>
        /// <returns>Returns a double precision decimal representing the distance between v and this Vector3.</returns>
        public double Distance(Vector3 v)
        {
            return Vector3.Distance(this, v);
        }

        /// <summary>
        /// Calculates the dot product of two vectors.
        /// </summary>
        /// <param name="v1">The base Vector3 term.</param>
        /// <param name="v2">The factor Vector3 term.</param>
        /// <returns>Returns the dot product of v1 and v2.</returns>
        public Vector3 Dot(Vector3 v1, Vector3 v2)
        {
            return new Vector3(
                x: v1.X * v2.X,
                y: v1.Y * v2.Y,
                z: v1.Z * v2.Z);
        }

        #endregion
    };
};