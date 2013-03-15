using CA3_EAD.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting.Web;
using CA3_EAD.Models;
using System.Web.Mvc;

namespace CA3_EAD.Tests
{
    
    
    /// <summary>
    ///This is a test class for LogControllerTest and is intended
    ///to contain all LogControllerTest Unit Tests
    ///</summary>
    [TestClass()]
    public class LogControllerTest
    {


        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        // 
        //You can use the following additional attributes as you write your tests:
        //
        //Use ClassInitialize to run code before running the first test in the class
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
        //
        //Use ClassCleanup to run code after all tests in a class have run
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //Use TestInitialize to run code before running each test
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //Use TestCleanup to run code after each test has run
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion


        /// <summary>
        ///A test for Create
        ///</summary>
        // TODO: Ensure that the UrlToTest attribute specifies a URL to an ASP.NET page (for example,
        // http://.../Default.aspx). This is necessary for the unit test to be executed on the web server,
        // whether you are testing a page, web service, or a WCF service.
        [TestMethod()]
        //[HostType("ASP.NET")]
        //[AspNetDevelopmentServerHost("C:\\Users\\Admin\\Documents\\Visual Studio 2010\\Projects\\CA3 EAD\\CA3 EAD", "/")]
        //[UrlToTest("http://localhost:2124/")]

        // 100% code coverage.

