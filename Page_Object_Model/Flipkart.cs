using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Exam.Page_Object_Model
{
    public class Flipkart
    {
        IWebDriver driver;
        public Flipkart(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//input[contains(@title,'Search for products')]")]
        public IWebElement Search;

        [FindsBy(How = How.XPath, Using = "//*[@id='container']/div/div[1]/div[1]/div[2]/div[2]/form/div/button")]
        public IWebElement Search_btn;

        [FindsBy(How = How.ClassName, Using = "//*[@Class='_4rR01T']")]
        public IList<IWebElement> Select;

        [FindsBy(How = How.XPath, Using = "")]
        public IWebElement AddToCart_btn;

        [FindsBy(How = How.XPath, Using = "")]
        public IWebElement Cart_btn;

        public void Search_Ele()
        {
            Search.SendKeys("Mobile");
            Search_btn.Click();
            foreach( var i in Select) { 
                i.Click();
            }

            


        }
    }
}
