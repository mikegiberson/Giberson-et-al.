using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalInformationManagementSystem
{
    public class ReferralDoctor
    {
        private int _patientID;
        private int _doctorID;

        public int patientID
        {
            get { return _patientID; }
            set { _patientID = value; }
        }

        public int doctorID
        {
            get { return _doctorID; }
            set { _doctorID = value; }
        }
    }
}
