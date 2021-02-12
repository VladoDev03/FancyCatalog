﻿using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace ConsoleVersion.Utils
{
    public static class ExceptionsText
    {
        // Register and login exceptions
        public const string NotUserLoggedIn = "You cannot logout before logging in!";
        public const string NotExistingUser = "User with this username does not exist!";
        public const string AlreadyLoggedIn = "You are already logged in!";
        public const string WrongPassword = "Invalid username or password!";
        public const string TakenUsername = "This username is taken!";
        public const string LogInCannotRegister = "Log out before register new profile!";

        // Password exceptions
        public const string ShorterPassword = "Password must be atleast {0} characters long!";
        public const string LessUpperCase = "Password must contain at least {0} upper case letter!";
        public const string LessLowerCase = "Password must contain at least {0} lower case letter!";
        public const string LessDigits = "Password must contain at least {0} digit!";
        public const string LessSymbols = "Password must contain at least {0} symbol!";

        // User and author exceptions
        public const string FirstNameException = "First name must be atleast {0} characters long!";
        public const string MiddleNameException = "Middle name must be atleast {0} characters long!";
        public const string LastNameException = "Last name must be atleast {0} characters long!";

        // User exceptions
        public const string UsernameException = "Username must be atleast {0} characters long!";
        public const string AgeException = "You have to be at least {0} years old!";

        // Book exceptions
        public const string TitleException = "Title must be at least {0} characters long!";
        public const string GenreException = "Genre must be at least {0} characters long!";
        public const string AuthorException = "Book must have an author!";

        // Contact exceptions
        public const string NotValidEmail = "This email is invalid, try with another one!";
        public const string NotValidPhone = "This phone number is invalid, try with another one!";
    }
}
