using System;
using static System.Console;

namespace DesignPatterns_4_Prototype.Example2
{
    //This is a C++ kind of copy
    public class PrototypeExampleCopyConstructors
    {
        static void Mains(string[] args)
        {
            var john = new Person(new[] { "John", "Smith" }, 
                                  new Address("London Road", 123));

            var jane = new Person(john);
            jane.Names[0] = "Jane";
            jane.Address.HouseNumber = 321;

            WriteLine(john);
            WriteLine(jane);
        }
    }

    public class Person
    {
        public string[] Names;
        public Address Address;

        public Person(string[] names, Address address)
        {
            if (names == null)
                throw new ArgumentNullException(paramName: nameof(names));
            if (address == null)
                throw new ArgumentNullException(paramName: nameof(address));

            Names = names;
            Address = address;
        }

        public Person(Person other)
        {
            // Here is the problem we have to implement the deep copy, 
            // otherwise it could somewhere be just a shallow copy
            Names = (string[])other.Names.Clone();
            Address = new Address(other.Address);
        }

        public override string ToString()
        {
            return $"{nameof(Names)}: {string.Join(" ", Names)}, {nameof(Address)}: {Address}";
        }
    }

    public class Address
    {
        public string StreetName;
        public int HouseNumber;

        public Address(string streetName, int houseNumber)
        {
            if (streetName == null)
                throw new ArgumentNullException(paramName: nameof(streetName));

            StreetName = streetName;
            HouseNumber = houseNumber;
        }

        public Address(Address other)
        {
            StreetName = other.StreetName;
            HouseNumber = other.HouseNumber;
        }

        public override string ToString()
        {
            return $"{nameof(StreetName)}: {StreetName}, {nameof(HouseNumber)}: {HouseNumber}";
        }
    }
}
