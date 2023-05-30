using BehsaApp.Administration;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Serenity;
using Serenity.Data;
using Serenity.Extensions;
using Serenity.Services;
using Serenity.Web;
using System;
using System.Globalization;

namespace BehsaApp.Membership.Pages
{
    public partial class AboutPage : Controller
    {
        [Route("Support/Contact")]
        [HttpGet, PageAuthorize]
        public ActionResult Contact()
        {
            return View(MVC.Views.Support.About.ContactPage);
        }

        [HttpPost, JsonRequest, ServiceAuthorize]
        public Result<ServiceResponse> ContactSubmit(ChangePasswordRequest request,
            [FromServices] IUserPasswordValidator passwordValidator,
            [FromServices] IOptions<EnvironmentSettings> environmentOptions)
        {
            return this.InTransaction("Default", uow =>
            {
                if (request is null)
                    throw new ArgumentNullException(nameof(request));

                if (string.IsNullOrEmpty(request.OldPassword))
                    throw new ArgumentNullException(nameof(request.OldPassword));

                if (passwordValidator is null)
                    throw new ArgumentNullException(nameof(passwordValidator));

                var username = User.Identity?.Name;

              
                string salt = null;
                var hash = UserHelper.GenerateHash(request.NewPassword, ref salt);
                var userId = int.Parse(User.GetIdentifier(), CultureInfo.InvariantCulture);

                environmentOptions.CheckPublicDemo(userId);

                uow.Connection.UpdateById(new UserRow
                {
                    UserId = userId,
                    PasswordSalt = salt,
                    PasswordHash = hash
                });

             

                return new ServiceResponse();
            });
        }
    }
}
