using Microsoft.Extensions.Logging;
using CommunityToolkit.Maui;

namespace Triangle;

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
                fonts.AddFont("Font Awesome 6 Free-Solid-900.otf", "FASolid");
				fonts.AddFont("Font Awesome 6 Brands - Regular - 400.otf", "FABrands");
                fonts.AddFont("Font Awesome 6 Free-Regular-400.otf", "FARegular");
            });

#if DEBUG
		builder.Logging.AddDebug();
#endif

		return builder.Build();
	}
}

