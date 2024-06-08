﻿using mechatro_project.Models;
using Microsoft.AspNetCore.Mvc;
using XAct;

namespace mechatro_project.ViewComponents
{
    public class Telephone:ViewComponent
    {

        public string Invoke()
        {
            MechatroContext context= new MechatroContext();
            string? telephone = context.Settings.FirstOrDefault(s => s.SettingID == 1).Telephone;
            return $"{telephone}";
        }
    }
}