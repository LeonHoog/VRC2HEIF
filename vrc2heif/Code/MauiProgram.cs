using Microsoft.Extensions.Logging;
using vrc2heif.View;
using vrc2heif.ViewModel;

namespace vrc2heif;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
        MauiAppBuilder builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
                fonts.AddFont("GolosText-VariableFont_wght.ttf", "GolosText");
            });

		builder.Services.AddSingleton<Settings>();
        builder.Services.AddSingleton<ImageViewModel>();
        builder.Services.AddSingleton<MainPage>();

#if DEBUG
		builder.Logging.AddDebug();
#endif

		return builder.Build();
	}

}
