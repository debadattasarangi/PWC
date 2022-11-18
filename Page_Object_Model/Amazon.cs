using Exam.Support;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam.Page_Object_Model
{
    public class Amazon
    {
        public IWebDriver driver;
       
        public Amazon(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//*[@id='twotabsearchtextbox']")]
        public IWebElement Search_bar;

        [FindsBy(How = How.XPath, Using = "//*[@id='n/1983550031']")]
        public IWebElement Mens_Running_Shoes;

        [FindsBy(How = How.XPath, Using = "//*[@id='a - autoid - 14 - announce' or @value='9']")]
        public IWebElement Shoes_size;

        [FindsBy(How = How.XPath, Using = "///*[@id=add-to-cart-button]")]
        public IWebElement Add_To_Cart_btn;

        public void Add_To_Cart()
        {

            Search_bar.SendKeys("Shoes");
            Search_bar.SendKeys(Keys.Enter);
          
            Mens_Running_Shoes.Click();
           
            Shoes_size.Click();
            var result = driver.FindElements(By.XPath("//*[@data-component-type='s-search-result']"));

            foreach (var s in result)
            {
                string s2=s.Text;
                
                
            }
            result[1].Click();
            //var child = driver.CurrentWindowHandle;
            var window_details=driver.WindowHandles;
            //foreach(var i in window_details)
            //{
            //    if (i != child)
            //    {
            //        driver.SwitchTo().Window(i);
            //        break;
            //    }
            //}
            driver.SwitchTo().Window(window_details[1]);
            Add_To_Cart_btn.Click();

    }


    }
}
