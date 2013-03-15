using CA3_EAD.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting.Web;
using System.Data.Objects.DataClasses;

namespace TestProject1
{
    
    
    /// <summary>
    ///This is a test class for CompanyPositionTest and is intended
    ///to contain all CompanyPositionTest Unit Tests
    ///</summary>
    [TestClass()]
    public class CompanyPositionTest
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
        ///A test for CompanyPosition Constructor
        ///</summary>
        // TODO: Ensure that the UrlToTest attribute specifies a URL to an ASP.NET page (for example,
        // http://.../Default.aspx). This is necessary for the unit test to be executed on the web server,
        // whether you are testing a page, web service, or a WCF service.
        [TestMethod()]
        [HostType("ASP.NET")]
        [AspNetDevelopmentServerHost("C:\\Users\\Admin\\Documents\\Visual Studio 2010\\Projects\\CA3 EAD\\CA3 EAD", "/")]
        [UrlToTest("http://localhost:2124/")]
        public void CompanyPositionConstructorTest()
        {
            CompanyPosition target = new CompanyPosition();
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for CreateCompanyPosition
        ///</summary>
        // TODO: Ensure that the UrlToTest attribute specifies a URL to an ASP.NET page (for example,
        // http://.../Default.aspx). This is necessary for the unit test to be executed on the web server,
        // whether you are testing a page, web service, or a WCF service.
        [TestMethod()]
        [HostType("ASP.NET")]
        [AspNetDevelopmentServerHost("C:\\Users\\Admin\\Documents\\Visual Studio 2010\\Projects\\CA3 EAD\\CA3 EAD", "/")]
        [UrlToTest("http://localhost:2124/")]
        public void CreateCompanyPositionTest()
        {
            int gradeID = 0; // TODO: Initialize to an appropriate value
            string jobDescription = string.Empty; // TODO: Initialize to an appropriate value
            string department = string.Empty; // TODO: Initialize to an appropriate value
            Decimal salary = new Decimal(); // TODO: Initialize to an appropriate value
            CompanyPosition expected = null; // TODO: Initialize to an appropriate value
            CompanyPosition actual;
            actual = CompanyPosition.CreateCompanyPosition(gradeID, jobDescription, department, salary);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Department
        ///</summary>
        // TODO: Ensure that the UrlToTest attribute specifies a URL to an ASP.NET page (for example,
        // http://.../Default.aspx). This is necessary for the unit test to be executed on the web server,
        // whether you are testing a page, web service, or a WCF service.
        [TestMethod()]
        [HostType("ASP.NET")]
        [AspNetDevelopmentServerHost("C:\\Users\\Admin\\Documents\\Visual Studio 2010\\Projects\\CA3 EAD\\CA3 EAD", "/")]
        [UrlToTest("http://localhost:2124/")]
        public void DepartmentTest()
        {
            CompanyPosition target = new CompanyPosition(); // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            target.Department = expected;
            actual = target.Department;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Employees
        ///</summary>
        // TODO: Ensure that the UrlToTest attribute specifies a URL to an ASP.NET page (for example,
        // http://.../Default.aspx). This is necessary for the unit test to be executed on the web server,
        // whether you are testing a page, web service, or a WCF service.
        [TestMethod()]
        [HostType("ASP.NET")]
        [AspNetDevelopmentServerHost("C:\\Users\\Admin\\Documents\\Visual Studio 2010\\Projects\\CA3 EAD\\CA3 EAD", "/")]
        [UrlToTest("http://localhost:2124/")]
        public void EmployeesTest()
        {
            CompanyPosition target = new CompanyPosition(); // TODO: Initialize to an appropriate value
            EntityCollection<Employee> expected = null; // TODO: Initialize to an appropriate value
            EntityCollection<Employee> actual;
            target.Employees = expected;
            actual = target.Employees;
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
            CompanyPosition target = new CompanyPosition(); // TODO: Initialize to an appropriate value
            int expected = 0; // TODO: Initialize to an appropriate value
            int actual;
            target.GradeID = expected;
            actual = target.GradeID;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for JobDescription
        ///</summary>
        // TODO: Ensure that the UrlToTest attribute specifies a URL to an ASP.NET page (for example,
        // http://.../Default.aspx). This is necessary for the unit test to be executed on the web server,
        // whether you are testing a page, web service, or a WCF service.
        [TestMethod()]
        [HostType("ASP.NET")]
        [AspNetDevelopmentServerHost("C:\\Users\\Admin\\Documents\\Visual Studio 2010\\Projects\\CA3 EAD\\CA3 EAD", "/")]
        [UrlToTest("http://localhost:2124/")]
        public void JobDescriptionTest()
        {
            CompanyPosition target = new CompanyPosition(); // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            target.JobDescription = expected;
            actual = target.JobDescription;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Salary
        ///</summary>
        // TODO: Ensure that the UrlToTest attribute specifies a URL to an ASP.NET page (for example,
        // http://.../Default.aspx). This is necessary for the unit test to be executed on the web server,
        // whether you are testing a page, web service, or a WCF service.
        [TestMethod()]
        [HostType("ASP.NET")]
        [AspNetDevelopmentServerHost("C:\\Users\\Admin\\Documents\\Visual Studio 2010\\Projects\\CA3 EAD\\CA3 EAD", "/")]
        [UrlToTest("http://localhost:2124/")]
        public void SalaryTest()
        {
            CompanyPosition target = new CompanyPosition(); // TODO: Initialize to an appropriate value
            Decimal expected = new Decimal(); // TODO: Initialize to an appropriate value
            Decimal actual;
            target.Salary = expected;
            actual = target.Salary;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }
    }
}
