using System;
using System.Xml;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Sto.Synchronization.SAP_to_SalesForce.Console.Utility
{
    public static class Extender
    {

        public static T DeSerializeObject<T>(this String jsonParameter)
        {
            return JsonConvert.DeserializeObject<T>(jsonParameter, new IsoDateTimeConverter { DateTimeFormat = "dd/MM/yyyy HH:mm" });
        }

        public static string SerializeObject<T>(this T inputObject)
        {
            return JsonConvert.SerializeObject(inputObject, new IsoDateTimeConverter { DateTimeFormat = "dd/MM/yyyy HH:mm" });
        }

        public static XmlDocument DeSerializeToXml(string jsonObject)
        {
            return JsonConvert.DeserializeXmlNode(jsonObject);
        }

    }
}
