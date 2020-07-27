using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace OnTheWay.Models
{
    public class User
    {
        private object text;

        public int Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public User() { }
        public User(string Email, string Password)
        {
            this.Email = Email;
            this.Password = Password;
        }

        public User(object text)
        {
            this.text = text;
        }
    }
}