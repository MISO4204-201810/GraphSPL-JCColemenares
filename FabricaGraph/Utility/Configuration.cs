using FabricaGraph.Enums;
using System;
using System.Configuration;

namespace FabricaGraph.Utility
{
    public class Configuration
    {
        public TypeDirectivity TypeDirectivity { get; set; }
        public TypeWeigthed TypeWeigthed { get; set; }
        public TypeSearch TypeSearch { get; set; }

        private Configuration() { }

        public static Configuration ConfiguracionGlobal
        {
            get
            {
                if (globalConfiguration == null)
                {
                    globalConfiguration = new Configuration
                    {
                        TypeDirectivity = (TypeDirectivity)Enum.ToObject(typeof(TypeDirectivity), Convert.ToSByte(Convert.ToBoolean(ConfigurationManager.AppSettings["HasDirectivity"]))),
                        TypeWeigthed = (TypeWeigthed)Enum.ToObject(typeof(TypeWeigthed), Convert.ToSByte(Convert.ToBoolean(ConfigurationManager.AppSettings["HasWeigthed"]))),
                        TypeSearch = (TypeSearch)Enum.ToObject(typeof(TypeSearch), Convert.ToSByte(ConfigurationManager.AppSettings["TypeSearch"]))
                    };
                }
                return globalConfiguration;
            }
        }

        private static Configuration globalConfiguration;
    }
}
