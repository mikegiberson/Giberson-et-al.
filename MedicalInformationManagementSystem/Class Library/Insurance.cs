using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthInformaticSystem
{
    class Insurance
    {
        
        private int _patientId;
       
        private string _insNumber;
        private string _expDate;
        private string _versionCode;
        private string _timestamp;
        
        

        public int patientID
        {
            get
            {
                return _patientId;
            }

            set
            {
                _patientId = value;
            }
        }

        public string versionCode
        {
            get { return _versionCode; }
            set { _versionCode = value; }
        }

       

        public string insNumber
        {
            get
            {
                return _insNumber;
            }

            set
            {
                _insNumber = value;
            }
        }

        public string expDate
        {
            get
            {
                return _expDate;
            }

            set
            {
                _expDate = value;
            }
        }

        public string timestamp
        {
            get
            {
                return _timestamp;
            }

            set
            {
                _timestamp = value;
            }
        }
    
    }



   
}
