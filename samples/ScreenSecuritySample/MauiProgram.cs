﻿using CommunityToolkit.Maui;
using Plugin.Maui.ScreenSecurity;
using ScreenSecuritySample.Views;

namespace ScreenSecuritySample;

public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();
        builder
            .UseMauiApp<App>()
            .UseMauiCommunityToolkit()
            .ConfigureFonts(fonts =>
            {
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
            });

        // Android Transient Pages
        builder.Services.AddTransient<SecuredPage>();
        builder.Services.AddTransient<SecurityScreenTestPage>();

        // iOS Transient Pages
        builder.Services.AddTransient<BlurProtectionPage>();
        builder.Services.AddTransient<ColorProtectionPage>();
        builder.Services.AddTransient<ImageProtectionPage>();
        builder.Services.AddTransient<RecordingProtectionPage>();

        builder.Services.AddSingleton<IScreenSecurity>(ScreenSecurity.Default);

        return builder.Build();
    }
}