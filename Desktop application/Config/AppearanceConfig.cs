using CardonerSistemas.Framework.Base;

namespace CSMaps.config;

internal class AppearanceConfig
{

    #region Default values

    // General font
    private const string FontNameDefault = "Microsoft Sans Serif";
    private const float FontSizeDefault = (float)8.25;
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

    #endregion Default values

    #region Fields

    private Font _font;
    private Color _gridRowBackColor;
    private Color _gridRowForeColor;
    private Color _gridRowSelectionBackColor;
    private Color _gridRowSelectionForeColor;
    private Color _gridAlternateRowBackColor;
    private Color _gridAlternateRowForeColor;
    private Color _gridAlternateRowSelectionBackColor;
    private Color _gridAlternateRowSelectionForeColor;

    #endregion Fields

    #region Serializable properties

    public bool EnableVisualStyles { get; set; }
    public int MinimumSplashScreenDisplaySeconds { get; set; }
    public byte MdiFormMargin { get; set; }
    public bool ShowLastLoggedInUser { get; set; }
    public bool UseCustomDialogForErrorMessage { get; set; }
    public string FontName { get; set; }
    public float FontSize { get; set; }
    public bool FontBold { get; set; }
    public string GridRowBackColorValue { get; set; }
    public string GridRowForeColorValue { get; set; }
    public string GridRowSelectionBackColorValue { get; set; }
    public string GridRowSelectionForeColorValue { get; set; }
    public string GridAlternateRowBackColorValue { get; set; }
    public string GridAlternateRowForeColorValue { get; set; }
    public string GridAlternateRowSelectionBackColorValue { get; set; }
    public string GridAlternateRowSelectionForeColorValue { get; set; }

    #endregion Serializable properties

    #region Internal properties

    internal Font Font
    {
        get => GetFont(FontName, FontSize, FontBold, _font, FontNameDefault, FontSizeDefault, FontBoldDefault);
        set
        {
            SetFont(value, out var fontName, out var fontSize, out var fontBold, out _font, FontNameDefault, FontSizeDefault, FontBoldDefault);
            FontName = fontName;
            FontSize = fontSize;
            FontBold = fontBold;
        }
    }

    internal Color GridRowBackColor
    {
        get => GetColor(GridRowBackColorValue, _gridRowBackColor, GridRowBackColorValueDefault);
        set => GridRowBackColorValue = SetColor(value, out _gridRowBackColor, GridRowBackColorValueDefault);
    }

    internal Color GridRowForeColor
    {
        get => GetColor(GridRowForeColorValue, _gridRowForeColor, GridRowForeColorValueDefault);
        set => GridRowForeColorValue = SetColor(value, out _gridRowForeColor, GridRowForeColorValueDefault);
    }

    internal Color GridRowSelectionBackColor
    {
        get => GetColor(GridRowSelectionBackColorValue, _gridRowSelectionBackColor, GridRowSelectionBackColorValueDefault);
        set => GridRowSelectionBackColorValue = SetColor(value, out _gridRowSelectionBackColor, GridRowSelectionBackColorValueDefault);
    }

    internal Color GridRowSelectionForeColor
    {
        get => GetColor(GridRowSelectionForeColorValue, _gridRowSelectionForeColor, GridRowSelectionForeColorValueDefault);
        set => GridRowSelectionForeColorValue = SetColor(value, out _gridRowSelectionForeColor, GridRowSelectionForeColorValueDefault);
    }

    internal Color GridAlternateRowBackColor
    {
        get => GetColor(GridAlternateRowBackColorValue, _gridAlternateRowBackColor, GridAlternateRowBackColorValueDefault);
        set => GridAlternateRowBackColorValue = SetColor(value, out _gridAlternateRowBackColor, GridAlternateRowBackColorValueDefault);
    }

    internal Color GridAlternateRowForeColor
    {
        get => GetColor(GridAlternateRowForeColorValue, _gridAlternateRowForeColor, GridAlternateRowForeColorValueDefault);
        set => GridAlternateRowForeColorValue = SetColor(value, out _gridAlternateRowForeColor, GridAlternateRowForeColorValueDefault);
    }

    internal Color GridAlternateRowSelectionBackColor
    {
        get => GetColor(GridAlternateRowSelectionBackColorValue, _gridAlternateRowSelectionBackColor, GridAlternateRowSelectionBackColorValueDefault);
        set => GridAlternateRowSelectionBackColorValue = SetColor(value, out _gridAlternateRowSelectionBackColor, GridAlternateRowSelectionBackColorValueDefault);
    }

    internal Color GridAlternateRowSelectionForeColor
    {
        get => GetColor(GridAlternateRowSelectionForeColorValue, _gridAlternateRowSelectionForeColor, GridAlternateRowSelectionForeColorValueDefault);
        set => GridAlternateRowSelectionForeColorValue = SetColor(value, out _gridAlternateRowSelectionForeColor, GridAlternateRowSelectionForeColorValueDefault);
    }

    #endregion Internal properties

    #region Special properties assignment

    private static Font GetFont(string name, float size, bool bold, Font font, string nameDefault, float sizeDefault, bool boldDefault)
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

    private static void SetFont(Font value, out string name, out float size, out bool bold, out Font font, string nameDefault, float sizeDefault, bool boldDefault)
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
#pragma warning disable IDE0046 // Convert to conditional expression
        if (color.IsEmpty)
        {
            return string.IsNullOrWhiteSpace(colorStringDefault) ? string.Empty : colorStringDefault;
        }
        else
        {
            return Colors.SetToNamedOrHexRgbString(color);
        }
#pragma warning restore IDE0046 // Convert to conditional expression
    }

    #endregion Special properties assignment

}