using DigitalBanking.Domain.Base;
using System;

namespace DigitalBanking.Domain.Entities
{
    public class PersonSample : Entity
    {
        public string FullName { get; set; }
        public DateTime DateBirth { get; set; }
        public int Age { get; set; }
    }
}
