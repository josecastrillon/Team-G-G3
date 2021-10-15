using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.WebUtilities;
using Microsoft.Extensions.Logging;
using Veterinaria.App.Dominio;
using Veterinaria.App.Persistencia;

namespace Veterinaria.App.Frontend.Pages
{
    public class AddPropietariosModel : PageModel
    {
        private readonly IRepositorioPropietario iRepositorioPropietario;

        public Propietario propietario;
        private readonly SignInManager<IdentityUser> _signInManager;
        private readonly UserManager<IdentityUser> _userManager;
        private readonly ILogger<AddPropietariosModel> _logger;
        private readonly IEmailSender _emailSender;

        private readonly RoleManager<IdentityRole> _roleManager;

        public AddPropietariosModel (IRepositorioPropietario iRepositorioPropietario, UserManager<IdentityUser> userManager,
            SignInManager<IdentityUser> signInManager,
            ILogger<AddPropietariosModel> logger,
            IEmailSender emailSender,RoleManager<IdentityRole> roleManager)
        {
            this.iRepositorioPropietario = iRepositorioPropietario;
            _userManager = userManager;
            _signInManager = signInManager;
            _logger = logger;
            _emailSender = emailSender;
            _roleManager = roleManager;
        }
        public void OnGet()
        {
            propietario = new Propietario ();
        }

        public async Task<IActionResult> OnPostAsync(Propietario propietario)
        {
            string returnUrl = "./ListPropietarios";
            
            if (ModelState.IsValid)
            {
                var user = new IdentityUser { UserName = propietario.documento, Email = propietario.email, EmailConfirmed=true };                
                var result = await _userManager.CreateAsync(user, propietario.password);
                var rolexiste = await _roleManager.RoleExistsAsync("Propietario");

                if(!rolexiste)
                {
                    var rol = new IdentityRole{

                        Name = "Propietario"
                    };
                await _roleManager.CreateAsync(rol);
                    
                }

                if (result.Succeeded)
                {
                    iRepositorioPropietario.AddPropietario(propietario);
                    _logger.LogInformation("Cuenta de usuario nueva creada");

                    var code = await _userManager.GenerateEmailConfirmationTokenAsync(user);
                    code = WebEncoders.Base64UrlEncode(Encoding.UTF8.GetBytes(code));
                    var callbackUrl = Url.Page(
                        "/Account/ConfirmEmail",
                        pageHandler: null,
                        values: new { area = "Identity", userId = user.Id, code = code, returnUrl = returnUrl },
                        protocol: Request.Scheme);

                    await _emailSender.SendEmailAsync(propietario.email, "Confirm your email",
                        $"Please confirm your account by <a href='{HtmlEncoder.Default.Encode(callbackUrl)}'>clicking here</a>.");

                    var rolefinal = await _userManager.AddToRoleAsync(user, "Propietario").ConfigureAwait(false);

                    if (_userManager.Options.SignIn.RequireConfirmedAccount)
                    {
                        return RedirectToPage("RegisterConfirmation", new { email = propietario.email, returnUrl = returnUrl });
                    }
                    else
                    {
                        await _signInManager.SignInAsync(user, isPersistent: false);
                        return RedirectToPage("./");
                    }
                }
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(string.Empty, error.Description);
                }
            }

            // If we got this far, something failed, redisplay form
            return Page();
        }

    }
}
