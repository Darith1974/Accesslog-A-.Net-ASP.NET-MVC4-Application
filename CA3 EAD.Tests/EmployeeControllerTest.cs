using CA3_EAD.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting.Web;
using CA3_EAD.Models;
using System.Web.Mvc;

namespace CA3_EAD.Tests
{
    
    
    /// <summary>
    ///This is a test class for EmployeeControllerTest and is intended
    ///to contain all EmployeeControllerTest Unit Tests
    ///</summary>
    [TestClass()]
    public class EmployeeControllerTest
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
        ///A test for EmployeeController Constructor
        ///</summary>
        // TODO: Ensure that the UrlToTest attribute specifies a URL to an ASP.NET page (for example,
        // http://.../Default.aspx). This is necessary for the unit test to be executed on the web server,
        // whether you are testing a page, web service, or a WCF service.
        [TestMethod()]
        //[HostType("ASP.NET")]
        //[AspNetDevelopmentServerHost("C:\\Users\\Admin\\Documents\\Visual Studio 2010\\Projects\\CA3 EAD\\CA3 EAD", "/")]
        //[UrlToTest("http://localhost:2124/Home")]

        //100% code coverage achieved.

        public void EmployeeControllerConstructorTest()
        {
            EmployeeController target = new EmployeeController();
            //Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for Create
        ///</summary>
        // TODO: Ensure that the UrlToTest attribute specifies a URL to an ASP.NET page (for example,
        // http://.../Default.aspx). This is necessary for the unit test to be executed on the web server,
        // whether you are testing a page, web service, or a WCF service.
        [TestMethod()]
        //[HostType("ASP.NET")]
       // [AspNetDevelopmentServerHost("C:\\Users\\Admin\\Documents\\Visual Studio 2010\\Projects\\CA3 EAD\\CA3 EAD", "/")]
       // [UrlToTest("http://localhost:2124/")]

        //100% code coverage.

        public void CreateTest()
        {
            EmployeeController target = new EmployeeController(); // TODO: Initialize to an appropriate value
            Employee employee = new Employee(); // TODO: Initialize to an appropriate value
            employee.Name = "test1";
            employee.Surname = "test1";
            employee.Town = "test1"; ;
            employee.County = "test1";
            employee.Country = "test1";
            employee.GradeID = 4;
            //ActionResult expected = target.Create(employee); // TODO: Initialize to an appropriate value
            ActionResult actual = null;
            //var expected = target.Create();
            actual = target.Create(employee);
            //Assert.AreEqual(expected, actual);
            //Assert.Inconclusive("Verify the correctness of this test method.");
        }

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

        //100% code coverage.

        public void CreateTest1()
        {
            EmployeeController target = new EmployeeController(); // TODO: Initialize to an appropriate value
            ActionResult expected = null; // TODO: Initialize to an appropriate value
            ActionResult actual;
            actual = target.Create();
            Assert.IsNotNull(actual);
            //Assert.AreEqual(expected, actual);
            //Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Delete
        ///</summary>
        // TODO: Ensure that the UrlToTest attribute specifies a URL to an ASP.NET page (for example,
        // http://.../Default.aspx). This is necessary for the unit test to be executed on the web server,
        // whether you are testing a page, web service, or a WCF service.
        [TestMethod()]
        //[HostType("ASP.NET")]
        //[AspNetDevelopmentServerHost("C:\\Users\\Admin\\Documents\\Visual Studio 2010\\Projects\\CA3 EAD\\CA3 EAD", "/")]
        //[UrlToTest("http://localhost:2124/")]

        //100% code coverage. Make sure the id is set to a entry that exists. Last ran at 20, so it is now
        // deleted. Look up database and pick a employee to run test again.

        public void DeleteTest()
        {
            EmployeeController target = new EmployeeController(); // TODO: Initialize to an appropriate value
            int id = 20; // TODO: Initialize to an appropriate value
            ActionResult expected = null; // TODO: Initialize to an appropriate value
            ActionResult actual;
            actual = target.Delete(id);
            Assert.IsNotNull(actual);
            //Assert.AreEqual(expected, actual);
            //Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for DeleteConfirmed
        ///</summary>
        // TODO: Ensure that the UrlToTest attribute specifies a URL to an ASP.NET page (for example,
        // http://.../Default.aspx). This is necessary for the unit test to be executed on the web server,
        // whether you are testing a page, web service, or a WCF service.
        [TestMethod()]
        //[HostType("ASP.NET")]
        //[AspNetDevelopmentServerHost("C:\\Users\\Admin\\Documents\\Visual Studio 2010\\Projects\\CA3 EAD\\CA3 EAD", "/")]
        //[UrlToTest("http://localhost:2124/")]

        //100% code coverage, remember only works on valid id

        public void DeleteConfirmedTest()
        {
            EmployeeController target = new EmployeeController(); // TODO: Initialize to an appropriate value
            int id =19; // TODO: Initialize to an appropriate value
            ActionResult expected = null; // TODO: Initialize to an appropriate value
            ActionResult actual;
            actual = target.DeleteConfirmed(id);
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

        // 100% code coverage. Test on null.

        public void DetailsTest()
        {
            EmployeeController target = new EmployeeController(); // TODO: Initialize to an appropriate value
            int id = 17; // TODO: Initialize to an appropriate value
            //ActionResult expected = target.Details(17); // TODO: Initialize to an appropriate value
            ActionResult actual;
            actual = target.Details(id);
            Assert.IsNotNull(actual);
            //Assert.Equals();
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
            EmployeeController_Accessor target = new EmployeeController_Accessor(); // TODO: Initialize to an appropriate value
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

        //1005 code coverage, again watch the ids that are used. 
        
        public void EditTest()
        {
            EmployeeController target = new EmployeeController(); // TODO: Initialize to an appropriate value
            int id = 18; // TODO: Initialize to an appropriate value
            ActionResult expected = target.Edit(20); ; // TODO: Initialize to an appropriate value
            ActionResult actual;
            actual = target.Edit(id);
            Assert.IsNotNull(actual);
            Assert.IsNotNull(expected);
            //Assert.AreEqual(expected, actual);
            //Assert.Inconclusive("Verify the correctness of this test method.");
        }
    }
}
