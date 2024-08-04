using InventoryManagement.Controllers;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using InventoryManagement.domain;
using Moq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;
using System.Security.Claims;
using JetBrains.Annotations;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Options;

namespace InventoryManagement.Tests.Controllers
{
    [TestClass]
    [TestSubject(typeof(LoginController))]
    public class LoginControllerTest
    {
        private Mock<UserManager<IdentityUser>> _userManagerMock;
        private Mock<SignInManager<IdentityUser>> _signInManagerMock;
        private LoginController _loginController;

        [TestInitialize]
        public void Setup()
        {
            var userStoreMock = new Mock<IUserStore<IdentityUser>>();
            _userManagerMock = new Mock<UserManager<IdentityUser>>(userStoreMock.Object, null, null, null, null, null,
                null, null, null);
            var claimsFactoryMock = new Mock<IUserClaimsPrincipalFactory<IdentityUser>>();
            var identityOptions = new IdentityOptions();
            var optionsAccessor = new Mock<IOptions<IdentityOptions>>();
            optionsAccessor.Setup(ap => ap.Value).Returns(identityOptions);
            _signInManagerMock = new Mock<SignInManager<IdentityUser>>(_userManagerMock.Object,
                new HttpContextAccessor(), claimsFactoryMock.Object, optionsAccessor.Object, null, null, null);
            _loginController = new LoginController(_userManagerMock.Object, _signInManagerMock.Object);
        }

        [TestMethod]
        public async Task TestLoginSuccessfully()
        {
            var loginModel = new Logindto("testUser", "testPassword");

            _userManagerMock.Setup(x => x.FindByNameAsync(It.IsAny<string>()))
                .ReturnsAsync(new IdentityUser { UserName = loginModel.User, PasswordHash = loginModel.Password });
            
            _userManagerMock.Setup(u => u.CheckPasswordAsync(It.IsAny<IdentityUser>(), It.IsAny<string>()))
                .ReturnsAsync(true);

            var result = await _loginController.Login(loginModel);
            Assert.IsNotNull(result);
            Assert.IsInstanceOfType(result, typeof(OkObjectResult));
        }

        [TestMethod]
        public async Task TestLoginUnauthorized()
        {
            var loginModel = new Logindto("testUser", "testPassword");

            _userManagerMock.Setup(x => x.FindByNameAsync(It.IsAny<string>()))
                .ReturnsAsync((IdentityUser)null);
            
            _userManagerMock.Setup(u => u.CheckPasswordAsync(It.IsAny<IdentityUser>(), It.IsAny<string>()))
                .ReturnsAsync(true);

            var result = await _loginController.Login(loginModel);
            Assert.IsInstanceOfType(result, typeof(UnauthorizedResult));
        }
    }
}