﻿using ConsoleVersion.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleVersion.Services
{
    public class UserBookServices
    {
        private FancyLibraryContext db;

        public UserBookServices(FancyLibraryContext db)
        {
            this.db = db;
        }

        public void AddBookToUser(User user, Book book)
        {
            db.UsersBooks.Add(new UserBook
            {
                UserId = user.Id,
                BookId = book.Id
            });

            db.SaveChanges();
        }

        public void RemoveBookFromUser(User user, Book book)
        {
            db.UsersBooks.Remove(new UserBook
            {
                UserId = user.Id,
                BookId = book.Id
            });

            db.SaveChanges();
        }

        public List<Book> GetAllUserBooks(User user)
        {
            List<int> booksIds = db.UsersBooks
                .Where(ub => ub.UserId == user.Id)
                .Select(ub => ub.BookId)
                .ToList();

            List<Book> books = new List<Book>();

            foreach (int id in booksIds)
            {
                foreach (Book book in db.Books)
                {
                    if (id == book.Id)
                    {
                        books.Add(book);
                    }
                }
            }

            return books;
        }
    }
}
