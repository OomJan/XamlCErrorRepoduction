using CommunityToolkit.Maui;
using Microsoft.Extensions.Logging;
using XamlCErrorReproductionLibrary;

namespace XamlCErrorRepoduction
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
            // Initialize the .NET MAUI Community Toolkit by adding the below line of code
            .UseMauiCommunityToolkit()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

#if DEBUG
            builder.Logging.AddDebug();
#endif

            MauiCommunityTookitUnlinkProtection();

            return builder.Build();
        }

    private static void MauiCommunityTookitUnlinkProtection()
        {
            // Forciert das die Toolkit Bibliothek nicht weg optimiert wird selbst wenn auf diese in XAML drauf zugegriffen wird!
            var tInitToolkit = new CommunityToolkit.Maui.Core.SnackbarOptions();
            tInitToolkit.BackgroundColor = null;
        }
    }
}
