using System;
using GCP_Test;
using GCP_Test.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Web.Mvc;

namespace GCP_Unit_Test
{
    [TestClass]
    public class AccountTestController: Controller
    {
        [TestMethod]
        public void LoginTest()
        {
            GCP_Test.Models.LoginViewModel model = new GCP_Test.Models.LoginViewModel();
            
            string loginId = "khurshid007";
            string pass = "dsfdsfsd";
            model.Email = loginId;
            model.Password = pass;
            AccountController acc = new AccountController();
            int ans = acc.addNum(2,5);

            Assert.AreEqual(7, ans);

        }
    }
}
