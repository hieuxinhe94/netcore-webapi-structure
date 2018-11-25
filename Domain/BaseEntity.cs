using System;
using System.ComponentModel.DataAnnotations;

namespace Domains
{
    public class BaseEntity
    {
        [Key]
        public int Id { get; set; }

        public DateTime DateCreated { get; set; }
    }
}
