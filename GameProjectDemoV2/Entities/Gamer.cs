using System;
using System.Collections.Generic;
using System.Text;
using GameProjectDemoV2.Abstract;

namespace GameProjectDemoV2.Entities
{
    public class Gamer : IEntitiy
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string NationalityId { get; set; }
        public DateTime DateOfBirth { get; set; }
    }
}
