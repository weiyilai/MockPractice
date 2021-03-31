using Microsoft.VisualStudio.TestTools.UnitTesting;
using MockPractice.Web.Models;
using MockPractice.Web.Repository;
using MockPractice.Web.Service;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MockPractice.Web.Service.Tests
{
    [TestClass()]
    public class SampleServiceTests
    {
        [TestMethod()]
        public void GetSampleTest()
        {
            // arrange
            var source = new List<SampleModel>()
            {
                new SampleModel() { Id = 1, Name = "陳大寶", Birthday = DateTime.Parse("2001/1/1") }
            };

            var mockRepo = new Mock<ISampleRepository>();
            mockRepo.Setup(repo => repo.GetSample(It.IsAny<int>())).Returns(source);

            var service = new SampleService(mockRepo.Object);

            // act
            var actual = service.GetSample(1);

            // assert
            Assert.AreEqual(actual.First().Name, "陳**");
        }
    }
}