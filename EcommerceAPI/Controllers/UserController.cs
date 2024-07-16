﻿using EcommerceAPI.Model;
using EcommerceAPI.DatabaseContext;
using Microsoft.AspNetCore.Mvc;

namespace EcommerceAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : Controller
    {
        private readonly EcommerceContext _context;

        public UserController(EcommerceContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetUsers()
        {
            var allUsers = _context.Users.ToList();
            return Ok(allUsers);
        }

        [HttpPost]
        public IActionResult CreateUsers(User user)
        {
            _context.Users.Add(user);
            _context.SaveChanges();

            return Ok(user);
        }

        [HttpPut]
        public IActionResult UpdateUsers(int id, User user)
        {
            var userToUpdate = _context.Users.Find(id);

            if (userToUpdate == null)
            {
                return NotFound();
            }

            userToUpdate.Name = user.Name;
            userToUpdate.Email = user.Email;
            userToUpdate.Id = user.Id;
            userToUpdate.Password = user.Password;
            userToUpdate.BirthDay = user.BirthDay;

            _context.Users.Update(userToUpdate);
            _context.SaveChanges();

            return Ok(userToUpdate);
        }
    }
}
