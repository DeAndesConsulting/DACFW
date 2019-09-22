using DACFW.Entities;
using DACFW.Repositories;
using System;
using System.Threading.Tasks;

namespace DACFW.Business
{
	public class ItrisRelevamientoBusiness
	{
		private ItrisRelevamientoRepository itrisRelevamientoRepository;

		public ItrisRelevamientoBusiness()
		{
			itrisRelevamientoRepository = new ItrisRelevamientoRepository();
		}

		public async Task<ItrisPlanillaEntity> Post(string urlRequest, ItrisPlanillaEntity request)
		{
			return await itrisRelevamientoRepository.Post(urlRequest, request);
		}
	}
}
