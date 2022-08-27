using System;

namespace SAMP.API
{
    public struct Color
    {
        #region Struct Variables

        private uint _color;

        #endregion

        #region Constructors
        
        /// <summary>
        /// Creates a SAMP.API.Color structure from a 32-bit ARGB value.
        /// </summary>
        /// <param name="argb">A value specifying the 32-bit ARGB value.</param>
        internal Color(uint argb)
        {
            // Store
            this._color = argb;
        }

        #endregion

        #region Static Methods

        /// <summary>
        /// Creates a SAMP.API.Color structure from a 32-bit ARGB value.
        /// </summary>
        /// <param name="argb">A value specifying the 32-bit ARGB value.</param>
        /// <returns>The SAMP.API.Color structure that this method creates.</returns>
        public static Color FromArgb(uint argb)
        {
            // Return the created colour
            return new Color(argb);
        }

        /// <summary>
        /// Creates a System.Drawing.Color structure from the specified 8-bit color values
        ///     (red, green, and blue). The alpha value is implicitly 255 (fully opaque).
        ///     Although this method allows a 32-bit value to be passed for each color component,
        ///     the value of each component is limited to 8 bits.
        /// </summary>
        /// <param name="argb">A value specifying the 32-bit ARGB value.</param>
        /// <returns>The SAMP.API.Color structure that this method creates.</returns>
        public static Color FromArgb(int red, int green, int blue)
        {
            return FromArgb(255, red, green, blue);
        }

        /// <summary>
        /// Creates a SAMP.API.Color structure from the specified 8-bit color values
        ///     (red, green, and blue). The alpha value is implicitly 255 (fully opaque).
        ///     Although this method allows a 32-bit value to be passed for each color component,
        ///     the value of each component is limited to 8 bits.
        /// </summary>
        /// <param name="alpha">The alpha component. Valid values are 0 through 255.</param>
        /// <param name="red">The red component. Valid values are 0 through 255.</param>
        /// <param name="green">The green component. Valid values are 0 through 255.</param>
        /// <param name="blue">The blue component. Valid values are 0 through 255.</param>
        /// <returns>The SAMP.API.Color structure that this method creates.</returns>
        public static Color FromArgb(int alpha, int red, int green, int blue)
        {
            // Convert the passed parameters to a HTML colour
            string html = ArgbToHex(red, green, blue, alpha);

            // Convert the HTML colour to ARGB decimal notation
            uint argb = Convert.ToUInt32(html, 16);

            // Return the created colour
            return new Color(argb);
        }

        /// <summary>
        /// Creates a SAMP.API.Color structure from the specified Html color value (hexadecimal notation).
        /// </summary>
        /// <param name="html">A value specifying the Html color notation.</param>
        /// <returns>The SAMP.API.Color structure that this method creates.</returns>
        public static Color FromHtml(string htmlColor)
        {
            // Truncate the HTML colour prefix ("0x" or "#") if necessary
            if(htmlColor.StartsWith("0x"))
                htmlColor = htmlColor.Substring(2);
            else if(htmlColor.StartsWith("#"))
                htmlColor = htmlColor.Substring(1);

            // Determine if the HTML has the correct length
            if(htmlColor.Length.Equals(6))
                // Append an alpha value
                htmlColor = string.Format("{0}FF", htmlColor.ToUpper());

            else if(htmlColor.Length.Equals(3))
            {
                // Elongate shorthand HTML
                string
                    r = htmlColor.Substring(0, 1),
                    g = htmlColor.Substring(1, 1),
                    b = htmlColor.Substring(2, 1);

                htmlColor = string.Format("{0}{0}{1}{1}{2}{2}FF", r, g, b);
            }

            // Convert the HTML colour to an ARGB decimal notation
            uint argb = Convert.ToUInt32(htmlColor, 16);

            // Return the created colour
            return new Color(argb);
        }

        #endregion

        #region Internal Methods

        internal static string ArgbToHex(int r, int g, int b)
        {
            return ArgbToHex(r, g, b, 255);
        }

