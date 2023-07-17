﻿using System.Text.RegularExpressions;

namespace Plugin.Maui.ScreenSecurity.Platforms.iOS;

internal static partial class StringExtensions
{
    internal static bool IsHexColor(this string hexColor) => ValidHexColorRegex().IsMatch(hexColor);

    internal static bool IsValidImage(this string image) => ValidImageRegex().IsMatch(image);

    [GeneratedRegex("([^\\s]+(\\.(?i)(jpe?g|png|gif|bmp|svg))$)", RegexOptions.None)]
    private static partial Regex ValidImageRegex();

    [GeneratedRegex("^#([a-fA-F0-9]{8}|[a-fA-F0-9]{6})$")]
    private static partial Regex ValidHexColorRegex();
}