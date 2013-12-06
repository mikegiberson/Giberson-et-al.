using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalInformationManagementSystem
{
    public class Allergy
    {
        private int _allergyId;
        private string _name;
        private string _category;

        public int allergyId
        {
            get { return _allergyId; }
            set { _allergyId = value; }
        }

        public string name
        {
            get { return _name; }
            set { _name = value; }
        }

        public string category
        {
            get { return _category; }
            set { _category = value; }
        }
    }
}
