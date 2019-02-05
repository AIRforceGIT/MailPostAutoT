// Selenium Chrome Autotest
/*
 * mail.ru
 * try to create a post account
 * find smth to check XD
 *
 *
*/
using System;
using System.Threading;
using System.Threading.Tasks;
using System.Runtime.ExceptionServices;
using System.IO;
using System.Collections.Generic;
using OpenQA.Selenium.Support;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Remote;
using System.Linq;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using NUnit.Framework;

namespace WebAutoTest
{
    class Program
    {
        
      
        private void setClickOnHref(ChromeDriver chr)
        {
            List<OpenQA.Selenium.IWebElement> lst = (from c in chr.FindElements(By.ClassName("b-select__list")).ToList() where c.Text.ToLower().Equals("сентябрь") select c).ToList();
            if (!lst.Any())
            {
                return;
            }
            lst[0].Click();

        }
        [Test]
        static void Main(string[] args)
        {
            IWebDriver chr = new ChromeDriver(@"C:\Users\root\source\repos\WebAutoTest");
            chr.Navigate().GoToUrl("https://mail.ru/");
            chr.Manage().Window.Maximize();
            Thread.Sleep(2000);
            
           
                chr.FindElement(By.Id("signup")).Click();
             Thread.Sleep(1001);
                chr.FindElement(By.Name("firstname")).SendKeys("Wannabe");      // Setting FirstName
                chr.FindElement(By.Name("lastname")).SendKeys("SiSharpAutoT"); // Setting LAstname
            Thread.Sleep(1456);
            

            
            chr.FindElement(By.ClassName("b-date__day")).Click();
            chr.FindElement(By.ClassName("day9")).Click();
            
          
            
            Thread.Sleep(1000);

            
            chr.FindElement(By.ClassName("b-radiogroup__radio-border")).Click(); //Setting Male Gender
            chr.FindElement(By.ClassName("btn__text")).Click();
            


        }
           
            
        }
    }

