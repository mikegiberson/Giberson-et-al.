using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalInformationManagementSystem.Class
{
    class Address
    {
        private int _patientID;
        private string _type;
        private string _address;
        private string _city;
        private string _province;
        private string _postalCode;

        public int patientID
        {
            get { return _patientID; }
            set { _patientID = value; }
        }

        public string type
        {
            get { return _type; }
            set { _type = value; }
        }

        public string address
        {
            get { return _address; }
            set { _address = value; }
        }

        public string city
        {
            get { return _city; }
            set { _city = value; }
        }
        public string province
        {
            get { return _province; }
            set { _province = value; }
        }
        public string postalCode
        {
            get { return _postalCode; }
            set { _postalCode = value; }
        }
    }
}
