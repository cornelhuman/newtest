using BlazorBindings.Maui;

namespace NewTest;

public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        
        var builder = MauiApp.CreateBuilder();
        builder
            .UseMauiApp<App>()
            .UseMauiBlazorBindings()
            .ConfigureFonts(fonts =>
            {
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                fonts.AddFont("fa-solid-900.ttf", "FontAwesome");
            });

        return builder.Build();
    }
    
}


