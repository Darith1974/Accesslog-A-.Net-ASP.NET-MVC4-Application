using CA3_EAD.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting.Web;
using System.Data.Objects.DataClasses;

namespace TestProject1
{
    
    
    /// <summary>
    ///This is a test class for EmployeeTest and is intended
    ///to contain all EmployeeTest Unit Tests
    ///</summary>
    [TestClass()]
    public class EmployeeTest
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
        ///A test for Employee Constructor
        ///</summary>
        // TODO: Ensure that the UrlToTest attribute specifies a URL to an ASP.NET page (for example,
        // http://.../Default.aspx). This is necessary for the unit test to be executed on the web server,
        // whether you are testing a page, web service, or a WCF service.
        [TestMethod()]
        [HostType("ASP.NET")]
        [AspNetDevelopmentServerHost("C:\\Users\\Admin\\Documents\\Visual Studio 2010\\Projects\\CA3 EAD\\CA3 EAD", "/")]
        [UrlToTest("http://localhost:2124/")]
        public void EmployeeConstructorTest()
        {
            Employee target = new Employee();
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for CreateEmployee
        ///</summary>
        // TODO: Ensure that the UrlToTest attribute specifies a URL to an ASP.NET page (for example,
        // http://.../Default.aspx). This is necessary for the unit test to be executed on the web server,
        // whether you are testing a page, web service, or a WCF service.
        [TestMethod()]
        [HostType("ASP.NET")]
        [AspNetDevelopmentServerHost("C:\\Users\\Admin\\Documents\\Visual Studio 2010\\Projects\\CA3 EAD\\CA3 EAD", "/")]
        [UrlToTest("http://localhost:2124/")]
        public void CreateEmployeeTest()
        {
            int employeeId = 0; // TODO: Initialize to an appropriate value
            string name = string.Empty; // TODO: Initialize to an appropriate value
            string surname = string.Empty; // TODO: Initialize to an appropriate value
            string town = string.Empty; // TODO: Initialize to an appropriate value
            string county = string.Empty; // TODO: Initialize to an appropriate value
            string country = string.Empty; // TODO: Initialize to an appropriate value
            int gradeID = 0; // TODO: Initialize to an appropriate value
            Employee expected = null; // TODO: Initialize to an appropriate value
            Employee actual;
            actual = Employee.CreateEmployee(employeeId, name, surname, town, county, country, gradeID);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for CompanyPosition
        ///</summary>
        // TODO: Ensure that the UrlToTest attribute specifies a URL to an ASP.NET page (for example,
        // http://.../Default.aspx). This is necessary for the unit test to be executed on the web server,
        // whether you are testing a page, web service, or a WCF service.
        [TestMethod()]
        [HostType("ASP.NET")]
        [AspNetDevelopmentServerHost("C:\\Users\\Admin\\Documents\\Visual Studio 2010\\Projects\\CA3 EAD\\CA3 EAD", "/")]
        [UrlToTest("http://localhost:2124/")]
        public void CompanyPositionTest()
        {
            Employee target = new Employee(); // TODO: Initialize to an appropriate value
            CompanyPosition expected = null; // TODO: Initialize to an appropriate value
            CompanyPosition actual;
            target.CompanyPosition = expected;
            actual = target.CompanyPosition;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for CompanyPositionReference
        ///</summary>
        // TODO: Ensure that the UrlToTest attribute specifies a URL to an ASP.NET page (for example,
        // http://.../Default.aspx). This is necessary for the unit test to be executed on the web server,
        // whether you are testing a page, web service, or a WCF service.
        [TestMethod()]
        [HostType("ASP.NET")]
        [AspNetDevelopmentServerHost("C:\\Users\\Admin\\Documents\\Visual Studio 2010\\Projects\\CA3 EAD\\CA3 EAD", "/")]
        [UrlToTest("http://localhost:2124/")]
        public void CompanyPositionReferenceTest()
        {
            Employee target = new Employee(); // TODO: Initialize to an appropriate value
            EntityReference<CompanyPosition> expected = null; // TODO: Initialize to an appropriate value
            EntityReference<CompanyPosition> actual;
            target.CompanyPositionReference = expected;
            actual = target.CompanyPositionReference;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Country
        ///</summary>
        // TODO: Ensure that the UrlToTest attribute specifies a URL to an ASP.NET page (for example,
        // http://.../Default.aspx). This is necessary for the unit test to be executed on the web server,
        // whether you are testing a page, web service, or a WCF service.
        [TestMethod()]
        [HostType("ASP.NET")]
        [AspNetDevelopmentServerHost("C:\\Users\\Admin\\Documents\\Visual Studio 2010\\Projects\\CA3 EAD\\CA3 EAD", "/")]
        [UrlToTest("http://localhost:2124/")]
        public void CountryTest()
        {
            Employee target = new Employee(); // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            target.Country = expected;
            actual = target.Country;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for County
        ///</summary>
        // TODO: Ensure that the UrlToTest attribute specifies a URL to an ASP.NET page (for example,
        // http://.../Default.aspx). This is necessary for the unit test to be executed on the web server,
        // whether you are testing a page, web service, or a WCF service.
        [TestMethod()]
        [HostType("ASP.NET")]
        [AspNetDevelopmentServerHost("C:\\Users\\Admin\\Documents\\Visual Studio 2010\\Projects\\CA3 EAD\\CA3 EAD", "/")]
        [UrlToTest("http://localhost:2124/")]
        public void CountyTest()
        {
            Employee target = new Employee(); // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            target.County = expected;
            actual = target.County;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for EmployeeId
        ///</summary>
        // TODO: Ensure that the UrlToTest attribute specifies a URL to an ASP.NET page (for example,
        // http://.../Default.aspx). This is necessary for the unit test to be executed on the web server,
        // whether you are testing a page, web service, or a WCF service.
        [TestMethod()]
        [HostType("ASP.NET")]
        [AspNetDevelopmentServerHost("C:\\Users\\Admin\\Documents\\Visual Studio 2010\\Projects\\CA3 EAD\\CA3 EAD", "/")]
        [UrlToTest("http://localhost:2124/")]
        public void EmployeeIdTest()
        {
            Employee target = new Employee(); // TODO: Initialize to an appropriate value
            int expected = 0; // TODO: Initialize to an appropriate value
            int actual;
            target.EmployeeId = expected;
            actual = target.EmployeeId;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for GradeID
        ///</summary>
        // TODO: Ensure that the UrlToTest attribute specifies a URL to an ASP.NET page (for example,
        // http://.../Default.aspx). This is necessary for the unit test to be executed on the web server,
        // whether you are testing a page, web service, or a WCF service.
        [TestMethod()]
        [HostType("ASP.NET")]
        [AspNetDevelopmentServerHost("C:\\Users\\Admin\\Documents\\Visual Studio 2010\\Projects\\CA3 EAD\\CA3 EAD", "/")]
        [UrlToTest("http://localhost:2124/")]
        public void GradeIDTest()
        {
            Employee target = new Employee(); // TODO: Initialize to an appropriate value
            int expected = 0; // TODO: Initialize to an appropriate value
            int actual;
            target.GradeID = expected;
            actual = target.GradeID;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Logs
        ///</summary>
        // TODO: Ensure that the UrlToTest attribute specifies a URL to an ASP.NET page (for example,
        // http://.../Default.aspx). This is necessary for the unit test to be executed on the web server,
        // whether you are testing a page, web service, or a WCF service.
        [TestMethod()]
        [HostType("ASP.NET")]
        [AspNetDevelopmentServerHost("C:\\Users\\Admin\\Documents\\Visual Studio 2010\\Projects\\CA3 EAD\\CA3 EAD", "/")]
        [UrlToTest("http://localhost:2124/")]
        public void LogsTest()
        {
            Employee target = new Employee(); // TODO: Initialize to an appropriate value
            EntityCollection<Log> expected = null; // TODO: Initialize to an appropriate value
            EntityCollection<Log> actual;
            target.Logs = expected;
            actual = target.Logs;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Name
        ///</summary>
        // TODO: Ensure that the UrlToTest attribute specifies a URL to an ASP.NET page (for example,
        // http://.../Default.aspx). This is necessary for the unit test to be executed on the web server,
        // whether you are testing a page, web service, or a WCF service.
        [TestMethod()]
        [HostType("ASP.NET")]
        [AspNetDevelopmentServerHost("C:\\Users\\Admin\\Documents\\Visual Studio 2010\\Projects\\CA3 EAD\\CA3 EAD", "/")]
        [UrlToTest("http://localhost:2124/")]
        public void NameTest()
        {
            Employee target = new Employee(); // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            target.Name = expected;
            actual = target.Name;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Surname
        ///</summary>
        // TODO: Ensure that the UrlToTest attribute specifies a URL to an ASP.NET page (for example,
        // http://.../Default.aspx). This is necessary for the unit test to be executed on the web server,
        // whether you are testing a page, web service, or a WCF service.
        [TestMethod()]
        [HostType("ASP.NET")]
        [AspNetDevelopmentServerHost("C:\\Users\\Admin\\Documents\\Visual Studio 2010\\Projects\\CA3 EAD\\CA3 EAD", "/")]
        [UrlToTest("http://localhost:2124/")]
        public void SurnameTest()
        {
            Employee target = new Employee(); // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            target.Surname = expected;
            actual = target.Surname;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Town
        ///</summary>
        // TODO: Ensure that the UrlToTest attribute specifies a URL to an ASP.NET page (for example,
        // http://.../Default.aspx). This is necessary for the unit test to be executed on the web server,
        // whether you are testing a page, web service, or a WCF service.
        [TestMethod()]
        [HostType("ASP.NET")]
        [AspNetDevelopmentServerHost("C:\\Users\\Admin\\Documents\\Visual Studio 2010\\Projects\\CA3 EAD\\CA3 EAD", "/")]
        [UrlToTest("http://localhost:2124/")]
        public void TownTest()
        {
            Employee target = new Employee(); // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            target.Town = expected;
            actual = target.Town;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }
    }
}
