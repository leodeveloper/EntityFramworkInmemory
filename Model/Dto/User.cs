using System;
using System.Collections.Generic;
using System.Text;

namespace Model.Dto
{
    public class User
    {
        public string Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public List<Post> Posts { get; set; }
    }
}
