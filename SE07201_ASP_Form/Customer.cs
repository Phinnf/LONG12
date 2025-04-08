using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SE07201_ASP_Form
{
    // The Customer class represents a customer and their associated information
    class Customer : IComparable<Customer>
    {
        
        public string Name { get; set; }
        public int LastMonthWater { get; set; }
        public int ThisMonthWater { get; set; }
        public int CustomerType { get; set; }
        public int NumberOfPeople { get; set; }

        public Customer()
        {
        }
        // Constructor that initializes the customer's information
        public Customer(string name, int lastMonthWater, int thisMonthWater, int customerType, int numberOfPeople)
        {
            Name = name;
            LastMonthWater = lastMonthWater;
            ThisMonthWater = thisMonthWater;
            CustomerType = customerType;
            NumberOfPeople = numberOfPeople;
        }
        // This is a class that calculates the total water bill for a customer
        public double totalWaterBill()
        {
            double totalWaterBill = 0;
            int consumption = ThisMonthWater - LastMonthWater;

            // Calculate the total water bill based on the customer type
            switch (CustomerType)
            {
                case 1:
                    double avgConsumption = (double)consumption / (double)NumberOfPeople;
                    if (avgConsumption <= 10)
                        totalWaterBill = consumption * 5973 * 1.1;
                    else if (avgConsumption > 10 && avgConsumption <= 20)
                        totalWaterBill = (NumberOfPeople * 10 * 5973 * 1.1)
                                           + ((consumption - NumberOfPeople * 10) * 7052 * 1.1);
                    else if (avgConsumption > 20 && avgConsumption <= 30)
                        totalWaterBill = (NumberOfPeople * 10 * 5973 * 1.1)
                                         + (NumberOfPeople * 10 * 7052 * 1.1)
                                           + ((consumption - NumberOfPeople * 20) * 8699 * 1.1);
                    else
                        totalWaterBill = (NumberOfPeople * 10 * 5973 * 1.1)
                                         + (NumberOfPeople * 10 * 7052 * 1.1)
                                         + (NumberOfPeople * 10 * 8699 * 1.1)
                                           + ((consumption - NumberOfPeople * 30) * 9955 * 1.1);
                    break;
                case 2:
                    totalWaterBill = consumption * 9955 * 1.1;
                    break;
                case 3:
                    totalWaterBill = consumption * 11615 * 1.1;
                    break;
                case 4:
                    totalWaterBill = consumption * 22068 * 1.1;
                    break;
                default:
                    totalWaterBill = 0;
                    break;
            }
            return totalWaterBill;
        }
        // This method compares the name of the current customer to the name of another customer
        public int CompareTo(Customer other)
        {
            return this.Name.CompareTo(other.Name);
        }
        // This method searches the list of customers for a customer with the given name and adds the customer to the result list if a match is found
        public static List<Customer> searchByName(String name, List<Customer> listCustomers)
        {
            List<Customer> result = new List<Customer>();
            foreach (Customer customer in listCustomers)
            {
                if (customer.Name.Contains(name))
                {
                    result.Add(customer);
                }
            }
            return result;
        }
        // This method look for a customers with a matching name
        public static void outputInvoices(string cusName, List<Customer> listCustomers)
        {
            foreach (Customer customer in listCustomers)
            {
                if (customer.Name.Equals(cusName))
                {
                    Console.WriteLine("===================Invoices: {0}===================", customer.Name);
                    Console.WriteLine(" Last Month Water Reading: {0}", customer.LastMonthWater);
                    Console.WriteLine(" This Month Water Reading: {0}", customer.ThisMonthWater);
                    Console.WriteLine(" Consumption Water : {0}", customer.ThisMonthWater - customer.LastMonthWater);
                    Console.WriteLine(" Total Water Bill: {0} ", customer.totalWaterBill());
                    Console.WriteLine("===================DONE!!!!!!!===================");
                }
            }
        }
    }
}
