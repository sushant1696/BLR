
using System;
using System.Collections.Generic;
using System.Text;

namespace OPPS.AddresBook
{
    class Person
    {

        private string firstName;
        private string lastName;
        private string phoneNumber;
        private string addresses;



        public string FirstName { get => this.firstName; set => this.firstName = value; }
        public string LastName { get => this.lastName; set => this.lastName = value; }
        public string PhoneNumber { get => this.phoneNumber; set => this.phoneNumber = value; }
        public string Addresses { get => this.addresses; set => this.addresses = value; }


        public static void Print()
        {
            PersonList array = Utility.ReadJsonFile();
            foreach (var item in array.Person)
            {
                Console.WriteLine("Firstname =" + item.FirstName);
                Console.WriteLine("LastName =" + item.LastName);
                Console.WriteLine(" phoneNumber =" + item.PhoneNumber);
                Console.WriteLine(" Addresses =" + item.Addresses);
                Console.WriteLine();
            }
        }
        public static void AddDetails(string Firstname, string LastName, string PhoneNumber, string Addresses)
        {
            PersonList array = Utility.ReadJsonFile();
            Person obj = new Person();
            obj.firstName = Firstname;
            obj.lastName = LastName;
            obj.phoneNumber = PhoneNumber;
            obj.addresses = Addresses;
            array.Person.Add(obj);
            Utility.WriteJsonFile(array);
        }
        public static void Currection()
        {
            int j = 1;
            PersonList array = Utility.ReadJsonFile();
            foreach (var i in array.Person)
            {
                Console.WriteLine(j++ + "=" + i.FirstName);
                Console.WriteLine(j++ + "=" + i.LastName);
                Console.WriteLine(j++ + "=" + i.phoneNumber);
                Console.WriteLine(j++ + "=" + i.addresses);
            }
            Console.WriteLine("Enter the item no");
            int itemNumber = Convert.ToInt32(Console.ReadLine());

            string name1 = array.Person[itemNumber - 1].FirstName;

            foreach (var item in array.Person)
            {
                if (item.FirstName != name1)
                {
                    continue;
                }
                else
                {
                    Console.WriteLine("FirstName = " + item.FirstName + "\nLastName = " + item.LastName + "\nphoneNumber =" + item.PhoneNumber + "Addresses\n=" + item.Addresses);
                }

                Console.WriteLine("enter 1 to edit first name");
                Console.WriteLine("enter 2 to edit last");
                Console.WriteLine("enter 3 to edit phone no");
                Console.WriteLine("enter 4 to edit addres");

                Console.WriteLine("enter a proper choice");

                int choice = Convert.ToInt32(Console.ReadLine());
               

                    switch (choice)
                    {

                        case 1:
                            Console.WriteLine("enter any new first name");
                            string newName = Console.ReadLine();
                            array.Person[itemNumber - 1].FirstName = newName;
                            break;
                        case 2:
                            Console.WriteLine("enter the new lastname");
                            string last = Console.ReadLine();
                            array.Person[itemNumber - 1].lastName = last;
                            break;

                        case 3:
                            Console.WriteLine("enter the new phon no");
                            string newphon = Console.ReadLine();
                            array.Person[itemNumber - 1].PhoneNumber = newphon;
                            break;
                        case 4:
                            Console.WriteLine("enter the new address");
                            string newadd = Console.ReadLine();
                            array.Person[itemNumber - 1].Addresses = newadd;
                            break;

                    }
                
                Utility.WriteJsonFile(array);
            }


        }
        public static void Deleteitem()
        {
            int j = 1;
            PersonList array = Utility.ReadJsonFile();
            foreach (var i in array.Person)
            {
                Console.WriteLine(j++ + "=" + i.FirstName);
                Console.WriteLine(j++ + "=" + i.LastName);
                Console.WriteLine(j++ + "=" + i.phoneNumber);
                Console.WriteLine(j++ + "=" + i.addresses);
            }

            Console.WriteLine("Enter the item to delete");
            int itemNumber = Convert.ToInt32(Console.ReadLine());
            array.Person.RemoveAt(itemNumber - 1);
            Utility.WriteJsonFile(array);
        }
    }     
        
    }

