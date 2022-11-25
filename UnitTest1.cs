using Exam.Page_Object_Model;
using Exam.Support;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;

namespace Exam
{
    public class Tests : Base
    {

        [Test, Category("Flipkart")]
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

        [Test, Category("MakeMyTrip")]

        public void Test()
        {
            Wait();
            driver.FindElement(By.XPath("//*[@id='root']/div/div[2]/div/div/div[2]/p/a")).Click();

            //ResultStateException =//div[@class="listingRhs"]/div[2]/div[3]/div/div/div/div[]
            //div[@class="listingRhs"]/div[2]/div[3]/div/div/div/div[i]/div[1]/div[2]/div[4]


            //var result = driver.FindElements(By.XPath("//div[@class='listingRhs']/div[2]/div[3]/div/div/div/div"));
            //foreach(var i in result)
            //{
            //    var s = i.Text;
            //    Console.WriteLine(s);
            //}


            Wait();
            Wait();
            Wait();
            IList<string> price = new List<string>();
            var res_len = driver.FindElements(By.XPath("//div[@class='listingRhs']/div[2]/div[3]/div/div/div/div")).Count;
            for (int i = 1; i < res_len; i++)
            {
                if (driver.FindElement(By.XPath("//div[@class='listingRhs']/div[2]/div[3]/div/div/div/div[" + i + "]/div[1]/div[2]/div[4]/div/div")).Displayed)
                {
                    string a = driver.FindElement(By.XPath("//div[@class='listingRhs']/div[2]/div[3]/div/div/div/div[" + i + "]/div[1]/div[2]/div[4]/div/div")).Text;
                    price.Add(a);

                }
            }

            Wait();


        }



        [Test, Category("MakeMyTrip")]

        public void Test_Make()
        {
            Wait();
            driver.FindElement(By.XPath("//*[@id='root']/div/div[2]/div/div/div[2]/p/a")).Click();
            
            
            //ResultStateException =//div[@class="listingRhs"]/div[2]/div[3]/div/div/div/div[]
            //div[@class="listingRhs"]/div[2]/div[3]/div/div/div/div[i]/div[1]/div[2]/div[4]


            //var result = driver.FindElements(By.XPath("//div[@class='listingRhs']/div[2]/div[3]/div/div/div/div"));
            //foreach(var i in result)
            //{
            //    var s = i.Text;
            //    Console.WriteLine(s);
            //}


            Wait();
            Wait();
            Wait();
            IList<int> price = new List<int>();
            IList<string> str_price = new List<string>();
            var res_len = driver.FindElements(By.XPath("//div[@class='textRight flexOne']//p"));
            //int c = 0;
            //Adding ele to list
            foreach (var i in res_len)
            {
                string s = i.Text;
                str_price.Add(s);
                string b = String.Empty;
                for (int j = 0; j < s.Length; j++)
                {
                    if (Char.IsDigit(s[j]))
                    {
                        b = b + s[j];
                    }
                }

                price.Add(int.Parse(b));

            }
            price.Add(123);
            int len = price.Count;
            string sort_or = "Asc";
            // Sort check ascending and descending
            switch (sort_or)
            {
                case "Asc":
                    for (int i = 1; i < len; i++)
                    {
                        if (price[i] < price[i - 1])
                        {
                            throw new Exception();
                        }
                    }
                    break;

                default:
                    for (int i = 1; i < len; i++)
                    {
                        if (price[i] > price[i - 1])
                        {
                            throw new Exception();
                        }
                    }
                    break;
            }


        }


    }
}


