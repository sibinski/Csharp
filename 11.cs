using System;

public class Shipment
{
    public static void Main(string[] args)
    {
        string[] orderStatuses = {"Pending", "Shipped", "Delivered", "Cancelled"};
        for(int i=0; i < orderStatuses.Length; i++)
        {
            string orderStatus = orderStatuses[i];
            switch(orderStatus)
            {
                case "Pending":
                Console.WriteLine("Current status is \"Pending\" for the given parcel.");
                break;
                case "Shipped":
                Console.WriteLine("The given parcel has been shipped according to its current status.");
                break;
                case "Delivered":
                Console.WriteLine("The given parcel has been delivered according to its current status.");
                break;
                case "Cancelled":
                Console.WriteLine("Shipment has been cancelled.");
                break;
                default:
                Console.WriteLine("Current status is unknown");
                break;
            }
        }
    }
}