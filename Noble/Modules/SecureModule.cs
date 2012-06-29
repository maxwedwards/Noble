﻿namespace Noble
{
    using Nancy;
    using Noble.Models;
    using Nancy.Security;

    public class SecureModule : NancyModule
    {
        public SecureModule()
            : base("/secure")
        {
            this.RequiresAuthentication();

            Get["/"] = x =>
            {
                var model = new UserModel(Context.CurrentUser.UserName);
                return View["secure.cshtml", model];
            };
        }
    }
}