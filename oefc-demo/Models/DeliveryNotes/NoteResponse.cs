using System.Text.Json.Serialization;

namespace BlueChip
{
	public class NoteResponse
	{
		[JsonPropertyName("cnpjCpfDes")]
		public string CnpjCpf { get; set; }

		[JsonPropertyName("numeroPedido")]
		public string RequestNumber { get; set; }

		[JsonPropertyName("numeroRemessa")]
		public string ShippingNumber { get; set; }

		[JsonPropertyName("codMensagem")]
		public string MessageCode { get; set; }

		[JsonPropertyName("mensagem")]
		public string Message { get; set; }
	}
}
