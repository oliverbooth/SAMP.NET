using System.Collections.Generic;

namespace SAMP.API
{
    public class Menu
    {
        #region Class Variables

        private static List<Menu> _qMenuStore = new List<Menu>();
        private int _nId = -1;

        #endregion

        #region Constructor

        /// <summary>
        /// Creates a new Menu object.
        /// </summary>
        /// <param name="title">The title for the new menu.</param>
        /// <param name="columns">How many colums shall the new menu have.</param>
        /// <param name="position">The position of the menu.</param>
        /// <param name="col1width">The width for the first column.</param>
        /// <param name="col2width">The width for the second column.</param>
        public Menu(string title, int columns, Vector2 position, float col1width, float col2width=0.0f)
        {
            _nId = Core.Natives.CreateMenu(title, columns, position.X, position.Y, col1width, col2width);
            _qMenuStore.Add(this);
        }

        #endregion

        #region Accessors & Mutators

        /// <summary>
        /// Gets the ID of this Menu.
        /// </summary>
        internal int ID
        {
            get { return _nId; }
        }

        /// <summary>
        /// Sets the caption of a column in the menu.
        /// </summary>
        /// <param name="column">Which column in the menu shall be manipulated.</param>
        /// <param name="text">The caption-text for the column.</param>
        public void SetColumnHeader(int column, string text)
        {
            Core.Natives.SetMenuColumnHeader(this.ID, column, text);
        }

        #endregion

        #region Public Methods

        /// <summary>
        /// Finds the Menu whose ID is menuid.
        /// </summary>
        /// <param name="menuid">The menu ID to search for.</param>
        /// <returns>Returns a Menu whose ID is menuid.</returns>
        internal static Menu Get(int menuid)
        {
            foreach(Menu menu in _qMenuStore)
                if(menu.ID == menuid)
                    return menu;
            return null;
        }

        /// <summary>
        /// Determines whether the specified menu ID is valid.
        /// </summary>
        /// <param name="menuid">The menu ID to check.</param>
        /// <returns>Returns a System.Boolean representing whether the specified menu ID is valid.</returns>
        public static bool IsValid(Menu menu)
        {
            return Core.Natives.IsValidMenu(menu.ID) == 1;
        }

        /// <summary>
        /// Adds an item to the Menu.
        /// </summary>
        /// <param name="title">The title for the new menu item.</param>
        /// <param name="column">The column to add the item to.</param>
        public void AddItem(string title, int column = 0)
        {
            Core.Natives.AddMenuItem(this.ID, column, title);
        }

        /// <summary>
        /// Destroys the Menu. Setting the object to null (destructing) calls this method.
        /// </summary>
        public bool Destroy()
        {
            _qMenuStore.Remove(this);
            return Core.Natives.DestroyMenu(this.ID) == 1;
        }

        /// <summary>
        /// Disables the Menu.
        /// </summary>
        public void Disable()
        {
            Core.Natives.DestroyMenu(this.ID);
        }

        /// <summary>
        /// Disables a row in the menu.
        /// </summary>
        public void DisableRow(int row)
        {
            Core.Natives.DisableMenuRow(this.ID, row);
        }

        #endregion
    };
};