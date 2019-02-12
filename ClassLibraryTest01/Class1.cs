using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Security.Cryptography;

namespace ClassLibraryTest01
{
    [System.Runtime.InteropServices.ComVisible(true)]
    public class Class1
    {
        public static void Main()
        {
        }

        [System.Runtime.InteropServices.ComVisible(true)]
        public static String testFunction()
        {
            // creates the CspParameters object and sets the key container name used to store the RSA key pair
            CspParameters cp = new CspParameters();
            cp.KeyContainerName = "MyKeyContainerName";

            // instantiates the rsa instance accessing the key container MyKeyContainerName
            RSACryptoServiceProvider rsa = new RSACryptoServiceProvider(cp);
            // add the below line to delete the key entry in MyKeyContainerName
            // rsa.PersistKeyInCsp = false;

            //writes out the current key pair used in the rsa instance
            
return ("Key is : \n" + rsa.ToXmlString(true));
        }
    }
}
