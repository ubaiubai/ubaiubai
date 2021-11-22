﻿using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Threading;

namespace WebpageTesting
{
    public class Tests
    {
        WebDriver driver;
        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
        }

        [Test]
        public void TestBrowser()
        {
            driver.Url = "https://opensource-demo.orangehrmlive.com/";
            driver.Navigate();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            driver.FindElement(By.Id("txtUsername")).SendKeys("Admin");
            driver.FindElement(By.Id("txtPassword")).SendKeys("admin123");
            driver.FindElement(By.Id("btnLogin")).Click();
            Thread.Sleep(3000);
            driver.FindElement(By.XPath("//b[contains(text(),'Admin')]")).Click();
            Thread.Sleep(3000);
            driver.FindElement(By.Id("btnAdd")).Click();
            Thread.Sleep(3000);
            SelectElement role = new SelectElement(driver.FindElement(By.Id("systemUser_userType")));
            role.SelectByText("Admin");
            driver.FindElement(By.Id("systemUser_employeeName_empName")).SendKeys("Dominic Chase_4");
            driver.FindElement(By.Id("systemUser_userName")).SendKeys("Dominic.Chase");
            SelectElement status = new SelectElement(driver.FindElement(By.Id("systemUser_status")));
            status.SelectByText("Enabled");
            driver.FindElement(By.Id("systemUser_password")).SendKeys("Ubaid@123");
            driver.FindElement(By.Id("systemUser_confirmPassword")).SendKeys("Ubaid@123");
            Thread.Sleep(2000);
            driver.FindElement(By.Id("btnSave")).Click();
        }

    }
}