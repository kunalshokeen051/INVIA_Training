using MailKit;
using MailKit.Net.Imap;
using MimeKit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class MailBoxController : Controller
    {
        //All the data to be needed in our action method
        private const string GmailEmail = "kunalshokeen051@gmail.com";
        private const string GmailPassword = "qcui ztyn doln lnmj";
        private const string GmailImapServer = "imap.gmail.com";
        private const int GmailImapPort = 993;

        public ActionResult MailInbox()
        {
            // below we are creating a list of type MIME message to store  all the messages
            List<MimeMessage> messages = new List<MimeMessage>();

            using (var client = new ImapClient())
            {
                // First we are making a object 'Client' of ImapClient() class and then using its connect function connecting to the IMAP Server.
                client.Connect(GmailImapServer, GmailImapPort, true);

                // Now after connecting we are going to authenticate with out gmailID and password
                client.Authenticate(GmailEmail, GmailPassword);

                // Accessing the data in our Inbox folder
                var inbox = client.Inbox;
                inbox.Open(FolderAccess.ReadOnly);

                //Storing all the inbox messages to our list
                for (int i = 0; i < inbox.Count; i++)
                {
                    var message = inbox.GetMessage(i);
                    messages.Add(message);
                }

                // Disconnecting from the IMAP server
                client.Disconnect(true);
            }

            // Pass the list of messages to the view
            return View(messages);
        }
    }
}



/*
  
 POP (Post Office Protocol) and IMAP (Internet Message Access Protocol) are two different
 email protocols used to retrieve email messages from a mail server to a client device

POP: POP is designed to download email messages from the server to the client device.
It typically does this by moving or copying messages from the server to the client, and by default, 
it often deletes messages from the server once they are downloaded. This means that if you access your email from multiple devices,
you may not have consistent access to all your messages unless you configure your email client to leave a copy on the server.

IMAP: IMAP, on the other hand, allows you to access your email messages directly from the server without necessarily downloading them to your device.
Messages are stored on the server, and any changes (read, delete, move, etc.) made on one device are reflected on all other devices 
that connect to the same account. This makes IMAP more suitable for users who access their email from multiple devices.
 
 
 */