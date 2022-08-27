
namespace SAMP.API
{
    public class Text3D
    {
        #region Class Variables

        private int _nId;
        private bool _bDeleted;
        private string _strText;
        private Color _qColor;

        #endregion

        #region Constructor

        /// <summary>
        /// Creates a 3D Text Label. NOTE: This merely initializes the 3D Text Label. Use SAMP.API.Text3D.Create to create/spawn it!
        /// </summary>
        /// <param name="text">The initial text string.</param>
        /// <param name="color">The text color.</param>
        public Text3D(string text, Color color)
        {
            _strText = text;
            _qColor = color;
        }

        #endregion

        #region Accessors & Mutators

        /// <summary>
        /// Gets or sets the color of this 3D text label.
        /// </summary>
        public Color Color
        {
            get { return _qColor; }
            set
            {
                if(_bDeleted) return;

                Core.Natives.Update3DTextLabelText(this.ID, value.ToArgb(), _strText);
            }
        }

        /// <summary>
        /// Gets the ID of the 3D text label.
        /// </summary>
        internal int ID
        {
            get { return _nId; }
        }

        /// <summary>
        /// Gets or sets the text of this 3D text label.
        /// </summary>
        public string Text
        {
            get { return _strText; }
            set
            {
                if(_bDeleted) return;

                if(!_strText.Equals(string.Empty))
                    Core.Natives.Update3DTextLabelText(this.ID, _qColor.ToArgb(), value);
            }
        }

        #endregion

        #region Public Methods

        /// <summary>
        /// Creates the 3D Text Label at a specific location in the world.
        /// </summary>
        /// <param name="position">The position.</param>
        /// <param name="drawDistance">The distance from where you are able to see the 3D Text Label.</param>
        /// <param name="virtualWorld">The virtual world in which you are able to see the 3D Text.</param>
        /// <param name="testLOS">Test the line-of-sight so this text can't be seen through objects.</param>
        public void Create(Vector3 position, float drawDistance, int virtualWorld, bool testLOS = false)
        {
            _nId = Core.Natives.Create3DTextLabel(this.Text, this.Color.ToArgb(), position.X, position.Y, position.Z, drawDistance, virtualWorld, testLOS ? 1 : 0);
        }

        /// <summary>
        /// Attaches the 3D text label to a player.
        /// </summary>
        /// <param name="player">The player to attach the 3D text label to.</param>
        /// <param name="offset">The offset from the player.</param>
        public void AttachToPlayer(Player player, Vector3 offset)
        {
            if(_bDeleted) return;
            Core.Natives.Attach3DTextLabelToPlayer(this.ID, player.ID, offset.X, offset.Y, offset.Z);
        }

        /// <summary>
        /// Attaches the 3D text label to a vehicle.
        /// </summary>
        /// <param name="vehicle">The vehicle to attach the 3D text label to.</param>
        /// <param name="offset">The offset from the player.</param>
        public void AttachToVehicle(Vehicle vehicle, Vector3 offset)
        {
            if(_bDeleted) return;
            Core.Natives.Attach3DTextLabelToVehicle(this.ID, vehicle.ID, offset.X, offset.Y, offset.Z);
        }

        /// <summary>
        /// Deletes the 3D text label.
        /// </summary>
        /// <returns>Returns a System.Boolean representing whether or not the 3D text label was deleted.</returns>
        public bool Delete()
        {
            _bDeleted = true;
            return Core.Natives.Delete3DTextLabel(this.ID) == 1;
        }

        #endregion
    };
};