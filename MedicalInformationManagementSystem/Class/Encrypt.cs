using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalInformationManagementSystem
{
    public class Encrypt
    {
        public String MD5(String password)
        {
            System.Security.Cryptography.MD5CryptoServiceProvider x = new System.Security.Cryptography.MD5CryptoServiceProvider();
            byte[] data = System.Text.Encoding.ASCII.GetBytes(password);
            data = x.ComputeHash(data);
            return System.Text.Encoding.ASCII.GetString(data);
        }
    }
}
