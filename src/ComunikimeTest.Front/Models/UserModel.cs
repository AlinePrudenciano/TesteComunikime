using System;

namespace ComunikimeTest.Front.Models
{
    public class UserModel : BaseModel
    {
        public UserModel() : base()
        {
        }


        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }

        public bool IsAdmin { get; set; }
    }
}
