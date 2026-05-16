using Microsoft.Extensions.Logging;

namespace MauiAppHotel
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
                    fonts.AddFont("EduAUVICWANTGuides-VariableFont_wght.ttf", "Edu");
                    fonts.AddFont("NothingYouCouldDo-Regular.ttf", "NothingYouCouldDo");
                    fonts.AddFont("CormorantGaramond-Bold.ttf", "CormorantBold");
                    fonts.AddFont("CormorantGaramond-Medium.ttf", "CormorantMedium");
                    fonts.AddFont("CormorantGaramond-Regular.ttf", "CormorantRegular");


                });

#if DEBUG
    		builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
