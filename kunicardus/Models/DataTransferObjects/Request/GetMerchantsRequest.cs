using Kunicardus.Core.UnicardApiProvider;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kunicardus.Core.Models.DataTransferObjects.Request
{
    public class GetMerchantsRequest : UnicardApiBaseRequest
    {
        [Newtonsoft.Json.JsonProperty("org_id")]
        public int? OrganizationId { get; set; }
        [Newtonsoft.Json.JsonProperty("city_id")]
        public int? CityId { get; set; }
        [Newtonsoft.Json.JsonProperty("district_id")]
        public int? DistrictId { get; set; }
    }
}
