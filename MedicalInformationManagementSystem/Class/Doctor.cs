using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalInformationManagementSystem.Class
{
    class Doctor
    {
        private string _billingCode;
        private string _name;

        public string billingCode
        {
            get { return _billingCode; }
            set { _billingCode = value; }
        }

        public string name
        {
            get { return _name; }
            set { _name = value; }
        }
    }
}
