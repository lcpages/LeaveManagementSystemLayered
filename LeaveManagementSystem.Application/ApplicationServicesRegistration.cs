using System;
using System.Reflection;
using LeaveManagementSystem.Application.Services.Email;
using LeaveManagementSystem.Application.Services.LeaveRequests;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Identity.UI.Services;

namespace LeaveManagementSystem.Application;

public static class ApplicationServicesRegistration
{
    public static IServiceCollection AddApllicationServices(this IServiceCollection services)
    {
        //Add AutoMapper
        services.AddAutoMapper(Assembly.GetExecutingAssembly());

        //Add custom LeaveTypesService
        services.AddScoped<ILeaveTypesService, LeaveTypesService>();
        //Add custom LeaveAllocationService
        services.AddScoped<ILeaveAllocationsService, LeaveAllocationsService>();
        //Add custom PeriodsService
        services.AddScoped<IPeriodsService, PeriodsService>();
        services.AddScoped<IUsersService, UsersService>();
        //Add custom LeaveRequestsService
        services.AddTransient<ILeaveRequestsService, LeaveRequestsService>();
        //Add custom EmailsSender
        services.AddTransient<IEmailSender, EmailSenderService>();

        return services;
    }
}
