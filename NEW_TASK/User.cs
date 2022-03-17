using System;
using System.Collections.Generic;
using System.Text;

namespace NEW_TASK
{
    class User
    {
        private string _username;
        private int _password;







        public string Username { 
            get 
            {
                return _username;
            } 
            set 
            {
                if (value.Length > 6)
                {
                    _username = value;
                }

            } 
        }

        public User(string username)
        {
            Username = username;
            //_password = password;
        }

        //public int Password
        //{
        //    get
        //    {
        //        return _password;
        //    }

        //    set
        //    {
        //        if (value && )
        //        {

        //        }

        //    }
        //}


        //public void userinfo()
        //{
        //    Console.WriteLine($"username: {Username}, password: {_password}");
        //}








    }
}
