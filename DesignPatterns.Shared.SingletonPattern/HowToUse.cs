using DesignPatterns.Shared.Abstractions;
using DesignPatterns.Shared.Services;
using DesignPatterns.Shared.SingletonPattern.Abstractions;
using DesignPatterns.Shared.SingletonPattern.Models;
using DesignPatterns.Shared.SingletonPattern.Services;


namespace DesignPatterns.Shared.SingletonPattern {
    public class HowToUse : IHowToUse {

        public void MakeExample() {
            // Suppose Get The Persons From Database.
            var personsToServe = new List<IPerson>();
            for (int i = 1; i <= 5; i++) {
                personsToServe.Add(new Person() {Name = "User_" + i});
            }
            // 
            var service1 = SingletonFoodService.GetOrCreateInstance(personsToServe);
            var service2 = SingletonFoodService.GetOrCreateInstance(personsToServe);

            // If HashCode are same means we have a singleton service
            LogService.Log( "HashCode Service1 : " +service1.GetHashCode().ToString());
            LogService.Log("HashCode Service2 : " + service2.GetHashCode().ToString());
            LogService.Log("\n");

            // Check Serving one by one in the loop
            for (int i = 1;i <= 5;i++) {
                service1.Serve();
                service2.Serve();
            }

        }

    }
}
