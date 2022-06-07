using System.Text.Json.Serialization;

namespace BlueChip.Models
{
	public class OrderResponse
	{
		[JsonPropertyName("cnpjCpfDes")]
		public string CnpjCpf { get; set; }

		[JsonPropertyName("numeroPedido")]
		public string NumeroPedido { get; set; }

		[JsonPropertyName("numeroRemessa")]
		public string NumeroRemessa { get; set; }

		[JsonPropertyName("numeroOrdem")]
		public string NumeroOrdem { get; set; }

		[JsonPropertyName("serieNfe")]
		public string SerieNfe { get; set; }

		[JsonPropertyName("numeroNfe")]
		public string NumeroNfe { get; set; }

		[JsonPropertyName("chaveNfe")]
		public string ChaveNfe { get; set; }

		[JsonPropertyName("serieCte")]
		public string SerieCte { get; set; }

		[JsonPropertyName("numeroCte")]
		public string NumeroCte { get; set; }
		
		[JsonPropertyName("chaveCte")]
		public string ChaveCte { get; set; }

		[JsonPropertyName("codMensagem")]
		public string CodMensagem { get; set; }

		[JsonPropertyName("mensagem")]
		public string Mensagem { get; set; }
	}
}
