﻿using ConsoleVersion.Models;
using ConsoleVersion.Services;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Tests.ServicesTests
{
    public class SetAgeTests
    {
        private UserServices userServices;
        private FancyLibraryContext db;

        [SetUp]
        public void Setup()
        {
            db = new FancyLibraryContext();
            userServices = new UserServices(db);
        }

        [Test]
        public void IsMethodSettingCorrectAge()
        {
            User user = new User
            {
                Username = "vladsto",
                Password = "P$rola12",
                FirstName = "vladko",
                LastName = "Sladko",
                Birthday = DateTime.Parse("2003-05-20")
            };

            userServices.SetAge(user);

            Assert.That(user.Age, Is.EqualTo(17));
        }
    }
}
