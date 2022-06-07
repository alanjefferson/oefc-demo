using BlueChip.Context;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlueChip.Models
{
	public class UsuarioRepository
	{
		protected readonly ContextDb _context;
		protected readonly DiscaFacilInfo _discaFacilInfo;

		public UsuarioRepository(ContextDb context, DiscaFacilInfo discaFacilInfo)
		{
			_context = context;
			_discaFacilInfo = discaFacilInfo;
		}

		public async Task<List<Usuario>> GetUserByLogin(string USUA_NM_LOGIN)
		{
			List<Usuario> lstUsuario = await _context.Usuario.Where(x =>
				    (x.USUA_NM_LOGIN == USUA_NM_LOGIN) && (x.OPER_CD_ID_FK == _discaFacilInfo.OPER_CD_ID_FK)
			).ToListAsync();

			return lstUsuario;
		}
	}
}