        public void CreateTest()
        {
            LogController target = new LogController(); // TODO: Initialize to an appropriate value
            Log log = new Log();
            log.EmployeeId = 16;// TODO: Initialize to an appropriate value
            log.EnterDateTime = new DateTime(2012,5,6);
            log.LeaveDateTime = new DateTime(2012, 5, 7);
            /*
            log.EnterDateTime.AddYears(2012);
            log.EnterDateTime.AddMonths(5);
            log.EnterDateTime.AddDays(6);
            log.EnterDateTime.AddHours(06);
            log.EnterDateTime.AddMinutes(06);
            log.EnterDateTime.AddSeconds(10);
            log.LeaveDateTime.AddYears(2012);
            log.LeaveDateTime.AddMonths(5);
            log.LeaveDateTime.AddDays(6);
            log.LeaveDateTime.AddHours(06);
            log.LeaveDateTime.AddMinutes(06);
            log.LeaveDateTime.AddSeconds(12);
            */
            ActionResult expected = null; // TODO: Initialize to an appropriate value
            ActionResult actual;
            actual = target.Create(log);
            Assert.IsNotNull(actual);
            //Assert.AreEqual(expected, actual);
            //Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Create
        ///</summary>
        // TODO: Ensure that the UrlToTest attribute specifies a URL to an ASP.NET page (for example,
        // http://.../Default.aspx). This is necessary for the unit test to be executed on the web server,
        // whether you are testing a page, web service, or a WCF service.
        [HostType("ASP.NET")]
        [AspNetDevelopmentServerHost("C:\\Users\\Admin\\Documents\\Visual Studio 2010\\Projects\\CA3 EAD\\CA3 EAD", "/")]
        [UrlToTest("http://localhost:2124/")]
        public void CreateTest1()
        {
            LogController target = new LogController(); // TODO: Initialize to an appropriate value
            ActionResult expected = null; // TODO: Initialize to an appropriate value
            ActionResult actual;
            actual = target.Create();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for DeleteConfirmed
        ///</summary>
        // TODO: Ensure that the UrlToTest attribute specifies a URL to an ASP.NET page (for example,
        // http://.../Default.aspx). This is necessary for the unit test to be executed on the web server,
        // whether you are testing a page, web service, or a WCF service.
        [HostType("ASP.NET")]
        [AspNetDevelopmentServerHost("C:\\Users\\Admin\\Documents\\Visual Studio 2010\\Projects\\CA3 EAD\\CA3 EAD", "/")]
        [UrlToTest("http://localhost:2124/")]
        public void DeleteConfirmedTest()
        {
            LogController target = new LogController(); // TODO: Initialize to an appropriate value
            int id = 0; // TODO: Initialize to an appropriate value
            ActionResult expected = null; // TODO: Initialize to an appropriate value
            ActionResult actual;
            actual = target.DeleteConfirmed(id);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Delete
        ///</summary>
        // TODO: Ensure that the UrlToTest attribute specifies a URL to an ASP.NET page (for example,
        // http://.../Default.aspx). This is necessary for the unit test to be executed on the web server,
        // whether you are testing a page, web service, or a WCF service.
        [TestMethod()]
        //[HostType("ASP.NET")]
       // [AspNetDevelopmentServerHost("C:\\Users\\Admin\\Documents\\Visual Studio 2010\\Projects\\CA3 EAD\\CA3 EAD", "/")]
        //[UrlToTest("http://localhost:2124/")]

        //100% code coverage. Again watch the id to use.

        public void DeleteTest()
        {
            LogController target = new LogController(); // TODO: Initialize to an appropriate value
            int id = 16; // TODO: Initialize to an appropriate value
            ActionResult expected = null; // TODO: Initialize to an appropriate value
            ActionResult actual;
            actual = target.Delete(id);
            Assert.IsNotNull(actual);
            //Assert.AreEqual(expected, actual);
            //Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Details
        ///</summary>
        // TODO: Ensure that the UrlToTest attribute specifies a URL to an ASP.NET page (for example,
        // http://.../Default.aspx). This is necessary for the unit test to be executed on the web server,
        // whether you are testing a page, web service, or a WCF service.
        [TestMethod()]
        //[HostType("ASP.NET")]
        //[AspNetDevelopmentServerHost("C:\\Users\\Admin\\Documents\\Visual Studio 2010\\Projects\\CA3 EAD\\CA3 EAD", "/")]
        //[UrlToTest("http://localhost:2124/")]

        // 100% code coverage.

        public void DetailsTest()
        {
            LogController target = new LogController(); // TODO: Initialize to an appropriate value
            int id = 14; // TODO: Initialize to an appropriate value
            ActionResult expected = null; // TODO: Initialize to an appropriate value
            ActionResult actual;
            actual = target.Details(id);
            Assert.IsNotNull(actual);
            //Assert.AreEqual(expected, actual);
            //Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Dispose
        ///</summary>
        // TODO: Ensure that the UrlToTest attribute specifies a URL to an ASP.NET page (for example,
        // http://.../Default.aspx). This is necessary for the unit test to be executed on the web server,
        // whether you are testing a page, web service, or a WCF service.
        [HostType("ASP.NET")]
        [AspNetDevelopmentServerHost("C:\\Users\\Admin\\Documents\\Visual Studio 2010\\Projects\\CA3 EAD\\CA3 EAD", "/")]
        [UrlToTest("http://localhost:2124/")]
        [DeploymentItem("CA3 EAD.dll")]
        public void DisposeTest()
        {
            LogController_Accessor target = new LogController_Accessor(); // TODO: Initialize to an appropriate value
            bool disposing = false; // TODO: Initialize to an appropriate value
            target.Dispose(disposing);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for Edit
        ///</summary>
        // TODO: Ensure that the UrlToTest attribute specifies a URL to an ASP.NET page (for example,
        // http://.../Default.aspx). This is necessary for the unit test to be executed on the web server,
        // whether you are testing a page, web service, or a WCF service.
        [TestMethod()]
        //[HostType("ASP.NET")]
        //[AspNetDevelopmentServerHost("C:\\Users\\Admin\\Documents\\Visual Studio 2010\\Projects\\CA3 EAD\\CA3 EAD", "/")]
        //[UrlToTest("http://localhost:2124/")]

        //100% code coverage.

        public void EditTest()
        {
            LogController target = new LogController(); // TODO: Initialize to an appropriate value
            int id = 14; // TODO: Initialize to an appropriate value
            ActionResult expected = null; // TODO: Initialize to an appropriate value
            ActionResult actual;
            actual = target.Edit(id);
            Assert.IsNotNull(actual);
            //Assert.AreEqual(expected, actual);
            //Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Edit
        ///</summary>
        // TODO: Ensure that the UrlToTest attribute specifies a URL to an ASP.NET page (for example,
        // http://.../Default.aspx). This is necessary for the unit test to be executed on the web server,
        // whether you are testing a page, web service, or a WCF service.
        [HostType("ASP.NET")]
        [AspNetDevelopmentServerHost("C:\\Users\\Admin\\Documents\\Visual Studio 2010\\Projects\\CA3 EAD\\CA3 EAD", "/")]
        [UrlToTest("http://localhost:2124/")]
        public void EditTest1()
        {
            LogController target = new LogController(); // TODO: Initialize to an appropriate value
            Log log = null; // TODO: Initialize to an appropriate value
            ActionResult expected = null; // TODO: Initialize to an appropriate value
            ActionResult actual;
            actual = target.Edit(log);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Index
        ///</summary>
        // TODO: Ensure that the UrlToTest attribute specifies a URL to an ASP.NET page (for example,
        // http://.../Default.aspx). This is necessary for the unit test to be executed on the web server,
        // whether you are testing a page, web service, or a WCF service.
        [HostType("ASP.NET")]
        [AspNetDevelopmentServerHost("C:\\Users\\Admin\\Documents\\Visual Studio 2010\\Projects\\CA3 EAD\\CA3 EAD", "/")]
        [UrlToTest("http://localhost:2124/")]
        public void IndexTest()
        {
            LogController target = new LogController(); // TODO: Initialize to an appropriate value
            ActionResult expected = null; // TODO: Initialize to an appropriate value
            ActionResult actual;
            actual = target.Index();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }
    }
}
