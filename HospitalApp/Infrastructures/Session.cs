using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalApp.Infrastructures
{
   public static class Session
    {
        public static Dictionary<string,object> ValuePairs { get; set; }
        static Session()
        {
            ValuePairs = new Dictionary<string, object>();
        }
        public static void SetValue(string key,object obj)
        {
            
            
            ValuePairs.Add(key, obj);
        }
        public static object GetValue(string key)
        {
            ValuePairs.TryGetValue(key, out object value);
            return value;
                
        }
    }
}
