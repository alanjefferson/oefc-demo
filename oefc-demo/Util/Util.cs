using BlueChip.Models;

namespace BlueChip.Util
{
	public static class Util
	{
		public static string GetUserFromToken(string token)
		{
			return Crypt.Decrypt(token).Substring(0, 6);
		}

		public static string CreateToken(string USUA_NM_LOGIN, string ClientSecret)
		{
			string decryptToken = string.Format("{0}{1}", USUA_NM_LOGIN, ClientSecret);
			return Crypt.Encrypt(decryptToken);
		}

		public static NoteResponse BuildErrorMessage(string message, Note note = null)
		{
			NoteResponse noteResponse = new();
			noteResponse.CnpjCpf = string.Empty;
			noteResponse.RequestNumber = (note != null) ? note.numeroPedido : string.Empty;
			noteResponse.ShippingNumber = (note != null) ? note.numeroRemessa : string.Empty;
			noteResponse.MessageCode = "2";
			noteResponse.Message = message;

			return noteResponse;
		}
	}
}
