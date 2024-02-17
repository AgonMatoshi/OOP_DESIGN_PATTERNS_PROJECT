using System;
using System.Collections.Generic;
using OnlineFoodDelivery.DatabaseConnection;
using OnlineFoodDelivery.Iterator;
using OnlineFoodDelivery.OrderObserver;
using OnlineFoodDelivery.PaymentAdapter;
using OnlineFoodDelivery.PaymentAdapter.PaymentMethods;

class Program
{
    static void Main(string[] args)
    {
        var dbConnection = DatabaseConnection.Instance;
        dbConnection.Connect();
        
        // Even if we try to get another instance, we will get the same one.
        var anotherDbConnection = DatabaseConnection.Instance;
        anotherDbConnection.Connect();
        
        // Create the menu
        Menu menu = new Menu();
        IMenuIterator iterator = menu.CreateIterator();

        while (iterator.HasNext())
        {
            MenuItem menuItem = iterator.Next();
            Console.WriteLine(menuItem.ToString());
        }
        
        IPaymentAdapter creditCardPayment = new CreditCardPaymentAdapter(new CreditCardPayment());
        creditCardPayment.ProcessPayment(10.00);

        IPaymentAdapter payPalPayment = new PayPalPaymentAdapter(new PayPalPayment());
        payPalPayment.ProcessPayment(20.00);
        
        // Create the order
        var order = new Order();

        // Create observers
        var customer = new Customer();
        var restaurant = new Restaurant();
        var deliveryPerson = new DeliveryPerson();

        // Attach observers to the order
        order.Attach(customer);
        order.Attach(restaurant);
        order.Attach(deliveryPerson);

        // Update order status and notify observers
        order.OrderStatus = "Prepared";
        order.NotifyObservers();

        // Change order status and notify again
        order.OrderStatus = "Out for delivery";
        order.NotifyObservers();
    }
}
