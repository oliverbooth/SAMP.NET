using System;

namespace SAMP.API
{
    public class TextDraw
    {
        #region Class Variables

        private int _nId = -1, _nFont = 0, _nShadow = 0, _nOutline = 0;
        private string _strText = " ";
        private Vector2 _qPosition = Vector2.Zero, _qSize = new Vector2(3f), _qLetterSize = new Vector2(3.2f, 5.1f);
        private Color _qColor = Color.Black, _qBoxColor = Color.Black, _qBackColor = Color.Transparent;
        private Alignment _qAlignment = Alignment.Left;
        private bool _bUseBox = false, _bDestroyed = false, _bProportional = false, _bSelectable = false;

        #endregion

        #region Constructor

        /// <summary>
        /// Creates a textdraw.
        /// </summary>
        /// <param name="text">The text in the textdraw.</param>
        /// <param name="position">The position.</param>
        public TextDraw(string text, Vector2 position)
        {
            // Set vars and call native
            _strText = text;
            _qPosition = position;
            _nId = Core.Natives.TextDrawCreate(position.X, position.Y, text);
        }

        #endregion

        #region Accessors & Mutators

        /// <summary>
        /// Gets or sets the ID.
        /// </summary>
        internal int ID
        {
            get
            {
                // Check the TextDraw is valid
                if(_bDestroyed) throw Core.Exceptions.TextDrawDestroyed;

                // Return the ID
                return _nId;
            }
        }

        /// <summary>
        /// Gets or sets the Alignment.
        /// </summary>
        public Alignment Alignment
        {
            get
            {
                // Check the TextDraw is valid
                if(_bDestroyed) throw Core.Exceptions.TextDrawDestroyed;

                // Return the alignment
                return _qAlignment;
            }
            set
            {
                // Check the TextDraw is valid
                if(_bDestroyed) throw Core.Exceptions.TextDrawDestroyed;

                // Change the alignment
                _qAlignment = value;

                // Call native
                Core.Natives.TextDrawAlignment(this.ID, (int)value);
            }
        }

        /// <summary>
        /// Gets or sets the text box colour (only used if UseBox is true).
        /// </summary>
        public Color BackColor
        {
            get
            {
                // Check the TextDraw is valid
                if(_bDestroyed) throw Core.Exceptions.TextDrawDestroyed;
                // Return the text colour
                return _qBackColor;
            }
            set
            {
                // Check the TextDraw is valid
                if(_bDestroyed) throw Core.Exceptions.TextDrawDestroyed;

                // Change the colour
                _qBackColor = value;

                // Call native
                Core.Natives.TextDrawBackgroundColor(this.ID, value.ToArgb());
            }
        }

        /// <summary>
        /// Gets or sets the text box colour (only used if UseBox is true).
        /// </summary>
        public Color BoxColor
        {
            get
            {
                // Check the TextDraw is valid
                if(_bDestroyed) throw Core.Exceptions.TextDrawDestroyed;

                // Return the text colour
                return _qBoxColor;
            }
            set
            {
                // Check the TextDraw is valid
                if(_bDestroyed) throw Core.Exceptions.TextDrawDestroyed;

                // Change the colour
                _qBoxColor = value;

                // Call native
                Core.Natives.TextDrawBoxColor(this.ID, value.ToArgb());
            }
        }

        /// <summary>
        /// Gets or sets the font.
        /// </summary>
        public int Font
        {
            get
            {
                // Check the TextDraw is valid
                if(_bDestroyed) throw Core.Exceptions.TextDrawDestroyed;

                // Return the font
                return _nFont;
            }
            set
            {
                // Check the TextDraw is valid
                if(_bDestroyed) throw Core.Exceptions.TextDrawDestroyed;

                // Change the font
                _nFont = value;

                Core.Natives.TextDrawFont(this.ID, value);
            }
        }

        /// <summary>
        /// Gets or sets the text color.
        /// </summary>
        public Color ForeColor
        {
            get
            {
                // Check the TextDraw is valid
                if(_bDestroyed) throw Core.Exceptions.TextDrawDestroyed;

                // Return the text colour
                return _qColor;
            }
            set
            {
                // Check the TextDraw is valid
                if(_bDestroyed) throw Core.Exceptions.TextDrawDestroyed;

                // Change the colour
                _qColor = value;

                // Call native
                Core.Natives.TextDrawColor(this.ID, value.ToArgb());
            }
        }

        /// <summary>
        /// Gets or sets whether the TextDraw should use a box.
        /// </summary>
        public Vector2 LetterSize
        {
            get
            {
                // Check the TextDraw is valid
                if(_bDestroyed) throw Core.Exceptions.TextDrawDestroyed;
                
                // Return the size
                return _qLetterSize;
            }
            set
            {
                // Check the TextDraw is valid
                if(_bDestroyed) throw Core.Exceptions.TextDrawDestroyed;

                // Change the size
                _qLetterSize = value;

                // Call native
                Core.Natives.TextDrawLetterSize(this.ID, value.X, value.Y);
            }
        }

