using System;
using System.Collections.Generic;
using System.Text;
using Model.RestModel;

namespace Model.RestModel
{
    public class UserResponse
    {
        public string User { get; set; }
        public string Token { get; set; }
        public RoleViewModel Role { get; set; }
    }
}