        internal static string ArgbToHex(int r, int g, int b, int a)
        {
            string
                hr = r.ToString("X"),
                hg = g.ToString("X"),
                hb = b.ToString("X"),
                ha = a.ToString("X");

            if(hr.Length < 2)
                hr = string.Format("0{0}", hr);
            if(hg.Length < 2)
                hg = string.Format("0{0}", hg);
            if(hb.Length < 2)
                hb = string.Format("0{0}", hb);
            if(ha.Length < 2)
                ha = string.Format("0{0}", ha);

            return string.Format("{0}{1}{2}{3}", hr, hg, hb, ha);
        }

        #endregion

        #region Public Methods
        
        /// <summary>
        /// Translates the specified SAMP.API.Color instance to an HTML string color representation.
        /// </summary>
        /// <param name="alpha">Whether or not to include the alpha channel.</param>
        /// <returns>The string that represents the HTML color.</returns>
        public string ToHtml(bool alpha)
        {
            // Convert the Argb to a hexadecimal value
            string html = _color.ToString("X");

            // Truncate to 6 characters if we want to omit the alpha channel
            if(!alpha) html = html.Substring(0, 6);

            // Return the HTML color representatio.
            return html;
        }

        /// <summary>
        /// Gets the 32-bit ARGB value of this SAMP.API.Color instance.
        /// </summary>
        /// <returns>The 32-bit ARGB value of this SAMP.API.Color.</returns>
        public uint ToArgb()
        {
            // Return the Argb value
            return _color;
        }
        
        #endregion

        #region Accessors & Mutators

        /// <summary>
        /// Gets the Red value of this Color.
        /// </summary>
        public byte R
        {
            get
            {
                string hex = _color.ToString("X");
                string val = hex.Substring(0, 2);
                return Convert.ToByte(val, 16);
            }
        }

        /// <summary>
        /// Gets the Green value of this Color.
        /// </summary>
        public byte G
        {
            get
            {
                string hex = _color.ToString("X");
                string val = hex.Substring(2, 2);
                return Convert.ToByte(val, 16);
            }
        }

        /// <summary>
        /// Gets the Blue value of this Color.
        /// </summary>
        public byte B
        {
            get
            {
                string hex = _color.ToString("X");
                string val = hex.Substring(4, 2);
                return Convert.ToByte(val, 16);
            }
        }

        /// <summary>
        /// Gets the Alpha value of this Color.
        /// </summary>
        public byte A
        {
            get
            {
                string hex = _color.ToString("X");
                string val = hex.Substring(6, 2);
                return Convert.ToByte(val, 16);
            }
        }

        #endregion

        #region Defined Colour Values

