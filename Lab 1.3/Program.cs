using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace Lab_1._3
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 2)
            {

                SmtpClient C = new SmtpClient("mail.univ.net.ua");
                C.Port = 25;
                C.Credentials = new NetworkCredential("CE2020test", "1q2w3e4r5t");
                C.EnableSsl = true;
                string text = DateTime.Now.ToString() + "\nTymofii Parfeniuk";
                C.Send(new MailMessage("CE2020test@univ.net.ua", args[0], args[1], text));
            }
            else
            {
                Console.WriteLine("SYNTAX: mail-1 <ToAddr> <Theme>");
            }
        }
    }
}
