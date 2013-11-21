using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalInformationManagementSystem.Class
{
    class Phone
    {
        private int _patientID;
        private string _type;
        private string _phoneNumber;

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

        public string phoneNumber
        {
            get { return _phoneNumber; }
            set { _phoneNumber = value; }
        }
    }
}