        /// <summary>
        /// Gets a system-defined color that has an ARGB value of #FFF0F8FF.
        /// </summary>
        public static Color AliceBlue { get { return FromHtml("F0F8FF"); } }
        /// <summary>
        /// Gets a system-defined color that has an ARGB value of #FFFAEBD7.
        /// </summary>
        public static Color AntiqueWhite { get { return FromHtml("FAEBD7"); } }
        /// <summary>
        /// Gets a system-defined color that has an ARGB value of #FF00FFFF.
        /// </summary>
        public static Color Aqua { get { return FromHtml("00FFFF"); } }
        /// <summary>
        /// Gets a system-defined color that has an ARGB value of #FF7FFFD4.
        /// </summary>
        public static Color Aquamarine { get { return FromHtml("7FFFD4"); } }
        /// <summary>
        /// Gets a system-defined color that has an ARGB value of #FFF0FFFF.
        /// </summary>
        public static Color Azure { get { return FromHtml("F0FFFF"); } }
        /// <summary>
        /// Gets a system-defined color that has an ARGB value of #FFF5F5DC.
        /// </summary>
        public static Color Beige { get { return FromHtml("F5F5DC"); } }
        /// <summary>
        /// Gets a system-defined color that has an ARGB value of #FFFFE4C4.
        /// </summary>
        public static Color Bisque { get { return FromHtml("FFE4C4"); } }
        /// <summary>
        /// Gets a system-defined color that has an ARGB value of #FF000000.
        /// </summary>
        public static Color Black { get { return FromHtml("000000"); } }
        /// <summary>
        /// Gets a system-defined color that has an ARGB value of #FFFFEBCD.
        /// </summary>
        public static Color BlanchedAlmond { get { return FromHtml("FFEBCD"); } }
        /// <summary>
        /// Gets a system-defined color that has an ARGB value of #FF0000FF.
        /// </summary>
        public static Color Blue { get { return FromHtml("0000FF"); } }
        /// <summary>
        /// Gets a system-defined color that has an ARGB value of #FF8A2BE2.
        /// </summary>
        public static Color BlueViolet { get { return FromHtml("8A2BE2"); } }
        /// <summary>
        /// Gets a system-defined color that has an ARGB value of #FFA52A2A.
        /// </summary>
        public static Color Brown { get { return FromHtml("A52A2A"); } }
        /// <summary>
        /// Gets a system-defined color that has an ARGB value of #FFDEB887.
        /// </summary>
        public static Color BurlyWood { get { return FromHtml("DEB887"); } }
        /// <summary>
        /// Gets a system-defined color that has an ARGB value of #FF5F9EA0.
        /// </summary>
        public static Color CadetBlue { get { return FromHtml("5F9EA0"); } }
        /// <summary>
        /// Gets a system-defined color that has an ARGB value of #FF7FFF00.
        /// </summary>
        public static Color Chartreuse { get { return FromHtml("7FFF00"); } }
        /// <summary>
        /// Gets a system-defined color that has an ARGB value of #FFD2691E.
        /// </summary>
        public static Color Chocolate { get { return FromHtml("D2691E"); } }
        /// <summary>
        /// Gets a system-defined color that has an ARGB value of #FFFF7F50.
        /// </summary>
        public static Color Coral { get { return FromHtml("FF7F50"); } }
        /// <summary>
        /// Gets a system-defined color that has an ARGB value of #FF6495ED.
        /// </summary>
        public static Color CornflowerBlue { get { return FromHtml("6495ED"); } }
        /// <summary>
        /// Gets a system-defined color that has an ARGB value of #FFFFF8DC.
        /// </summary>
        public static Color Cornsilk { get { return FromHtml("FFF8DC"); } }
        /// <summary>
        /// Gets a system-defined color that has an ARGB value of #FFDC143C.
        /// </summary>
        public static Color Crimson { get { return FromHtml("DC143C"); } }
        /// <summary>
        /// Gets a system-defined color that has an ARGB value of #FF00FFFF.
        /// </summary>
        public static Color Cyan { get { return FromHtml("00FFFF"); } }
        /// <summary>
        /// Gets a system-defined color that has an ARGB value of #FF00008B.
        /// </summary>
        public static Color DarkBlue { get { return FromHtml("00008B"); } }
        /// <summary>
        /// Gets a system-defined color that has an ARGB value of #FF008B8B.
        /// </summary>
        public static Color DarkCyan { get { return FromHtml("008B8B"); } }
        /// <summary>
        /// Gets a system-defined color that has an ARGB value of #FFB8860B.
        /// </summary>
        public static Color DarkGoldenrod { get { return FromHtml("B8860B"); } }
        /// <summary>
        /// Gets a system-defined color that has an ARGB value of #FFA9A9A9.
        /// </summary>
        public static Color DarkGray { get { return FromHtml("A9A9A9"); } }
        /// <summary>
        /// Gets a system-defined color that has an ARGB value of #FF006400.
        /// </summary>
        public static Color DarkGreen { get { return FromHtml("006400"); } }
        /// <summary>
        /// Gets a system-defined color that has an ARGB value of #FFBDB76B.
        /// </summary>
        public static Color DarkKhaki { get { return FromHtml("BDB76B"); } }
        /// <summary>
        /// Gets a system-defined color that has an ARGB value of #FF8B008B.
        /// </summary>
        public static Color DarkMagenta { get { return FromHtml("8B008B"); } }
        /// <summary>
        /// Gets a system-defined color that has an ARGB value of #FF556B2F.
        /// </summary>
        public static Color DarkOliveGreen { get { return FromHtml("556B2F"); } }
        /// <summary>
        /// Gets a system-defined color that has an ARGB value of #FFFF8C00.
        /// </summary>
        public static Color DarkOrange { get { return FromHtml("FF8C00"); } }
        /// <summary>
        /// Gets a system-defined color that has an ARGB value of #FF9932CC.
        /// </summary>
        public static Color DarkOrchid { get { return FromHtml("9932CC"); } }
        /// <summary>
        /// Gets a system-defined color that has an ARGB value of #FF8B0000.
        /// </summary>
        public static Color DarkRed { get { return FromHtml("8B0000"); } }
        /// <summary>
        /// Gets a system-defined color that has an ARGB value of #FFE9967A.
        /// </summary>
        public static Color DarkSalmon { get { return FromHtml("E9967A"); } }
        /// <summary>
        /// Gets a system-defined color that has an ARGB value of #FF8FBC8F.
        /// </summary>
        public static Color DarkSeaGreen { get { return FromHtml("8FBC8F"); } }
        /// <summary>
        /// Gets a system-defined color that has an ARGB value of #FF483D8B.
        /// </summary>
        public static Color DarkSlateBlue { get { return FromHtml("483D8B"); } }
        /// <summary>
        /// Gets a system-defined color that has an ARGB value of #FF2F4F4F.
        /// </summary>
        public static Color DarkSlateGray { get { return FromHtml("2F4F4F"); } }
        /// <summary>
        /// Gets a system-defined color that has an ARGB value of #FF00CED1.
        /// </summary>
        public static Color DarkTurquoise { get { return FromHtml("00CED1"); } }
        /// <summary>
        /// Gets a system-defined color that has an ARGB value of #FF9400D3.
        /// </summary>
        public static Color DarkViolet { get { return FromHtml("9400D3"); } }
        /// <summary>
        /// Gets a system-defined color that has an ARGB value of #FFFF1493.
        /// </summary>
        public static Color DeepPink { get { return FromHtml("FF1493"); } }
        /// <summary>
        /// Gets a system-defined color that has an ARGB value of #FF00BFFF.
        /// </summary>
        public static Color DeepSkyBlue { get { return FromHtml("00BFFF"); } }
        /// <summary>
        /// Gets a system-defined color that has an ARGB value of #FF696969.
        /// </summary>
        public static Color DimGray { get { return FromHtml("696969"); } }
        /// <summary>
        /// Gets a system-defined color that has an ARGB value of #FF1E90FF.
        /// </summary>
        public static Color DodgerBlue { get { return FromHtml("1E90FF"); } }
        /// <summary>
        /// Gets a system-defined color that has an ARGB value of #FFB22222.
        /// </summary>
        public static Color Firebrick { get { return FromHtml("B22222"); } }
        /// <summary>
        /// Gets a system-defined color that has an ARGB value of #FFFFFAF0.
        /// </summary>
        public static Color FloralWhite { get { return FromHtml("FFFAF0"); } }
        /// <summary>
        /// Gets a system-defined color that has an ARGB value of #FF228B22.
        /// </summary>
        public static Color ForestGreen { get { return FromHtml("228B22"); } }
        /// <summary>
        /// Gets a system-defined color that has an ARGB value of #FFFF00FF.
        /// </summary>
        public static Color Fuchsia { get { return FromHtml("FF00FF"); } }
        /// <summary>
        /// Gets a system-defined color that has an ARGB value of #FFDCDCDC.
        /// </summary>
        public static Color Gainsboro { get { return FromHtml("DCDCDC"); } }
        /// <summary>
        /// Gets a system-defined color that has an ARGB value of #FFF8F8FF.
        /// </summary>
        public static Color GhostWhite { get { return FromHtml("F8F8FF"); } }
        /// <summary>
        /// Gets a system-defined color that has an ARGB value of #FFFFD700.
        /// </summary>
        public static Color Gold { get { return FromHtml("FFD700"); } }
        /// <summary>
        /// Gets a system-defined color that has an ARGB value of #FFDAA520.
        /// </summary>
        public static Color Goldenrod { get { return FromHtml("DAA520"); } }
        /// <summary>
        /// Gets a system-defined color that has an ARGB value of #FF808080.
        /// </summary>
        public static Color Gray { get { return FromHtml("808080"); } }
        /// <summary>
        /// Gets a system-defined color that has an ARGB value of #FF008000.
        /// </summary>
        public static Color Green { get { return FromHtml("008000"); } }
        /// <summary>
        /// Gets a system-defined color that has an ARGB value of #FFADFF2F.
        /// </summary>
        public static Color GreenYellow { get { return FromHtml("ADFF2F"); } }
        /// <summary>
        /// Gets a system-defined color that has an ARGB value of #FFF0FFF0.
        /// </summary>
        public static Color Honeydew { get { return FromHtml("F0FFF0"); } }
        /// <summary>
        /// Gets a system-defined color that has an ARGB value of #FFFF69B4.
        /// </summary>
        public static Color HotPink { get { return FromHtml("FF69B4"); } }
        /// <summary>
        /// Gets a system-defined color that has an ARGB value of #FFCD5C5C.
        /// </summary>
        public static Color IndianRed { get { return FromHtml("CD5C5C"); } }
        /// <summary>
        /// Gets a system-defined color that has an ARGB value of #FF4B0082.
        /// </summary>
        public static Color Indigo { get { return FromHtml("4B0082"); } }
        /// <summary>
        /// Gets a system-defined color that has an ARGB value of #FFFFFFF0.
        /// </summary>
        public static Color Ivory { get { return FromHtml("FFFFF0"); } }
        /// <summary>
        /// Gets a system-defined color that has an ARGB value of #FFF0E68C.
        /// </summary>
        public static Color Khaki { get { return FromHtml("F0E68C"); } }
        /// <summary>
        /// Gets a system-defined color that has an ARGB value of #FFE6E6FA.
        /// </summary>
        public static Color Lavender { get { return FromHtml("E6E6FA"); } }
        /// <summary>
        /// Gets a system-defined color that has an ARGB value of #FFFFF0F5.
        /// </summary>
        public static Color LavenderBlush { get { return FromHtml("FFF0F5"); } }
        /// <summary>
        /// Gets a system-defined color that has an ARGB value of #FF7CFC00.
        /// </summary>
        public static Color LawnGreen { get { return FromHtml("7CFC00"); } }
        /// <summary>
        /// Gets a system-defined color that has an ARGB value of #FFFFFACD.
        /// </summary>
        public static Color LemonChiffon { get { return FromHtml("FFFACD"); } }
        /// <summary>
        /// Gets a system-defined color that has an ARGB value of #FFADD8E6.
        /// </summary>
        public static Color LightBlue { get { return FromHtml("ADD8E6"); } }
        /// <summary>
        /// Gets a system-defined color that has an ARGB value of #FFF08080.
        /// </summary>
        public static Color LightCoral { get { return FromHtml("F08080"); } }
        /// <summary>
        /// Gets a system-defined color that has an ARGB value of #FFE0FFFF.
        /// </summary>
        public static Color LightCyan { get { return FromHtml("E0FFFF"); } }
        /// <summary>
        /// Gets a system-defined color that has an ARGB value of #FFFAFAD2.
        /// </summary>
        public static Color LightGoldenrodYellow { get { return FromHtml("FAFAD2"); } }
        /// <summary>
        /// Gets a system-defined color that has an ARGB value of #FFD3D3D3.
        /// </summary>
        public static Color LightGray { get { return FromHtml("D3D3D3"); } }
        /// <summary>
        /// Gets a system-defined color that has an ARGB value of #FF90EE90.
        /// </summary>
        public static Color LightGreen { get { return FromHtml("90EE90"); } }
        /// <summary>
        /// Gets a system-defined color that has an ARGB value of #FFFFB6C1.
        /// </summary>
        public static Color LightPink { get { return FromHtml("FFB6C1"); } }
        /// <summary>
        /// Gets a system-defined color that has an ARGB value of #FFFFA07A.
        /// </summary>
        public static Color LightSalmon { get { return FromHtml("FFA07A"); } }
        /// <summary>
        /// Gets a system-defined color that has an ARGB value of #FF20B2AA.
        /// </summary>
        public static Color LightSeaGreen { get { return FromHtml("20B2AA"); } }
        /// <summary>
        /// Gets a system-defined color that has an ARGB value of #FF87CEFA.
        /// </summary>
        public static Color LightSkyBlue { get { return FromHtml("87CEFA"); } }
        /// <summary>
        /// Gets a system-defined color that has an ARGB value of #FF778899.
        /// </summary>
        public static Color LightSlateGray { get { return FromHtml("778899"); } }
        /// <summary>
        /// Gets a system-defined color that has an ARGB value of #FFB0C4DE.
        /// </summary>
        public static Color LightSteelBlue { get { return FromHtml("B0C4DE"); } }
        /// <summary>
        /// Gets a system-defined color that has an ARGB value of #FFFFFFE0.
        /// </summary>
        public static Color LightYellow { get { return FromHtml("FFFFE0"); } }
        /// <summary>
        /// Gets a system-defined color that has an ARGB value of #FF00FF00.
        /// </summary>
        public static Color Lime { get { return FromHtml("00FF00"); } }
        /// <summary>
        /// Gets a system-defined color that has an ARGB value of #FF32CD32.
        /// </summary>
        public static Color LimeGreen { get { return FromHtml("32CD32"); } }
        /// <summary>
        /// Gets a system-defined color that has an ARGB value of #FFFAF0E6.
        /// </summary>
        public static Color Linen { get { return FromHtml("FAF0E6"); } }
        /// <summary>
        /// Gets a system-defined color that has an ARGB value of #FFFF00FF.
        /// </summary>
        public static Color Magenta { get { return FromHtml("FF00FF"); } }
        /// <summary>
        /// Gets a system-defined color that has an ARGB value of #FF800000.
        /// </summary>
        public static Color Maroon { get { return FromHtml("800000"); } }
        /// <summary>
        /// Gets a system-defined color that has an ARGB value of #FF66CDAA.
        /// </summary>
        public static Color MediumAquamarine { get { return FromHtml("66CDAA"); } }
        /// <summary>
        /// Gets a system-defined color that has an ARGB value of #FF0000CD.
        /// </summary>
        public static Color MediumBlue { get { return FromHtml("0000CD"); } }
        /// <summary>
        /// Gets a system-defined color that has an ARGB value of #FFBA55D3.
        /// </summary>
        public static Color MediumOrchid { get { return FromHtml("BA55D3"); } }
        /// <summary>
        /// Gets a system-defined color that has an ARGB value of #FF9370DB.
        /// </summary>
        public static Color MediumPurple { get { return FromHtml("9370DB"); } }
        /// <summary>
        /// Gets a system-defined color that has an ARGB value of #FF3CB371.
        /// </summary>
        public static Color MediumSeaGreen { get { return FromHtml("3CB371"); } }
        /// <summary>
        /// Gets a system-defined color that has an ARGB value of #FF7B68EE.
        /// </summary>
        public static Color MediumSlateBlue { get { return FromHtml("7B68EE"); } }
        /// <summary>
        /// Gets a system-defined color that has an ARGB value of #FF00FA9A.
        /// </summary>
        public static Color MediumSpringGreen { get { return FromHtml("00FA9A"); } }
        /// <summary>
        /// Gets a system-defined color that has an ARGB value of #FF48D1CC.
        /// </summary>
        public static Color MediumTurquoise { get { return FromHtml("48D1CC"); } }
        /// <summary>
        /// Gets a system-defined color that has an ARGB value of #FFC71585.
        /// </summary>
        public static Color MediumVioletRed { get { return FromHtml("C71585"); } }
        /// <summary>
        /// Gets a system-defined color that has an ARGB value of #FF191970.
        /// </summary>
        public static Color MidnightBlue { get { return FromHtml("191970"); } }
        /// <summary>
        /// Gets a system-defined color that has an ARGB value of #FFF5FFFA.
        /// </summary>
        public static Color MintCream { get { return FromHtml("F5FFFA"); } }
        /// <summary>
        /// Gets a system-defined color that has an ARGB value of #FFFFE4E1.
        /// </summary>
        public static Color MistyRose { get { return FromHtml("FFE4E1"); } }
        /// <summary>
        /// Gets a system-defined color that has an ARGB value of #FFFFE4B5.
        /// </summary>
        public static Color Moccasin { get { return FromHtml("FFE4B5"); } }
        /// <summary>
        /// Gets a system-defined color that has an ARGB value of #FFFFDEAD.
        /// </summary>
        public static Color NavajoWhite { get { return FromHtml("FFDEAD"); } }
        /// <summary>
        /// Gets a system-defined color that has an ARGB value of #FF000080.
        /// </summary>
        public static Color Navy { get { return FromHtml("000080"); } }
        /// <summary>
        /// Gets a system-defined color that has an ARGB value of #FFFDF5E6.
        /// </summary>
        public static Color OldLace { get { return FromHtml("FDF5E6"); } }
        /// <summary>
        /// Gets a system-defined color that has an ARGB value of #FF808000.
        /// </summary>
        public static Color Olive { get { return FromHtml("808000"); } }
        /// <summary>
        /// Gets a system-defined color that has an ARGB value of #FF6B8E23.
        /// </summary>
        public static Color OliveDrab { get { return FromHtml("6B8E23"); } }
        /// <summary>
        /// Gets a system-defined color that has an ARGB value of #FFFFA500.
        /// </summary>
        public static Color Orange { get { return FromHtml("FFA500"); } }
        /// <summary>
        /// Gets a system-defined color that has an ARGB value of #FFFF4500.
        /// </summary>
        public static Color OrangeRed { get { return FromHtml("FF4500"); } }
        /// <summary>
        /// Gets a system-defined color that has an ARGB value of #FFDA70D6.
        /// </summary>
        public static Color Orchid { get { return FromHtml("DA70D6"); } }
        /// <summary>
        /// Gets a system-defined color that has an ARGB value of #FFEEE8AA.
        /// </summary>
        public static Color PaleGoldenrod { get { return FromHtml("EEE8AA"); } }
        /// <summary>
        /// Gets a system-defined color that has an ARGB value of #FF98FB98.
        /// </summary>
        public static Color PaleGreen { get { return FromHtml("98FB98"); } }
        /// <summary>
        /// Gets a system-defined color that has an ARGB value of #FFAFEEEE.
        /// </summary>
        public static Color PaleTurquoise { get { return FromHtml("AFEEEE"); } }
        /// <summary>
        /// Gets a system-defined color that has an ARGB value of #FFDB7093.
        /// </summary>
        public static Color PaleVioletRed { get { return FromHtml("DB7093"); } }
        /// <summary>
        /// Gets a system-defined color that has an ARGB value of #FFFFEFD5.
        /// </summary>
        public static Color PapayaWhip { get { return FromHtml("FFEFD5"); } }
        /// <summary>
        /// Gets a system-defined color that has an ARGB value of #FFFFDAB9.
        /// </summary>
        public static Color PeachPuff { get { return FromHtml("FFDAB9"); } }
        /// <summary>
        /// Gets a system-defined color that has an ARGB value of #FFCD853F.
        /// </summary>
        public static Color Peru { get { return FromHtml("CD853F"); } }
        /// <summary>
        /// Gets a system-defined color that has an ARGB value of #FFFFC0CB.
        /// </summary>
        public static Color Pink { get { return FromHtml("FFC0CB"); } }
        /// <summary>
        /// Gets a system-defined color that has an ARGB value of #FFDDA0DD.
        /// </summary>
        public static Color Plum { get { return FromHtml("DDA0DD"); } }
        /// <summary>
        /// Gets a system-defined color that has an ARGB value of #FFB0E0E6.
        /// </summary>
        public static Color PowderBlue { get { return FromHtml("B0E0E6"); } }
        /// <summary>
        /// Gets a system-defined color that has an ARGB value of #FF800080.
        /// </summary>
        public static Color Purple { get { return FromHtml("800080"); } }
        /// <summary>
        /// Gets a system-defined color that has an ARGB value of #FFFF0000.
        /// </summary>
        public static Color Red { get { return FromHtml("FF0000"); } }
        /// <summary>
        /// Gets a system-defined color that has an ARGB value of #FFBC8F8F.
        /// </summary>
        public static Color RosyBrown { get { return FromHtml("BC8F8F"); } }
        /// <summary>
        /// Gets a system-defined color that has an ARGB value of #FF4169E1.
        /// </summary>
        public static Color RoyalBlue { get { return FromHtml("4169E1"); } }
        /// <summary>
        /// Gets a system-defined color that has an ARGB value of #FF8B4513.
        /// </summary>
        public static Color SaddleBrown { get { return FromHtml("8B4513"); } }
        /// <summary>
        /// Gets a system-defined color that has an ARGB value of #FFFA8072.
        /// </summary>
        public static Color Salmon { get { return FromHtml("FA8072"); } }
        /// <summary>
        /// Gets a system-defined color that has an ARGB value of #FFF4A460.
        /// </summary>
        public static Color SandyBrown { get { return FromHtml("F4A460"); } }
        /// <summary>
        /// Gets a system-defined color that has an ARGB value of #FF2E8B57.
        /// </summary>
        public static Color SeaGreen { get { return FromHtml("2E8B57"); } }
        /// <summary>
        /// Gets a system-defined color that has an ARGB value of #FFFFF5EE.
        /// </summary>
        public static Color SeaShell { get { return FromHtml("FFF5EE"); } }
        /// <summary>
        /// Gets a system-defined color that has an ARGB value of #FFA0522D.
        /// </summary>
        public static Color Sienna { get { return FromHtml("A0522D"); } }
        /// <summary>
        /// Gets a system-defined color that has an ARGB value of #FFC0C0C0.
        /// </summary>
        public static Color Silver { get { return FromHtml("C0C0C0"); } }
        /// <summary>
        /// Gets a system-defined color that has an ARGB value of #FF87CEEB.
        /// </summary>
        public static Color SkyBlue { get { return FromHtml("87CEEB"); } }
        /// <summary>
        /// Gets a system-defined color that has an ARGB value of #FF6A5ACD.
        /// </summary>
        public static Color SlateBlue { get { return FromHtml("6A5ACD"); } }
        /// <summary>
        /// Gets a system-defined color that has an ARGB value of #FF708090.
        /// </summary>
        public static Color SlateGray { get { return FromHtml("708090"); } }
        /// <summary>
        /// Gets a system-defined color that has an ARGB value of #FFFFFAFA.
        /// </summary>
        public static Color Snow { get { return FromHtml("FFFAFA"); } }
        /// <summary>
        /// Gets a system-defined color that has an ARGB value of #FF00FF7F.
        /// </summary>
        public static Color SpringGreen { get { return FromHtml("00FF7F"); } }
        /// <summary>
        /// Gets a system-defined color that has an ARGB value of #FF4682B4.
        /// </summary>
        public static Color SteelBlue { get { return FromHtml("4682B4"); } }
        /// <summary>
        /// Gets a system-defined color that has an ARGB value of #FFD2B48C.
        /// </summary>
        public static Color Tan { get { return FromHtml("D2B48C"); } }
        /// <summary>
        /// Gets a system-defined color that has an ARGB value of #FF008080.
        /// </summary>
        public static Color Teal { get { return FromHtml("008080"); } }
        /// <summary>
        /// Gets a system-defined color that has an ARGB value of #FFD8BFD8.
        /// </summary>
        public static Color Thistle { get { return FromHtml("D8BFD8"); } }
        /// <summary>
        /// Gets a system-defined color that has an ARGB value of #FFFF6347.
        /// </summary>
        public static Color Tomato { get { return FromHtml("FF6347"); } }
        /// <summary>
        /// Gets a system-defined color that has an ARGB value of #00000000.
        /// </summary>
        public static Color Transparent { get { return FromArgb(0, 0, 0, 0); } }
        /// <summary>
        /// Gets a system-defined color that has an ARGB value of #FF40E0D0.
        /// </summary>
        public static Color Turquoise { get { return FromHtml("40E0D0"); } }
        /// <summary>
        /// Gets a system-defined color that has an ARGB value of #FFEE82EE.
        /// </summary>
        public static Color Violet { get { return FromHtml("EE82EE"); } }
        /// <summary>
        /// Gets a system-defined color that has an ARGB value of #FFF5DEB3.
        /// </summary>
        public static Color Wheat { get { return FromHtml("F5DEB3"); } }
        /// <summary>
        /// Gets a system-defined color that has an ARGB value of #FFFFFFFF.
        /// </summary>
        public static Color White { get { return FromHtml("FFFFFF"); } }
        /// <summary>
        /// Gets a system-defined color that has an ARGB value of #FFF5F5F5.
        /// </summary>
        public static Color WhiteSmoke { get { return FromHtml("F5F5F5"); } }
        /// <summary>
        /// Gets a system-defined color that has an ARGB value of #FFFFFF00.
        /// </summary>
        public static Color Yellow { get { return FromHtml("FFFF00"); } }
        /// <summary>
        /// Gets a system-defined color that has an ARGB value of #FF9ACD32.
        /// </summary>
        public static Color YellowGreen { get { return FromHtml("9ACD32"); } }

        #endregion

        #region Enums

        /// <summary>
        /// Car colors.
        /// </summary>
        public enum CarColor : int
        {
            Salmon         = 130,
            Jade           = 131,
            PalePistachio  = 132,
            ElectricBlue   = 142,
            TurquoiseBlue  = 144,

        };
        #endregion
    };
};