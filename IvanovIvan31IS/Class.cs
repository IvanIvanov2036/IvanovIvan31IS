using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IvanovIvan31IS
{
    public class Building
    {
        public string Address {get; set;}
        public string Description {get; set;}
        public List<Apartment> Apartments {get; set;}

        public Building(string address, string description)
        {
            Address = address;
            Description = description;
            Apartments = new List<Apartment>();
        }

        public void AddApartment(Apartment apartment)
        {
            Apartments.Add(apartment);
        }

        public void Show()
        {
            Console.WriteLine($"Address: {Address}");
            Console.WriteLine($"Description: {Description}");
        }

        public void ShowAll()
        {
            Apartments.Sort(); // сортируем квартиры по номеру
            foreach (Apartment apartment in Apartments)
            {
                apartment.Show();
            }
        }
    }

    public class Apartment : IComparable<Apartment>
    {
        public int Number { get; set; }
        public string Owner { get; set; }

        public Apartment(int number, string owner)
        {
            Number = number;
            Owner = owner;
        }

        public void Show()
        {
            Console.WriteLine($"Apartment number: {Number}, owner: {Owner}");
        }

        public int CompareTo(Apartment other)
        {
            return Number.CompareTo(other.Number);
        }
    }
}