using DACFW.Entities;
using Newtonsoft.Json;
using System;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace DACFW.Repositories
{
	public class ItrisRelevamientoRepository
	{
		private HttpClient httpClient;
		private HttpResponseMessage httpResponseMessage;
		ItrisPlanillaEntity response;

		public async Task<ItrisPlanillaEntity> Post(string urlRequest, ItrisPlanillaEntity request)
		{
			try
			{
				//Agrego session al request por reflection
				//request.GetType().GetProperty(USER_SESSION_PROPERTY).SetValue(
				//	request, ItrisSessionRepository.GetInstance().sessionString(), null);

				httpClient = new HttpClient();
				StringContent stringContent = 
					new StringContent(JsonConvert.SerializeObject(request), Encoding.UTF8, "application/json");

				httpResponseMessage = await httpClient.PostAsync(new Uri(urlRequest), stringContent);

				var stringResponse = httpResponseMessage.Content.ReadAsStringAsync().Result;
				response = JsonConvert.DeserializeObject<ItrisPlanillaEntity>(stringResponse);

				//AGREGAR MENSAJES CUSTOM DE ERRORES CUANDO FALLA O SALE OK
				//if (httpResponseMessage.StatusCode == HttpStatusCode.BadRequest)
				//{
				//	//this.AuthenticateRepository();
				//	//return await this.Post(urlRequest, request);
				//}
			}
			catch (HttpRequestException reqx)
			{
				throw reqx;
			}
			catch (Exception ex)
			{
				throw ex;
			}
			return response;
		}

	}
}
