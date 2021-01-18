#pragma checksum "C:\Users\Admin\source\repos\ZiblinWebb\Pages\Administration.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "012b504669ed3b33fe86a876e1e646229deb055f"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace ZiblinWebb.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Admin\source\repos\ZiblinWebb\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Admin\source\repos\ZiblinWebb\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Admin\source\repos\ZiblinWebb\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Admin\source\repos\ZiblinWebb\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Admin\source\repos\ZiblinWebb\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Admin\source\repos\ZiblinWebb\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Admin\source\repos\ZiblinWebb\_Imports.razor"
using ZiblinWebb;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Admin\source\repos\ZiblinWebb\_Imports.razor"
using ZiblinWebb.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Admin\source\repos\ZiblinWebb\_Imports.razor"
using Blazored;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Admin\source\repos\ZiblinWebb\_Imports.razor"
using Blazored.Typeahead;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Admin\source\repos\ZiblinWebb\Pages\Administration.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Admin\source\repos\ZiblinWebb\Pages\Administration.razor"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/administration")]
    public partial class Administration : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 131 "C:\Users\Admin\source\repos\ZiblinWebb\Pages\Administration.razor"
       

    [CascadingParameter]
    private Task<AuthenticationState> authenticationStateTask { get; set; }
    string ADMINISTRATION_ROLE = "Administrators";
    System.Security.Claims.ClaimsPrincipal CurrentUser;

    // Property used to add or edit the currently selected user
    IdentityUser objUser = new IdentityUser();
    // Tracks the selected role for the currently selected user
    string CurrentUserRole { get; set; } = "Users";
    // Collection to display the existing users
    List<IdentityUser> ColUsers = new List<IdentityUser>();
    // Options to display in the roles dropdown when editing a user
    List<string> Options = new List<string>() { "Users", "Administrators" };
    // To hold any possible errors
    string strError = "";
    // To enable showing the Popup
    bool ShowPopup = false;

    protected override async Task OnInitializedAsync()
    {
        // ensure there is a ADMINISTRATION_ROLE
        var RoleResult = await _RoleManager.FindByNameAsync(ADMINISTRATION_ROLE);
        if (RoleResult == null)
        {
            // Create ADMINISTRATION_ROLE Role
            await _RoleManager.CreateAsync(new IdentityRole(ADMINISTRATION_ROLE));
        }
        // Ensure a user named Admin@BlazorHelpWebsite.com is an Administrator
        var user = await _UserManager.FindByNameAsync("Admin@BlazorHelpWebsite.com");
        if (user != null)
        {
            // Is Admin@BlazorHelpWebsite.com in administrator role?
            var UserResult = await _UserManager.IsInRoleAsync(user, ADMINISTRATION_ROLE);
            if (!UserResult)
            {
                // Put admin in Administrator role
                await _UserManager.AddToRoleAsync(user, ADMINISTRATION_ROLE);
            }
        }
        // Get the current logged in user
        CurrentUser = (await authenticationStateTask).User;

        // Get the users
        GetUsers();
    }

    void AddNewUser()
    {
        // Make new user
        objUser = new IdentityUser();
        objUser.PasswordHash = "*****";
        // Set Id to blank so we know it is a new record
        objUser.Id = "";
        // Open the Popup
        ShowPopup = true;
    }

    async Task SaveUser()
    {
        try
        {
            // Is this an existing user?
            if (objUser.Id != "")
            {
                // Get the user
                var user = await _UserManager.FindByIdAsync(objUser.Id);
                // Update Email
                user.Email = objUser.Email;
                // Update the user
                await _UserManager.UpdateAsync(user);
                // Only update password if the current value
                // is not the default value
                if (objUser.PasswordHash != "*****")
                {
                    var resetToken =
                        await _UserManager.GeneratePasswordResetTokenAsync(user);
                    var passworduser =
                        await _UserManager.ResetPasswordAsync(
                            user,
                            resetToken,
                            objUser.PasswordHash);
                    if (!passworduser.Succeeded)
                    {
                        if (passworduser.Errors.FirstOrDefault() != null)
                        {
                            strError =
                                passworduser
                                .Errors
                                .FirstOrDefault()
                                .Description;
                        }
                        else
                        {
                            strError = "Pasword error";
                        }
                        // Keep the popup opened
                        return;
                    }
                }
                // Handle Roles
                // Is user in administrator role?
                var UserResult =
                    await _UserManager
                    .IsInRoleAsync(user, ADMINISTRATION_ROLE);
                // Is Administrator role selected
                // but user is not an Administrator?
                if (
                    (CurrentUserRole == ADMINISTRATION_ROLE)
                    &
                    (!UserResult))
                {
                    // Put admin in Administrator role
                    await _UserManager
                        .AddToRoleAsync(user, ADMINISTRATION_ROLE);
                }
                else
                {
                    // Is Administrator role not selected
                    // but user is an Administrator?
                    if ((CurrentUserRole != ADMINISTRATION_ROLE)
                        &
                        (UserResult))
                    {
                        // Remove user from Administrator role
                        await _UserManager
                            .RemoveFromRoleAsync(user, ADMINISTRATION_ROLE);
                    }
                }
            }
            else
            {
                // Insert new user
                var NewUser =
                    new IdentityUser
                    {
                        UserName = objUser.UserName,
                        Email = objUser.Email
                    };
                var CreateResult =
                    await _UserManager
                    .CreateAsync(NewUser, objUser.PasswordHash);
                if (!CreateResult.Succeeded)
                {
                    if (CreateResult
                        .Errors
                        .FirstOrDefault() != null)
                    {
                        strError =
                            CreateResult
                            .Errors
                            .FirstOrDefault()
                            .Description;
                    }
                    else
                    {
                        strError = "Create error";
                    }
                    // Keep the popup opened
                    return;
                }
                else
                {
                    // Handle Roles
                    if (CurrentUserRole == ADMINISTRATION_ROLE)
                    {
                        // Put admin in Administrator role
                        await _UserManager
                            .AddToRoleAsync(NewUser, ADMINISTRATION_ROLE);
                    }
                }
            }
            // Close the Popup
            ShowPopup = false;
            // Refresh Users
            GetUsers();
        }
        catch (Exception ex)
        {
            strError = ex.GetBaseException().Message;
        }
    }


    async Task EditUser(IdentityUser _IdentityUser)
    {
        // Set the selected user
        // as the current user
        objUser = _IdentityUser;
        // Get the user
        var user = await _UserManager.FindByIdAsync(objUser.Id);
        if (user != null)
        {
            // Is user in administrator role?
            var UserResult =
                await _UserManager
                .IsInRoleAsync(user, ADMINISTRATION_ROLE);
            if (UserResult)
            {
                CurrentUserRole = ADMINISTRATION_ROLE;
            }
            else
            {
                CurrentUserRole = "Users";
            }
        }
        // Open the Popup
        ShowPopup = true;
    }

    async Task DeleteUser()
    {
        // Close the Popup
        ShowPopup = false;
        // Get the user
        var user = await _UserManager.FindByIdAsync(objUser.Id);
        if (user != null)
        {
            // Delete the user
            await _UserManager.DeleteAsync(user);
        }
        // Refresh Users
        GetUsers();
    }


    void ClosePopup()
    {
        // Close the Popup
        ShowPopup = false;
    }


    public void GetUsers()
    {
        // clear any error messages
        strError = "";
        // Collection to hold users
        ColUsers = new List<IdentityUser>();
        // get users from _UserManager
        var user = _UserManager.Users.Select(x => new IdentityUser
        {
            Id = x.Id,
            UserName = x.UserName,
            Email = x.Email,
            PasswordHash = "*****"
        });
        foreach (var item in user)
        {
            ColUsers.Add(item);
        }
    }
































#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthenticationStateProvider AuthenticationStateProvider { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private RoleManager<IdentityRole> _RoleManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private UserManager<IdentityUser> _UserManager { get; set; }
    }
}
#pragma warning restore 1591
