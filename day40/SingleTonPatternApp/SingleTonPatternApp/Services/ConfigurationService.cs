using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleTonPatternApp.Services
{
    
    internal  class ConfigurationService
    {

        private static ConfigurationService _bucket=null;
        private ConfigurationService() {
           
            Console.WriteLine("Service created");

        }
        public static ConfigurationService CreateInstance() { 
        
           if(_bucket==null)
                _bucket = new ConfigurationService();


            return _bucket;
        }


        public void DoSomething() {
            
            Console.WriteLine("fetching configuration details from redis cache..by"+this.GetHashCode());

        }
    }
}
