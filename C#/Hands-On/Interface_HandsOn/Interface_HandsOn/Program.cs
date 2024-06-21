using System;

namespace InterfaceCode
{
    // Define interfaces with renamed names
    interface IClient
    {
        void Display(string msg); // Changed method name
        int Calculate(int x, int y, int z); // Changed method name
    }

    interface IProvider : IClient // Changed interface name and inheritance
    {
        void ProcessOrder(int orderId); // Changed method name
        void ShipOrder(string address); // Added a new method
    }

    // Implement interfaces with renamed names
    class Customer : IProvider
    {
        public int Calculate(int x, int y, int z)
        {
            int result = x + y + z; // Changed calculation
            return result;
        }

        public void Display(string msg)
        {
            Console.WriteLine("Displaying IClient: " + msg); // Changed message format
        }

        public void ProcessOrder(int orderId)
        {
            Console.WriteLine("Processing order #{0}", orderId); // Changed message
        }

        public void ShipOrder(string address)
        {
            Console.WriteLine("Shipping to: " + address); // New method implementation
        }
    }

    // Main program
    class Program
    {
        static void Main(string[] args)
        {
            // Creating object of Customer class
            Customer cust = new Customer();

            // Calling methods directly on the object
            Console.WriteLine(cust.Calculate(12, 16, 8)); // Changed values
            cust.Display("Message updated"); // Changed message
            cust.ProcessOrder(123); // Changed orderId
            cust.ShipOrder("123 Main St"); // New method call

            Console.WriteLine("--------- With Interface Instance Reference ---------");

            // Using interface references
            IClient iclient = new Customer(); // Changed interface reference type
            Console.WriteLine(iclient.Calculate(100, 200, 50)); // Changed values
            iclient.Display("Using Interface reference object updated"); // Changed message

            IProvider iprovider = new Customer(); // Changed interface reference type
            iprovider.ProcessOrder(456); // Changed orderId
            iprovider.ShipOrder("456 Oak St"); // New method call

            // Pause before exit (for seeing output in console)
            Console.ReadLine();
        }
    }
}
