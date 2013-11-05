using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthInformaticSystem
{
    class Patient
    {
         private int _patientID;
    private String _firstName;
    private String _lastName;
    private String _dob;
    private String _gender;
   
    public Patient()
    {
 
    }
 
    public int patientID
    {
        get
        {
            return _patientID;
        }
 
        set
        {
            _patientID = value;
        }
    }

    public String firstName
    {
        get
        {
            return _firstName;
        }

        set
        {
            _firstName = value;
        }
    }
 
    public String lastName
    {
        get
        {
            return _lastName;
        }
 
        set
        {
            _lastName = value;
        }
    }
 
    public String dob
    {
        get
        {
            return _dob;
        }
 
        set
        {
            _dob = value;
        }
    }

    public String gender
    {
        get
        {
            return _gender;
        }

        set
        {
            _gender = value;
        }
    }

   
    }
}
