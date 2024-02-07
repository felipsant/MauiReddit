using Microsoft.Extensions.Logging;

namespace MauiReddit.App
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                    fonts.AddFont("Font_Awesome_6_Free-Regular-400.otf", "FontAwesome-Regular");
                    fonts.AddFont("Font_Awesome_6_Free-Solid-900.otf", "FontAwesome-Solid");
                });

#if DEBUG
    		builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
