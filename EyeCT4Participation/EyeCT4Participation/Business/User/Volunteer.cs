using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EyeCT4Participation.Business;

namespace EyeCT4Participation.Business.User
{
    public class Volunteer : UI.User 
    {
        public int volunteerID { get; set; }
        public bool car { get; set; }
        public bool license { get; set; }
        public List<Appointment> appointmentList { get; set; }

        public Volunteer(string name, string address, string city, int phonenumber, int ID) :base(name, address, city, phonenumber)
        {

            this.volunteerID = ID;
            //this.car = car;
            //this.license = license;
            //this.appointmentList = appointmentList;
            //bool car, bool license, List< Appointment > appointmentList
        }

        public override string ToString()
        {
            return this.name;
        }

        public string getUserInfo()
        {
            string gegevens = "Naam: " + name + Environment.NewLine + "Adres: " + address + Environment.NewLine + "Woonplaats: " + city + Environment.NewLine + "Telefoonnummer: " + Convert.ToString(phonenumber);
            return gegevens;

        }
    }
}
