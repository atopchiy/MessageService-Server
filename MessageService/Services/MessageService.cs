using MessageService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;

namespace MessageService.Services
{
    public static class MessageService
    {
        public static string SaveMessage(MessageModel model)
        {
            using (var db = new MessageServiceEntities())
            {
                var isSent = true;

                var message = new Message
                {
                    Body = model.Body,
                    Subject = model.Subject,
                    Id = Guid.NewGuid().ToString()
                };              

                foreach (var recipient in model.Recipients)
                {
                    var dbRecipient = db.Recipient.FirstOrDefault(x => x.Id == recipient);
                    if (dbRecipient != null)
                    {
                        db.MessageToRecipient.Add(new MessageToRecipient { Message = message, Recipient = dbRecipient });

                        if (SendNotification(recipient, model.Body))
                        {
                            isSent = false;
                        }
                    }
                }

                message.IsSent = isSent;

                db.Message.Add(message);

                db.SaveChanges();

                return message.Id;
            }
        }

        public static bool SendNotification(string recipient, string body)
        {
            // imitate notification service call
            var rnd = new Random();
            return rnd.Next(0, 100) % 7 == 0;
        }
    }
}