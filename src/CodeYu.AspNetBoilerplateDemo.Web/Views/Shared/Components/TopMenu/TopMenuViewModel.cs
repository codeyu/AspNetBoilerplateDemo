﻿using Abp.Application.Navigation;

namespace CodeYu.AspNetBoilerplateDemo.Web.Views.Shared.Components.TopMenu
{
    public class TopMenuViewModel
    {
        public UserMenu MainMenu { get; set; }

        public string ActiveMenuItemName { get; set; }
    }
}