using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework__7
{
    internal class User
    {
        uint userID;
        string surname;
        string name;
        string fatherName;
        string phoneNumber;
        string customerAdress;

        public uint UserID
        {
            get => userID;
        }
        public string Surname
        {
            get => surname;
            protected set
            {
                if (!string.IsNullOrEmpty(value))
                    surname = value;
            }
        }
        public string Name
        {
            get => name;
            protected set
            {
                if (!string.IsNullOrEmpty(value))
                    name = value;
            }
        }
        public string FatherName
        {
            get => fatherName;
            protected set
            {
                if (!string.IsNullOrEmpty(value))
                    fatherName = value;
            }
        }
        public string PhoneNumber
        {
            get => phoneNumber;
            protected set
            {
                if (!string.IsNullOrEmpty(value))
                    phoneNumber = value;
            }
        }
        public string CustomerAdress
        {
            get => customerAdress;
            protected set
            {
                if (!string.IsNullOrEmpty(value))
                    customerAdress = value;
            }
        }
        public override string ToString()
        {
            return $"This user id = {UserID}\n" +
                $"Surname - {Surname}\n" +
                $"Name - {Name}\n" +
                $"FatherName - {FatherName}\n" +
                $"PhoneNumber - {PhoneNumber}\n" +
                $"CustomerAdress - {CustomerAdress}";
        }
        public User(uint UserId, string Surname, string Name, string FatherName, string PhoneNumber, string CustomerAdress)
        {
            userID = UserId;
            this.Surname = Surname;
            this.Name = Name;
            this.FatherName = FatherName;
            this.PhoneNumber = PhoneNumber;
            this.CustomerAdress = CustomerAdress;
        }
    }
}
