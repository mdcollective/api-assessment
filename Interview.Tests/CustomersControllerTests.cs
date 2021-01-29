using Microsoft.ApplicationInsights;
using Moq;
using NUnit.Framework;
using ProgLeasing.System.FeatureFlag.Contract;
using ProgLeasing.System.Logging.Contract;
using Interview.Business;
using Interview.Controllers;

namespace Interview.Tests
{
    public class CustomerControllerTests
    {
        private Mock<ICustomerService> _mockSampleService;
        private Mock<ILogger<CustomersController>> _mockLogger;
        private Mock<IFeatureFlagValueProvider> _mockFeatureFlagValueProvider;
        private CustomersController _controller;

        [SetUp]
        public void Initialize()
        {
            _mockLogger = new Mock<ILogger<CustomersController>>();
            _mockSampleService = new Mock<ICustomerService>();
            _mockFeatureFlagValueProvider = new Mock<IFeatureFlagValueProvider>();
            //NOTE: There is an open request for putting an interface in front of the TelemetryClient https://github.com/Microsoft/ApplicationInsights-dotnet/issues/342
            //When this is fixed we will update the warning with the deprecated constructor of TelemetryClient
            _controller = new CustomersController(_mockSampleService.Object, _mockLogger.Object, new TelemetryClient(), _mockFeatureFlagValueProvider.Object);
        }

        [Test]
        public void BlankExampleTest()
        {
            //Arrange

            //Act

            //Assert
            Assert.Pass();
        }
    }
}