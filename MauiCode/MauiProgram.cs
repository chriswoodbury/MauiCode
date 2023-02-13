using Microsoft.Extensions.Logging;

namespace MauiCode;

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
			});

		Routing.RegisterRoute(nameof(DetailPage), typeof(DetailPage));    

#if DEBUG
        builder.Logging.AddDebug();
#endif

		return builder.Build();
	}
}
