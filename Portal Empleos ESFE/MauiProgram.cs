using Microsoft.AspNetCore.Components.WebView.Maui;
using Portal_Empleos_ESFE.Service;

//USING AGREGADOS
using Portal_Empleos_ESFE.Data;
using Portal_Empleos_ESFE.Service.Mercadeo;
using Portal_Empleos_ESFE.Service.Electrica;
using Portal_Empleos_ESFE.Service.Software;
using Portal_Empleos_ESFE.Service.Turismo;

namespace Portal_Empleos_ESFE
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
				});

			builder.Services.AddMauiBlazorWebView();
            builder.Services.AddSingleton<IMercadeoService, MercadeoService>();
            builder.Services.AddSingleton<ISoftwareService, SoftwareService>();
            builder.Services.AddSingleton<IElectricaService, ElectricaService>();
            builder.Services.AddSingleton<ITurismoService, TurismoService>();
#if DEBUG
            builder.Services.AddBlazorWebViewDeveloperTools();
#endif

			builder.Services.AddSingleton<WeatherForecastService>();

			return builder.Build();
		}
	}
}