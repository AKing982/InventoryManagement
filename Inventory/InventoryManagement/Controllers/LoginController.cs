using System.Security.Claims;
using InventoryManagement.domain;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace InventoryManagement.Controllers;

public class LoginController : ControllerBase
{
    private readonly UserManager<IdentityUser> _userManager;
    private readonly SignInManager<IdentityUser> _signInManager;

    public LoginController(UserManager<IdentityUser> userManager,
        SignInManager<IdentityUser> signInManager)
    {
        this._userManager = _userManager;
        this._signInManager = _signInManager;
    }

    [HttpPost]
    public async Task<IActionResult> Login([FromBody] Logindto model)
    {
        var user = await _userManager.FindByNameAsync(model.User);
        if (user != null && await _userManager.CheckPasswordAsync(user, model.Password))
        {
            var token = GenerateJwtToken(user);
            return Ok(new { token });
        }

        return Unauthorized();
    }

    private string GenerateJwtToken(IdentityUser user)
    {
        var claims = new List<Claim>
        {
            new Claim(ClaimTypes.NameIdentifier, user.Id.ToString()),
            new Claim(ClaimTypes.Name, user.UserName)
        };
        return "";
    }
}