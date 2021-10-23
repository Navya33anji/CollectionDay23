using System;
using System.Collections.Generic;
using System.Text;

namespace AdressBookSystem
{
    class Contact
    {
        public String fName;
        public String lName;
        public String address;
        public String city;
        public String state;
        public String zip;
        public String phoneNumber;
        public String email;

        public Contact(String fName, String lName, String address, String city, String state, String zip, String phoneNumber, String email)
        {
            this.fName = fName;
            this.lName = lName;
            this.address = address;
            this.city = city;
            this.state = state;
            this.zip = zip;
            this.phoneNumber = phoneNumber;
            this.email = email;

        }
        public string toString()
        {
            return "first Name=" + fName + ",last name=" + lName + ",address="
            + address + ",city=" + city + ",state=" + state + ",zip" +
            zip + ",phone number=" + phoneNumber + "email=" + email;
        }
    }
}
 13  Program.cs 
@@ -0,0 +1,13 @@
using System;

namespace AdressBookSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To adress Book System!");
            Program program = new Program();
        }
    }
}
