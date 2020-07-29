using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPAFramework
{
    class Program
    {
        static void Main(string[] args)
        {
            //打开firefox浏览器：
            // IWebDriver driver = new FirefoxDriver();
            //打开IE浏览器
            //  IWebDriver driver = new InternetExplorerDriver();
            //打开chrome浏览器
            IWebDriver driver = new ChromeDriver();

            //最大化浏览器
            driver.Manage().Window.Maximize();
            // & 关闭浏览器
            //driver.Close();
            //driver.Quit();

            //打开测试页面          
            driver.Navigate().GoToUrl("http://www.baidu.com/");

            //By.id
            IWebElement element1 = driver.FindElement(By.Id("s-usersetting-top"));
            //By.name
            IWebElement element2 = driver.FindElement(By.Name("tj_settingicon"));
            //By.xpath
            IWebElement element3 = driver.FindElement(By.XPath("//span[@id='s-usersetting-top']"));
            //By.className
            // IWebElement element4 = driver.FindElement(By.ClassName("s-top-right-text c-font-normal c-color-t"));
            //By.cssSelector
            // IWebElement element5 = driver.FindElement(By.CssSelector(".s-p-top"));

            //By.linkText
            //通俗点就是精确查询
            // IWebElement element6 = driver.FindElement(By.LinkText("设置"));
            //By.partialLinkText：
            //这个方法就是模糊查询
            //  IWebElement element7 = driver.FindElement(By.PartialLinkText("设"));
            //By.tagName

            //  String element8 = driver.FindElement(By.TagName("form")).GetAttribute("name");

            //iFrame的处理 传入的是iframe的ID
           // driver.SwitchTo().Frame("city_set_ifr");


            IWebElement element = driver.FindElement(By.Id("kw"));
            element.SendKeys("RPA");//在输入框中输入内容：
                                    //element.Clear();       //将输入框清空

            IWebElement elementClick = driver.FindElement(By.Id("su"));
            elementClick.Click();

           // var a = element.Text;　　   //获取输入框的文本内容：


            //Console.WriteLine($"element1:{element1}");
            //Console.WriteLine($"element2:{element2}");
            //Console.WriteLine($"element3:{element3}");
            // Console.WriteLine($"element4:{element4}");
            //Console.WriteLine($"element5:{element5}");
            //Console.WriteLine($"element6:{element6}");
            //Console.WriteLine($"element7:{element7}");
            //Console.WriteLine($"element8:{element8}");


            Console.ReadLine();
        }
    }
}
