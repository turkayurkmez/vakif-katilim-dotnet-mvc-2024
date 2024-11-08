using eshop.Application;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.JsonWebTokens;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using JwtRegisteredClaimNames = System.IdentityModel.Tokens.Jwt.JwtRegisteredClaimNames;

namespace eshop.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController(IUserService userService) : ControllerBase
    {
        [HttpPost]
        public IActionResult Login(UserLoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                var user = userService.ValidateUser(model.UserName, model.Password);
                if (user != null) {

                    SymmetricSecurityKey key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("Burası 256 bitlik özel ifade haberiniz olsun"));
                    SigningCredentials credentials = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

                    Claim[] claims =
                    {
                        new Claim(JwtRegisteredClaimNames.Name, user.Name),
                        new Claim(JwtRegisteredClaimNames.UniqueName, user.UserName),
                        new Claim(ClaimTypes.Role, user.Role)
                    };

                    var token = new JwtSecurityToken
                        (
                          issuer: "vakifkatilim.server",
                          audience: "vakifkatilim.client",
                          claims: claims,
                          notBefore: DateTime.Now,
                          expires: DateTime.Now.AddDays(15),
                          signingCredentials: credentials
                        );

                    var genToken = new JwtSecurityTokenHandler().WriteToken(token);
                    return Ok(new {token= genToken});

                }
                ModelState.AddModelError("login", "Login Failed");
            }
            return BadRequest(ModelState);

        }
    }
}
