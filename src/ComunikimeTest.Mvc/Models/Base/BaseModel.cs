using System;

namespace ComunikimeTest.Mvc.Models
{
    public abstract class BaseModel
    {
        public BaseModel()
        { 
        }

        public int Id { get; set; }
    }
}
