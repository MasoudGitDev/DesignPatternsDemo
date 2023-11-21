using DesignPatterns.Shared.Services;
using DesignPatterns.Shared.SingletonPattern.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Shared.SingletonPattern.Services {
    public class SingletonFoodService {

        private static readonly List<IPerson> _personsToServe  = new List<IPerson>();
        private static SingletonFoodService?  _instance;
       
        private int _index = 0;

        // private => not allow to create new instance every time! 
        private SingletonFoodService() { }


        // create once and use every time.
        public static SingletonFoodService GetOrCreateInstance(List<IPerson> people) {
            if(_instance is null) {
                _personsToServe.AddRange(people); 
                _instance = new SingletonFoodService();
            }            
            return _instance;
        }

       
        public void Serve() {
            if(_index >= _personsToServe.Count()) {
                _index = 0;
                LogService.Log("\n");
            }
            LogService.Log("Food Service To : " + _personsToServe[_index].Name);
            _index++;
        }
       
    }
}
