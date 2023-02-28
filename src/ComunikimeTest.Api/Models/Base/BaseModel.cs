using System;

namespace ComunikimeTest.Api.Models
{
    public abstract class BaseModel
    {
        public BaseModel()
        { 
        }

        public int Id { get; set; }
    }
}
