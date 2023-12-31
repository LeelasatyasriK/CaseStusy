﻿using HotelBooking.DomainModels;
using HotelBooking.Repositories;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace HotelBooking.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly UserManager<IdentityUser> userManager;
        private readonly ITokenRepository tokenRepository;

        public AuthController(UserManager<IdentityUser> userManager, ITokenRepository tokenRepository)
        {
            this.userManager = userManager;
            this.tokenRepository = tokenRepository;
        }
        [HttpPost]
        [Route("Register")]
        public async Task<IActionResult> Register([FromBody] RegisterRequestDTO registerRequestDTO)
        {
            var identityUser = new IdentityUser
            {
                UserName = registerRequestDTO.Username,
                Email = registerRequestDTO.Username,
                PhoneNumber = registerRequestDTO.PhoneNumber
            };
            var identityResult = await userManager.CreateAsync(identityUser, registerRequestDTO.Password);
            if(identityResult.Succeeded) 
            {
                if (registerRequestDTO.Roles != null && registerRequestDTO.Roles.Any())
                {
                    identityResult = await userManager.AddToRolesAsync(identityUser, registerRequestDTO.Roles);
                    if(identityResult.Succeeded)
                    {
                        return Ok("User was registered...please login");
                    }
                }
            }
            return BadRequest("Something went wrong");
        }

        [HttpPost]
        [Route("Login")]
        public async Task<IActionResult> Login([FromBody] LoginRequestDTO loginRequestDTO)
        {
            var user = await userManager.FindByEmailAsync(loginRequestDTO.Username);
            if(user != null)
            {
                var checkPasswordResult = await userManager.CheckPasswordAsync(user, loginRequestDTO.Password);
                if (checkPasswordResult)
                {
                   
                    var roles = await userManager.GetRolesAsync(user);
                    if(roles != null) 
                    {
                        var jwtToken = tokenRepository.CreateJwtToken(user,roles.ToList());
                        var response = new LoginResponseDTO
                        {
                            JwtToken = jwtToken,
                            Role = roles[0]
                        };
                        return Ok(response);
                    }
                    //return Ok(new { Roles = roles });
                }
            }
            return BadRequest("Username or password incorrect");
        }

        //[HttpPost]
        //[Route("LogoutUser")]
        //public async Task<IActionResult> Logout()
        //{
        //    await HttpContext.SignOutAsync(IdentityConstants.ApplicationScheme);
        //    return Ok("Logged out successfully");
        //}

    }
}
