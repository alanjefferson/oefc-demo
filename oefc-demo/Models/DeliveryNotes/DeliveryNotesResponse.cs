using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace BlueChip.Models
{
	public class DeliveryNotesResponse
	{
		[JsonPropertyName("entregas")]
		public List<NoteResponse> DeliveryList { get; set; }
	}
}
