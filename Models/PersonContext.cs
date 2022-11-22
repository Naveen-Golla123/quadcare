using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class Person
    {
        public int id { get; set; }

        public string name { get; set; }

        public int age { get; set; }
    }
}
