using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAY7_TASK1
{
    class User
    {
        String email;
        String password;
        long mobile_no;
        String address;

        public User()
        {

        }
        public User(String email, String password, long mobile_no, String address)
        {
            email = email;
            password = password;
            mobile_no = mobile_no;
            address = address;
        }

        public string Email { get => email; set => email = value; }
        public string Password { get => password; set => password = value; }
        public long Mobile_no { get => mobile_no; set => mobile_no = value; }
        public string Address { get => address; set => address = value; }


        public override string ToString()
        {
            return String.Format("email: {0} \n password: {1} \n mobileno: {2} \n address: {3}   ", email, password, mobile_no, address);
        }
    }
}

