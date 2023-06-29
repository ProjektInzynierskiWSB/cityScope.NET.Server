﻿using Bogus;
using cityScope.NET.Server.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cityScope.NET.Server.Persistence.DummyData
{
    public class DataGenerator
    {
        public List<Announcement> Announcements = new();
        public List<User> Users = new();
        public DataGenerator()
        {
            Seed();
        }
        private void Seed()
        {
            string locale = "pl";
            int id = 1;
            var userGenerator = new Faker<User>(locale)
                .RuleFor(u => u.Id, _ => 1)
                .RuleFor(u => u.Email, f => f.Person.Email.ToLower())
                .RuleFor(u => u.PasswordHash, new byte[2] { 1, 2 })
                .RuleFor(u => u.PasswordSalt, new byte[2] { 1, 2 });
            var listUsers = userGenerator.Generate(1);
            Users.AddRange(listUsers);


            var annoucementGenerator = new Faker<Announcement>(locale)
                .RuleFor(a => a.Id, _ => id++)
                .RuleFor(a => a.Title, f => f.Commerce.ProductName())
                .RuleFor(a => a.Description, f => f.Commerce.ProductDescription())
                .RuleFor(a => a.LastModifiedDate, f => DateTime.Now)
                .RuleFor(a => a.UserId, _ => 1)
                .RuleFor(a => a.Price, f => Math.Round(f.Random.Decimal(10,10000),2));
            var listAnnouncement = annoucementGenerator.Generate(10);
            Announcements.AddRange(listAnnouncement);
        }
    }
}
