﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using TicTacToe.Services;
using TicTacToe.Extensions;
using Microsoft.AspNetCore.Routing;
using TicTacToe.Models;
using Microsoft.AspNetCore.Rewrite;

namespace TicTacToe
{
    //This class is all about the preloading and configuration of your services and middlewares.
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
            services.AddSingleton<IUserService, UserService>();
            services.AddRouting();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseBrowserLink();
            } else
            {
                app.UseExceptionHandler("/Home/Error");
            }

            app.UseStaticFiles();

            //Eksempel på rewriting
            var options = new RewriteOptions()
                .AddRewrite("NewUser", "/UserRegistration/Index", false);
            app.UseRewriter(options);

            //Why would you want this here?
            var routeBuilder = new RouteBuilder(app);
            routeBuilder.MapGet("CreateUser", context =>
            {
                var firstName = context.Request.Query["firstName"];
                var lastName = context.Request.Query["lastName"];
                var email = context.Request.Query["email"];
                var password = context.Request.Query["password"];
                var userService = context.RequestServices.GetService<IUserService>();
                userService.RegisterUser(new UserModel { FirstName = firstName, LastName = lastName, Email = email, Password = password });
                return context.Response.WriteAsync($"User {firstName} {lastName} has been sucessfully created.");
            });
            var newUserRoutes = routeBuilder.Build();
            app.UseRouter(newUserRoutes);


            app.UseWebSockets();
            app.UseCommunicationMiddleware();
            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });

            app.UseStatusCodePages("text/plain", "HTTP Error - Status Code: {0}");
        }
    }
}
