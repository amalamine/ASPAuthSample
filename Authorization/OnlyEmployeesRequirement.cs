using System;
using Microsoft.AspNetCore.Authorization;

namespace rest.Authorization
{
    public class OnlyEmployeesRequirement : IAuthorizationRequirement
    {
    }
}
