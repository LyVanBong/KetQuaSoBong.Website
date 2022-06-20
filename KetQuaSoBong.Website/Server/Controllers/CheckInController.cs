﻿using KetQuaSoBong.Website.Shared.CheckIn;
using KetQuaSoBong.Website.Shared.Configurations;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;

namespace KetQuaSoBong.Website.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CheckInController : ControllerBase
    {
        private IMongoCollection<CheckInModel> _collectionCheckIn;
        public CheckInController()
        {
            MongoClient mongo = new MongoClient(AppConstants.ConnectionStringMongoDb);
            IMongoDatabase database = mongo.GetDatabase("CheckIn");
            _collectionCheckIn = database.GetCollection<CheckInModel>("Users");
        }
        [HttpPost]
        public async Task<IActionResult> Post(CheckInModel checkIn)
        {
            if (checkIn == null) return BadRequest(0);
            var filter = Builders<CheckInModel>.Filter.Eq("UserName", checkIn.UserName);
            var result = _collectionCheckIn.Find(filter);
            if (!result.Any())
            {
                await _collectionCheckIn.InsertOneAsync(checkIn);
            }
            return Ok(1);
        }
    }
}
