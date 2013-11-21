using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalInformationManagementSystem.Class
{
    class PatientAllergy
    {
        private int _allergyId;
        private int _patientId;

        public int patientId
        {
            get { return _patientId; }
            set { _patientId = value; }
        }

        public int allergyId
        {
            get { return _allergyId; }
            set { _allergyId = value; }
        }
    }
}
