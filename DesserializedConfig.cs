using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace JsonConfigOnConsoleAppPoc
{
    public class DesserializedConfig
    {
        public bool aBoolProp { get; set; }

        public string aStringProp { get; set; }
		public int anIntProp { get; set; }
		public char aCharProp { get; set; }
		public float aFloatProp { get; set; }
		public decimal aDecimalProp { get; set; }
		public IList<string> aListProp { get; set; }
		public IDictionary<string,string> aDictionaryProp { get; set; }
		public ObjectProp anObjectProp { get; set; }
		public IList<ObjectProp> aListOfObjectsProp { get; set; }

        public override string ToString()
        {
            return JsonConvert.SerializeObject(this);
        }
    }
}
