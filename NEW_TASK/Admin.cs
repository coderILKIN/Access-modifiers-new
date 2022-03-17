using System;
using System.Collections.Generic;
using System.Text;

namespace NEW_TASK
{
    class Admin
    {
        public bool isSuperAdmin;
        public string Section;


        public Admin(string section, string username, int password, bool issuperadmin = true) : base(username, password)
        {

            isSuperAdmin = issuperadmin;
            Section = section;
        }

        public void Information()
        {
            Console.WriteLine($"isSuperAdmin: {isSuperAdmin},Section: {Section},username: {_username}, password: {_password}");
        }


    }
}
