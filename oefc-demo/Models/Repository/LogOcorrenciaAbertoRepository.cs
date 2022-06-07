using BlueChip.Context;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace BlueChip.Models
{
	public class LogOcorrenciaAbertoRepository
	{
		protected readonly ContextDb _context;
		protected readonly DiscaFacilInfo _discaFacilInfo;

		public LogOcorrenciaAbertoRepository(ContextDb context, DiscaFacilInfo discaFacilInfo)
		{
			_context = context;
			_discaFacilInfo = discaFacilInfo;
		}
				
	}
}
