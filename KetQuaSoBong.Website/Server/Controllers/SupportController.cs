﻿using KetQuaSoBong.Website.Shared.Configurations;
using KetQuaSoBong.Website.Shared.Supports;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;

namespace KetQuaSoBong.Website.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SupportController : ControllerBase
    {
        private readonly IMongoCollection<Support> _collectionSupport;
        private readonly IMongoCollection<Contact> _collectionContact;

        public SupportController()
        {
            MongoClient mongo = new MongoClient(AppConstants.ConnectionStringMongoDb);
            IMongoDatabase database = mongo.GetDatabase("Kqxs");
            _collectionSupport = database.GetCollection<Support>(nameof(Support));
            _collectionContact = database.GetCollection<Contact>(nameof(Contact));
        }
        [HttpGet("contact")]
        public async Task<IActionResult> GetContact()
        {
            var data = _collectionContact.Find(Builders<Contact>.Filter.Empty);
            if (data.Any())
            {
                var result = data.ToList();
                return Ok(result);
            }

            return BadRequest(0);
        }
        [HttpPost("contact/{name}/{info}")]
        public async Task<IActionResult> PostContact(string name, [FromQuery] string icon, string info)
        {
            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(icon) || string.IsNullOrEmpty(info))
            {
                return BadRequest(0);
            }
            await _collectionContact.InsertOneAsync(new Contact()
            {
                Name = name,
                Icon = icon,
                ContactInfo = info
            });
            return Ok(1);
        }

        [HttpPost("Post/{userName}/{numberPhone}/{email}")]
        public async Task<IActionResult> Post(string userName, string numberPhone, string email, [FromQuery] string comment)
        {
            if (string.IsNullOrEmpty(userName) || string.IsNullOrEmpty(numberPhone) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(comment))
            {
                return BadRequest(0);
            }

            await _collectionSupport.InsertOneAsync(new Support()
            {
                UserName = userName,
                NumberPhone = numberPhone,
                Email = email,
                Comment = comment,
            });
            return Ok(1);
        }

        [HttpGet("Get")]
        public async Task<IActionResult> Get()
        {
            var data = _collectionSupport.Find(Builders<Support>.Filter.Empty);
            if (data.Any())
            {
                var result = data.ToList();
                return Ok(result);
            }

            return BadRequest(0);
        }
    }
}
