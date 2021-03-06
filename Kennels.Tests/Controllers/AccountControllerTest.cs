﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Kennels.Controllers;
using System.Web.Mvc;

namespace Kennels.Tests.Controllers
{
    [TestClass]
    public class AccountControllerTest
    {
        [TestMethod]
        public void TestLogInReturnURL()
        {
            var controller = new AccountController();
            var result = controller.Login("google.com") as ViewResult;
            Assert.AreEqual("google.com", result.ViewBag.ReturnUrl);
        }        

        [TestMethod]
        public void TestRegisterGet()
        {
            var controller = new AccountController();
            var result = controller.Register() as ViewResult;
            Assert.IsNotNull(result);
        }
        [TestMethod]
        public void TestForgotPasswordGet()
        {
            var controller = new AccountController();
            var result = controller.ForgotPassword() as ViewResult;
            Assert.IsNotNull(result);            
        }

    }
}
