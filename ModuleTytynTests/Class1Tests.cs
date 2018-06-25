using NUnit.Framework;
using ModuleTytyn;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuleTytyn.Tests
{
    [TestFixture()]
    public class Class1Tests
    {
        
        [Test()]
        public void ModeleResTest1()
        {
            Class1 l = new Class1(12345, 12345, 54, true);
            string tmp = l.ModeleRes();
            Assert.AreEqual(tmp, "27");
        }

        [Test()]
        public void ModeleResTest2()
        {
            Class1 l = new Class1(-12345, 12345, 54, true);
            string tmp = l.ModeleRes();
            Assert.AreEqual(tmp, "-27");
        }


        [Test()]
        public void ModeleResTest3()
        {
            Class1 l = new Class1(4, 777777, 88, true);
            string tmp = l.ModeleRes();
            Assert.AreEqual(tmp, "16");
        }


        [Test()]
        public void ModeleResTest4()
        {
            Class1 l = new Class1(1,1, 1, true);
            string tmp = l.ModeleRes();
            Assert.AreEqual(tmp, "0");
        }
    }
}