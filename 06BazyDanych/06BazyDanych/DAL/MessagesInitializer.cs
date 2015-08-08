using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using _06BazyDanych.Models;

namespace _06BazyDanych.DAL
{
    public class MessagesInitializer : DropCreateDatabaseAlways<MessagesContext>
    {
        protected override void Seed(MessagesContext context)
        {
            var messages = new List<MessageDetails>()
            {
                new MessageDetails(){emailAuthor = "Random@Author.com", subject = "Random subject",
                                     messageDetails = "Some message from Random Author"},
                new MessageDetails(){emailAuthor = "Jan@Kowalski.pl", subject = "Hello",
                                     messageDetails = "There is example of message"}
            };

            foreach (var item in messages)
            {
                context.Messages.Add(item);
            }

            context.SaveChanges();
        }
    }
}