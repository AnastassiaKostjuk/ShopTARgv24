using ShopTARgv24.Core.ServiceInterface;
using ShopTARgv24.Core.Dto;
using System.Text.Json;

namespace ShopTARgv24.ApplicationServices.Services
{
    internal class WeatherForecastServices : IWeatherForecastServices
    {
        public async Task<AccuLocationWeatherResultDto> AccuWeatherResult(AccuLocationWeatherResultDto dto)
        {
            string accuApiKey = "your_api";
            string baseUrl = "http://dataservice.accuweather.com/forecasts/v1/daily/1day";

            using (var httpClient = new HttpClient())
            {
                httpClient.BaseAddress = new Uri(baseUrl);
                httpClient.DefaultRequestHeaders.Accept.Clear();
                httpClient.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
                var response = await httpClient.GetAsync($"{127964}?apikey ={accuApiKey}&details=true");
                if(response.IsSuccessStatusCode)
                {
                    var jsonResponse = await response.Content.ReadAsStringAsync();
                    var weatherData = JsonSerializer.Deserialize<AccuLocationWeatherResultDto>(jsonResponse);
                    return weatherData;
                }
                else
                {
                    throw new Exception("Error retrieving weather data from AccuWeather API");
                }
            }

        }
    }
}
