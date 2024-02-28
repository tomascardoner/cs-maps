using CardonerSistemas.Framework.Base;

namespace CSMaps
{
    internal class AppearanceConfig
    {

        #region Default values

        // General font
        private const string FontNameDefault = "Microsoft Sans Serif";
        private const Single FontSizeDefault = (float)8.25;
        private const bool FontBoldDefault = false;

        // Grid row colors
        private const string GridRowBackColorValueDefault = "Window";
        private const string GridRowForeColorValueDefault = "ControlText";
        private const string GridRowSelectionBackColorValueDefault = "Highlight";
        private const string GridRowSelectionForeColorValueDefault = "HighlightText";
        private const string GridAlternateRowBackColorValueDefault = "GradientActiveCaption";
        private const string GridAlternateRowForeColorValueDefault = "ControlText";
        private const string GridAlternateRowSelectionBackColorValueDefault = "Highlight";
        private const string GridAlternateRowSelectionForeColorValueDefault = "HighlightText";

        #endregion

        #region Fields

        private Font _Font;
        private Color _GridRowBackColor;
        private Color _GridRowForeColor;
        private Color _GridRowSelectionBackColor;
        private Color _GridRowSelectionForeColor;
        private Color _GridAlternateRowBackColor;
        private Color _GridAlternateRowForeColor;
        private Color _GridAlternateRowSelectionBackColor;
        private Color _GridAlternateRowSelectionForeColor;

        #endregion

        #region Serializable properties

        public bool EnableVisualStyles { get; set; }
        public int MinimumSplashScreenDisplaySeconds { get; set; }
        public byte MdiFormMargin { get; set; }
        public bool ShowLastLoggedInUser { get; set; }
        public bool UseCustomDialogForErrorMessage { get; set; }
        public string FontName { get; set; }
        public Single FontSize { get; set; }
        public bool FontBold { get; set; }
        public string GridRowBackColorValue { get; set; }
        public string GridRowForeColorValue { get; set; }
        public string GridRowSelectionBackColorValue { get; set; }
        public string GridRowSelectionForeColorValue { get; set; }
        public string GridAlternateRowBackColorValue { get; set; }
        public string GridAlternateRowForeColorValue { get; set; }
        public string GridAlternateRowSelectionBackColorValue { get; set; }
        public string GridAlternateRowSelectionForeColorValue { get; set; }
        public int WeightDisplayWidth { get; set; }
        public int WeightDisplayHeight { get; set; }
        public string WeightDisplayBackColorValue { get; set; }
        public string WeightDisplayForeColorValue { get; set; }
        public string WeightDisplayFontName { get; set; }
        public Single WeightDisplayFontSize { get; set; }
        public bool WeightDisplayFontBold { get; set; }

        #endregion

        #region Internal properties

        internal Font Font
        {
            get => GetFont(FontName, FontSize, FontBold, _Font, FontNameDefault, FontSizeDefault, FontBoldDefault);
            set
            {
                SetFont(value, out string fontName, out Single fontSize, out bool fontBold, out _Font, FontNameDefault, FontSizeDefault, FontBoldDefault);
                FontName = fontName;
                FontSize = fontSize;
                FontBold = fontBold;
            }
        }

        internal Color GridRowBackColor
        {
            get => GetColor(GridRowBackColorValue, _GridRowBackColor, GridRowBackColorValueDefault);
            set => GridRowBackColorValue = SetColor(value, out _GridRowBackColor, GridRowBackColorValueDefault);
        }

        internal Color GridRowForeColor
        {
            get => GetColor(GridRowForeColorValue, _GridRowForeColor, GridRowForeColorValueDefault);
            set => GridRowForeColorValue = SetColor(value, out _GridRowForeColor, GridRowForeColorValueDefault);
        }

