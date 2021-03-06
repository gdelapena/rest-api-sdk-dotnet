using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using PayPal.Api.Validation;

namespace PayPal.Api.Payments
{
	public class PayerInfo
	{
		/// <summary>
		/// Email address representing the Payer.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string email { get; set; }
	
		/// <summary>
		/// First Name of the Payer from their PayPal Account.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string first_name { get; set; }
	
		/// <summary>
		/// Last Name of the Payer from their PayPal Account.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string last_name { get; set; }
	
		/// <summary>
		/// PayPal assigned Payer ID.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string payer_id { get; set; }
	
		/// <summary>
		/// Phone number representing the Payer.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string phone { get; set; }
	
		/// <summary>
		/// Shipping address of the Payer from their PayPal Account.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public Address shipping_address { get; set; }
	
		/// <summary>
		/// Converts the object to JSON string
		/// </summary>
		public virtual string ConvertToJson() 
    	{ 
    		return JsonFormatter.ConvertToJson(this);
    	}
	}
}


