using Animalink.Data.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Animalink.Data
{
    public class Admin : Entity
    {
        private string _userName;
        private string _password;


        public string UserName
        {
            get => _userName;
            set
            {
                _userName = value;
                OnValueChanged();
            }
        }

        public string Password
        {
            get => _password;
            set
            {
                _password = value;
                OnValueChanged();
            }
        }

    }
}
