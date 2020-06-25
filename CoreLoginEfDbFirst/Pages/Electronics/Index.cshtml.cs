using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace TestingEyes.Pages.Electronics
{
    public class IndexModel : PageModel
    {
        public void OnGet()
        {
        }

        #region Log Out method.

        /// <summary>
        /// POST: /Home/Index/LogOff
        /// </summary>
        /// <returns>Return log off action</returns>
        public async Task<IActionResult> OnPostLogOff()
        {
            try
            {
                // Setting.
                var authenticationManager = Request.HttpContext;

                // Sign Out.
                await authenticationManager.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            }
            catch (Exception ex)
            {
                // Info
                throw ex;
            }

            // Info.
            return this.RedirectToPage("/Index");
        }

        [HttpPost]
        public ActionResult  OnDropSelection()
        {

            return this.RedirectToPage("Mobile/Mobile");
        }

        #endregion
    }
}
