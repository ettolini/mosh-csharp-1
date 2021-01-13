using System; // Needed to use the Enum Class Methods

namespace EnumsDemo // Since Enum represents a new type, it needs to be defined at the main space level
{                               // If you don't set any values to your enum members, the first value will be set to 0.
    public enum ShippingMethod  // The second will be 1, the third 2, and so on. For best practice, always set values for your members.
    {  
        RegularAirMail = 1, RegisteredAirMail = 2, Express = 3
    }
    class Program
    {
        static void Main(string[] args)
        {
            // FROM ENUM TO INTEGER
            var method = ShippingMethod.Express;
            System.Console.WriteLine((int)method); // Value casted to an integer. Returns 3
            // FROM INTEGER TO ENUM
            var methodId = 3;
            System.Console.WriteLine((ShippingMethod)methodId); // Value casted to a ShippingMethod. Returns Express
            // FROM ENUM TO STRING
            System.Console.WriteLine(method.ToString()); // ToString Method can convert any given value to a string. Returns Express
            System.Console.WriteLine(method); // Console.WriteLine always applies the ToString Method to any given value. Returns Express
            // FROM STRING TO ENUM
            var methodName = "Express";
            Enum.Parse(typeof(ShippingMethod), methodName); // "Parsing" means converting a string to a different type            
            // If we did that, it would return an Object, not a ShippingMethod, so we need to cast the result like the following...
            var shippingMethod = (ShippingMethod)Enum.Parse(typeof(ShippingMethod), methodName);
        }
    }
}