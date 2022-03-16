using System;
using System.Collections.Generic;
using System.Text;

namespace Homework
{
    internal class User
    {
        public User(string username,string password)
        {
            this.UserName = username;
            this.Password = password;
        }

        private string _userName;
        private string _password;

        public string UserName
        {
            get => this._userName;
            set
            {
                if(!string.IsNullOrWhiteSpace(value) && value.Length>5 && value.Length<26)
                    this._userName = value;
            }
        }

        public string Password
        {
            get => this._password;
            set
            {
                if (CheckPassword(value))
                    this._password = value;
            }
        }

        public bool HasDigit(string str)
        {
            if (!string.IsNullOrWhiteSpace(str))
            {
                for (int i = 0; i < str.Length; i++)
                {
                    if (char.IsDigit(str[i]))
                        return true;
                }
            }
           

            return false;
        }

        public bool HasUpper(string str)
        {
            if (!string.IsNullOrWhiteSpace(str))
            {
                for (int i = 0; i < str.Length; i++)
                {
                    if (char.IsUpper(str[i]))
                        return true;
                }
            }

            return false;
        }

        public bool HasLower(string str)
        {
            if (!string.IsNullOrWhiteSpace(str))
            {
                for (int i = 0; i < str.Length; i++)
                {
                    if (char.IsLower(str[i]))
                        return true;
                }
            }

            return false;
        }


        public bool CheckPassword(string password)
        {
            bool hasDigit = false;
            bool hasLower = false;
            bool hasUpper = false;

            if (!string.IsNullOrWhiteSpace(password) && password.Length>7 && password.Length<26)
            {
                for (int i = 0; i < password.Length; i++)
                {
                    if(char.IsDigit(password[i]))
                        hasDigit = true;
                    else if(char.IsLower(password[i]))
                        hasLower = true;
                    else if(char.IsUpper(password[i]))
                        hasUpper = true;

                    if (hasUpper && hasLower && hasDigit)
                        return true;
                }
            }

            return false;
        }
    }
}