        /// <summary>
        /// Gets or sets the thickness of the outline.
        /// </summary>
        public int Outline
        {
            get
            {
                // Check the TextDraw is valid
                if(_bDestroyed) throw Core.Exceptions.TextDrawDestroyed;

                // Return the outline
                return _nOutline;
            }
            set
            {
                // Check the TextDraw is valid
                if(_bDestroyed) throw Core.Exceptions.TextDrawDestroyed;

                // Change the outline
                _nOutline = value;

                // Call native
                Core.Natives.TextDrawSetOutline(this.ID, value);
            }
        }

        /// <summary>
        /// Gets or sets whether the text spacing scales to a propotional ratio.
        /// </summary>
        public bool Proportional
        {
            get
            {
                // Check the TextDraw is valid
                if(_bDestroyed) throw Core.Exceptions.TextDrawDestroyed;

                // Return the bool
                return _bProportional;
            }
            set
            {
                // Check the TextDraw is valid
                if(_bDestroyed) throw Core.Exceptions.TextDrawDestroyed;

                // Change the bool
                _bProportional = value;

                // Call native
                Core.Natives.TextDrawSetProportional(this.ID, value ? 1 : 0);
            }
        }

        /// <summary>
        /// Gets or sets whether the TextDraw is selectable.
        /// </summary>
        public bool Selectable
        {
            get
            {
                // Check the TextDraw is valid
                if(_bDestroyed) throw Core.Exceptions.TextDrawDestroyed;

                // Return the bool
                return _bSelectable;
            }
            set
            {
                // Check the TextDraw is valid
                if(_bDestroyed) throw Core.Exceptions.TextDrawDestroyed;

                // Change the bool
                _bSelectable = value;

                // Call native
                Core.Natives.TextDrawSetSelectable(this.ID, value ? 1 : 0);
            }
        }

        /// <summary>
        /// Gets or sets whether the TextDraw should use a box.
        /// </summary>
        public Vector2 Size
        {
            get
            {
                // Check the TextDraw is valid
                if(_bDestroyed) throw Core.Exceptions.TextDrawDestroyed;

                // Return the size
                return _qSize;
            }
            set
            {
                // Check the TextDraw is valid
                if(_bDestroyed) throw Core.Exceptions.TextDrawDestroyed;

                // Change the size
                _qSize = value;

                // Call native
                Core.Natives.TextDrawTextSize(this.ID, value.X, value.Y);
            }
        }

        /// <summary>
        /// Gets or sets the side of the shadow.
        /// </summary>
        public int Shadow
        {
            get
            {
                // Check the TextDraw is valid
                if(_bDestroyed) throw Core.Exceptions.TextDrawDestroyed;

                // Return the shadow
                return _nShadow;
            }
            set
            {
                // Check the TextDraw is valid
                if(_bDestroyed) throw Core.Exceptions.TextDrawDestroyed;

                // Change the shadow
                _nShadow = value;

                // Call native
                Core.Natives.TextDrawSetShadow(this.ID, value);
            }
        }

        /// <summary>
        /// Gets or sets the text on the TextDraw.
        /// </summary>
        public string Text
        {
            get
            {
                // Check the TextDraw is valid
                if(_bDestroyed) throw Core.Exceptions.TextDrawDestroyed;

                // Return the text
                return _strText;
            }
            set
            {
                // Check the TextDraw is valid
                if(_bDestroyed) throw Core.Exceptions.TextDrawDestroyed;

                // Change the text
                _strText = value;

                // Call native
                Core.Natives.TextDrawSetString(this.ID, value);
            }
        }

        /// <summary>
        /// Gets or sets whether the TextDraw should use a box.
        /// </summary>
        public bool UseBox
        {
            get
            {
                // Check the TextDraw is valid
                if(_bDestroyed) throw Core.Exceptions.TextDrawDestroyed;

                // Return UseBox
                return _bUseBox;
            }
            set
            {
                // Check the TextDraw is valid
                if(_bDestroyed) throw Core.Exceptions.TextDrawDestroyed;

                // Change the UseBox
                _bUseBox = value;

                // Call native
                Core.Natives.TextDrawUseBox(this.ID, value ? 1 : 0);
            }
        }

        #endregion

        #region Public Methods

        /// <summary>
        /// Shows the TextDraw for the specified players.
        /// </summary>
        /// <param name="player">The players to show the TextDraw for.</param>
        public void Show(params Player[] player)
        {
            if(player.Equals(Player.All) || player.Length.Equals(0))
                Core.Natives.TextDrawShowForAll(_nId);
            else
                for(int i = 0; i < player.Length; i++)
                    Core.Natives.TextDrawShowForPlayer(player[i].ID, _nId);
        }

        /// <summary>
        /// Hides the TextDraw for the specified players.
        /// </summary>
        /// <param name="player">The players to hide the TextDraw for.</param>
        public void Hide(params Player[] player)
        {
            if(player.Equals(Player.All) || player.Length.Equals(0))
                Core.Natives.TextDrawHideForAll(_nId);
            else
                for(int i = 0; i < player.Length; i++)
                    Core.Natives.TextDrawHideForPlayer(player[i].ID, _nId);
        }

        /// <summary>
        /// Destroys the TextDraw.
        /// </summary>
        public void Destroy()
        {
            // Set destroyed
            _bDestroyed = true;

            // Call native
            Core.Natives.TextDrawDestroy(_nId);
        }

        #endregion
    };
};