using System.Linq;
using System.Reflection;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace DotaApi.Utils
{
    public class MyContractResolver : CamelCasePropertyNamesContractResolver
    {
        protected override JsonProperty CreateProperty(MemberInfo member,
       MemberSerialization memberSerialization)
        {
            var res = base.CreateProperty(member, memberSerialization);

            res.PropertyName = char.ToLowerInvariant(res.UnderlyingName[0]) + res.UnderlyingName.Substring(1);

            return res;
        }
    }
}
