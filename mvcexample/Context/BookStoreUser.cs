using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;
using mvcexample.Models;

namespace mvcexample.Context
{
    public class BookStoreUser : IdentityUser
    {
        [MaxLength(30)]
        public string FirstName { get; set; }
        [MaxLength(40)]
        public string LastName { get; set; }
    }
}