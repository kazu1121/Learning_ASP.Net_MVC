using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using _07Infrastruktura.Models;

namespace _07Infrastruktura.DAL
{
    public class MessagesInitializer : DropCreateDatabaseAlways<MessagesContext>
    {
        protected override void Seed(MessagesContext context)
        {
            var messages = new List<MessageDetails>()
            {
                new MessageDetails()
                {
                    authorEmail = "Rychu@Pompka.com",
                    subject = "Oddawej pisiont złoty",
                    messageDetails = "Wiadomość od Rycha"
                },
                new MessageDetails()
                {
                    authorEmail = "Andrzej@Mleczko.fc",
                    subject = "Przykładowy temat",
                    messageDetails = "Jakaś wiadomość od Andrzeja"
                }
            };

            foreach (var item in messages)
                context.Messages.Add(item);

            context.SaveChanges();

        }
    }
}