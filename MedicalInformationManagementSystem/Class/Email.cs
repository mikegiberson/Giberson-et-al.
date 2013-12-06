using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalInformationManagementSystem
{
    public class Email
    {
        private int _patientID;
        private string _type;
        private string _email;

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

        public string email
        {
            get { return _email; }
            set { _email = value; }
        }
    }
}