        internal Color GridRowSelectionBackColor
        {
            get => GetColor(GridRowSelectionBackColorValue, _GridRowSelectionBackColor, GridRowSelectionBackColorValueDefault);
            set => GridRowSelectionBackColorValue = SetColor(value, out _GridRowSelectionBackColor, GridRowSelectionBackColorValueDefault);
        }

        internal Color GridRowSelectionForeColor
        {
            get => GetColor(GridRowSelectionForeColorValue, _GridRowSelectionForeColor, GridRowSelectionForeColorValueDefault);
            set => GridRowSelectionForeColorValue = SetColor(value, out _GridRowSelectionForeColor, GridRowSelectionForeColorValueDefault);
        }

        internal Color GridAlternateRowBackColor
        {
            get => GetColor(GridAlternateRowBackColorValue, _GridAlternateRowBackColor, GridAlternateRowBackColorValueDefault);
            set => GridAlternateRowBackColorValue = SetColor(value, out _GridAlternateRowBackColor, GridAlternateRowBackColorValueDefault);
        }

        internal Color GridAlternateRowForeColor
        {
            get => GetColor(GridAlternateRowForeColorValue, _GridAlternateRowForeColor, GridAlternateRowForeColorValueDefault);
            set => GridAlternateRowForeColorValue = SetColor(value, out _GridAlternateRowForeColor, GridAlternateRowForeColorValueDefault);
        }

        internal Color GridAlternateRowSelectionBackColor
        {
            get => GetColor(GridAlternateRowSelectionBackColorValue, _GridAlternateRowSelectionBackColor, GridAlternateRowSelectionBackColorValueDefault);
            set => GridAlternateRowSelectionBackColorValue = SetColor(value, out _GridAlternateRowSelectionBackColor, GridAlternateRowSelectionBackColorValueDefault);
        }

        internal Color GridAlternateRowSelectionForeColor
        {
            get => GetColor(GridAlternateRowSelectionForeColorValue, _GridAlternateRowSelectionForeColor, GridAlternateRowSelectionForeColorValueDefault);
            set => GridAlternateRowSelectionForeColorValue = SetColor(value, out _GridAlternateRowSelectionForeColor, GridAlternateRowSelectionForeColorValueDefault);
        }

        #endregion

        #region Special properties assignment

        private static Font GetFont(string name, Single size, bool bold, Font font, string nameDefault, Single sizeDefault, bool boldDefault)
        {
            if (font == null)
            {
                if (string.IsNullOrWhiteSpace(name) || size <= 0)
                {
                    name = nameDefault;
                    size = sizeDefault;
                    bold = boldDefault;
                }
                try
                {
                    name = name.Trim();
                    font = new Font(name, size, bold ? FontStyle.Bold : FontStyle.Regular);
                }
                catch (ArgumentException ex)
                {
                    Error.ProcessException(ex, $"Error al convertir el nombre de la tipografía '{name}' a una tipografía válida del sistem.");
                }
            }
            return font;
        }

        private static void SetFont(Font value, out string name, out Single size, out bool bold, out Font font, string nameDefault, Single sizeDefault, bool boldDefault)
        {
            font = value;
            if (font == null)
            {
                name = nameDefault;
                size = sizeDefault;
                bold = boldDefault;
            }
            else
            {
                name = font.Name;
                size = font.Size;
                bold = font.Bold;
            }
        }

        private static Color GetColor(string colorString, Color color, string colorStringDefault)
        {
            if (color.IsEmpty)
            {
                Colors.GetFromHexOrNameString(colorString, ref color, Colors.RegExHexadecimalRgbDoubleDigits, colorStringDefault);
            }
            return color;
        }

        private static string SetColor(Color value, out Color color, string colorStringDefault)
        {
            color = value;
            if (color.IsEmpty)
            {
                if (string.IsNullOrWhiteSpace(colorStringDefault))
                {
                    return string.Empty;
                }
                else
                {
                    return colorStringDefault;
                }
            }
            else
            {
                return Colors.SetToNamedOrHexRgbString(color);
            }
        }

        #endregion

    }
}