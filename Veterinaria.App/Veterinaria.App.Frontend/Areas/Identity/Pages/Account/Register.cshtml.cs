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

namespace Veterinaria.App.Frontend.Areas.Identity.Pages.Account
{
    [Authorize(Roles="Auxiliar")]
    public class RegisterModel : PageModel
    {
        private readonly SignInManager<IdentityUser> _signInManager;
        private readonly UserManager<IdentityUser> _userManager;
        private readonly ILogger<RegisterModel> _logger;
        private readonly IEmailSender _emailSender;
        private readonly RoleManager <IdentityRole> _roleManager;

        private readonly IRepositorioAuxiliar iRepositorioAuxiliar;

        public RegisterModel(
            UserManager<IdentityUser> userManager,
            SignInManager<IdentityUser> signInManager,
            ILogger<RegisterModel> logger,
            IEmailSender emailSender, RoleManager <IdentityRole> roleManager, IRepositorioAuxiliar iRepositorioAuxiliar)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _logger = logger;
            _emailSender = emailSender;
            _roleManager = roleManager;
            this.iRepositorioAuxiliar = iRepositorioAuxiliar;
        }

        [BindProperty]
        public InputModel Input { get; set; }

        public string ReturnUrl { get; set; }

        public IList<AuthenticationScheme> ExternalLogins { get; set; }

        public class InputModel
        {
            [Required(ErrorMessage="El campo es obligatorio"),Range(0,int.MaxValue,ErrorMessage="La cedula debe ser mayor que 0"),RegularExpression(@"^\S*$",ErrorMessage="No se admiten espacios")]
            [Display(Name = "Usuario (cédula)")]
            public string documento { get; set; }
            [Required]
            [EmailAddress]
            [Display(Name = "Correo electrónica")]
            public string Email { get; set; }

            [Required]
            [StringLength(100, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 6)]
            [DataType(DataType.Password)]
            [Display(Name = "Contraseña")]
            public string Password { get; set; }

            [DataType(DataType.Password)]
            [Display(Name = "Confirmar contraseña")]
            [Compare("Password", ErrorMessage = "La contraseña no coincide con la confirmación")]
            public string ConfirmPassword { get; set; }
        }

        public async Task OnGetAsync(string returnUrl = null)
        {
            ReturnUrl = returnUrl;
            ExternalLogins = (await _signInManager.GetExternalAuthenticationSchemesAsync()).ToList();
        }

       public async Task<IActionResult> OnPostAsync(string returnUrl = null)
        {
             ReturnUrl = returnUrl;
            
            if (ModelState.IsValid)
            {
                var user = new IdentityUser { UserName = Input.documento, Email = Input.Email, EmailConfirmed=true };                
                var result = await _userManager.CreateAsync(user, Input.Password);
                var rolexiste = await _roleManager.RoleExistsAsync("Auxiliar");

                if(!rolexiste)
                {
                    var rol = new IdentityRole{

                        Name = "Auxiliar"
                    };
                await _roleManager.CreateAsync(rol);
                    
                }

                if (result.Succeeded)
                {
                    //iRepositorioAuxiliar.AddAuxiliar(auxiliar);
                    _logger.LogInformation("Cuenta de usuario nueva creada");

                    var code = await _userManager.GenerateEmailConfirmationTokenAsync(user);
                    code = WebEncoders.Base64UrlEncode(Encoding.UTF8.GetBytes(code));
                    var callbackUrl = Url.Page(
                        "/Account/ConfirmEmail",
                        pageHandler: null,
                        values: new { area = "Identity", userId = user.Id, code = code, returnUrl = returnUrl },
                        protocol: Request.Scheme);

                    await _emailSender.SendEmailAsync(Input.Email, "Confirm your email",
                        $"Please confirm your account by <a href='{HtmlEncoder.Default.Encode(callbackUrl)}'>clicking here</a>.");

                    var rolefinal = await _userManager.AddToRoleAsync(user, "Auxiliar").ConfigureAwait(false);

                    if (_userManager.Options.SignIn.RequireConfirmedAccount)
                    {
                        return RedirectToPage("RegisterConfirmation", new { email = Input.Email, returnUrl = returnUrl });
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
