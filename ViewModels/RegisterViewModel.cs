﻿using OnTheWay.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace OnTheWay.ViewModels
{
    public class RegisterViewModel
    {
        ApiServices apiservices = new ApiServices();
        public string Email { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }

        public ICommand RegisterCommand
        {
            get
            {
                return new Command(() =>
               {
                   apiservices.RegisterAsync

               });
            }
        }
    }
}