using Exam.Page_Object_Model;
using Exam.Support;
using NUnit.Framework;
using System;
using System.Threading;

namespace Exam
{
    public class Tests:Base
    {

        [Test,Category("Flipkart")]
        public void Test1()
        {
            Flipkart flipkart = new Flipkart(driver);
            flipkart.Search_Ele();
            
            
            Wait();
           
        }

        [Test, Category("Amazon")]
        public void Test2()
        {
            Amazon tc1 = new Amazon(driver);
            tc1.Add_To_Cart();


        }
    }
}