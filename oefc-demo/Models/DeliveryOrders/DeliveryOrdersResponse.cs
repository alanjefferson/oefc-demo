using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace BlueChip.Models
{
	public class DeliveryOrdersResponse
	{
		[JsonPropertyName("entregas")]
		public List<OrderResponse> DeliveryList { get; set; }
	}
}
