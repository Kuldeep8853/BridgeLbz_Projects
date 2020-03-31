using System;
using System.Collections.Generic;
using System.Text;

namespace Invoice_Generator
{
    public class Custmor
    {
        public string User_Id { get; set; }

        public Custmor(string id)
        {
            this.User_Id = id;
        }
    }
}
