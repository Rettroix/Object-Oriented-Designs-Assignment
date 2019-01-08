//KF7012 Task 3 Implementation
//Date: December 2018
//Names: Elliot Anderson, Adam Cook
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Model;
using Presenter; 


namespace UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
      Job testJob = new Job();
      ClientCompany testCompany = new ClientCompany();
      Address testLocation = new Address();


      [TestInitialize]
      public void TestInitialize()
      {

        testCompany.ClientName = "Codestomp Industries";
        testCompany.Email = "CodestompIndustries@gmail.com";

        
        testJob.MachineDescription = "Rubbish computer";
        testJob.FaultDescription = "It's broken";
        testJob.JobUrgency = 5;
        testJob.MachineComplexity = 5;

        testLocation.HouseNumber = "54";
        testLocation.Street = "Stupid Street";
        testLocation.Town = "Newcastle";
        testLocation.PostCode = "NE11 8FM";

        testJob.FactoryLocation.Add(testLocation);
        testCompany.Jobs.Add(testJob);

      }
      
        [TestCleanup]

      public void CleanupTests()
      {
        testJob = null;
        testCompany = null; 
        testLocation = null; 
      }

        [TestMethod]
        public void TestMethod1()
        {

        }
    }
}
