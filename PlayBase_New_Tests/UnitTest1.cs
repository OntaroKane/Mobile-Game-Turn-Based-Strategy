using System;
using System.Security.Cryptography;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PlayBase_New_Tests
{
    [TestClass]
    public class PlayBase_New_Tests
    {
        

        [TestMethod]
        public void getHashSha256()
        {
            byte[] bytes = Encoding.UTF8.GetBytes("canine9");
            SHA256Managed hashstring = new SHA256Managed();
            byte[] hash = hashstring.ComputeHash(bytes);
            string hashString = string.Empty;
            foreach (byte x in hash)
            {
                hashString += String.Format("{0:x2}", x);
            }
            Console.Write(hashstring.ToString());
        }
    }
}

