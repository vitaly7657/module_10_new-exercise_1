using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace module_10_new_exercise_1
{
    class Clients
    {
        int id;
        string surname;
        string name;
        string patronymic;
        string phoneNumber;
        string passport;
        public Clients(int ID, string Surname, string Name, string Patronymic, string PhoneNumber, string Passport)
        {
            this.id = ID;
            this.surname = Surname;
            this.name = Name;
            this.patronymic = Patronymic;
            this.phoneNumber = PhoneNumber;
            this.passport = Passport;
        }

        public int ID
        {
            get { return id; }
        }
        public string Surname
        {
            get { return surname; }
            set { surname = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Patronymic
        {
            get { return patronymic; }
            set { patronymic = value; }
        }
        public string PhoneNumber
        {
            get { return phoneNumber; }
            set { phoneNumber = value; }
        }
        public string Passport
        {
            get { return passport; }
            set { passport = value; }
        }

        public string Print() //вывод на печать класса через метод
        {
            return String.Format("{0,3}{1,12}{2,12}{3,15}{4,15}{5,12}",
                this.ID,
                this.Surname,
                this.Name,
                this.Patronymic,
                this.PhoneNumber,
                this.Passport
                );
        }

        public Clients() : this(1, "client", "client", "client", "1", "1") //автозаполнение пустого нового класса
        {

        }
    }
}

