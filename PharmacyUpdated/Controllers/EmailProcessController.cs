using MailKit.Net.Smtp;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MimeKit;
using PharmacyUpdated.Models;
using System;
using System.Collections.Generic;

namespace PharmacyUpdated.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmailProcessController : ControllerBase
    {
        [HttpPost("EmailSendings")]
        public IActionResult EmailSending(List<FinalDb> data_table)
        {
            double? totalamount = 0;
            string textBody = "<p> Hello Doctor, </p> <p>Thank you for ordering from Pharmacy Management system.</p> <p>We’re happy to let you know that we’ve received your order.</p> <p>Once your order is approved by admin, we will send you an email " +
                "with a tracking number and link so you can see the movement of your order.</p>";
            textBody += " <table border=" + 1 + " cellpadding=" + 0 + " cellspacing=" + 0 + " width = " + 400 + "><tr bgcolor='#4da6ff'><td><b>Drug Name</b></td> <td> <b> Drug Quantity</b> </td> <td> <b> Unit Price</b> </td> <td> <b>Total Amount</b> </td></tr>";
            for (int loopCount = 0; loopCount < data_table.Count; loopCount++)
            {
                textBody += "<tr><td>" + data_table[loopCount].DrugName + "</td><td> " + data_table[loopCount].Quantity + "</td><td> " + data_table[loopCount].Price + "</td><td> " + (data_table[loopCount].TotalPrice) + "</td> </tr>";
                totalamount += data_table[loopCount].Quantity* data_table[loopCount].Price;
            }
            textBody += "</table> <br>";
            textBody += "<strong>Order Date :</strong>";
            textBody += data_table[0].OrderDate;
            textBody += "<br><strong>Total Order Amount :</strong>";
            textBody += totalamount;
            textBody += "<br><i>If you have any questions, contact us here on <b>vtu14899@veltech.edu.in</b>! " +
                "We are here to help you! </i>";


            var message = new MimeMessage();
            message.From.Add(new MailboxAddress("RutujaPatil", "vtu14899@veltech.edu.in"));
            message.To.Add(new MailboxAddress("doctor", data_table[0].UserEmail));
            message.Subject = "Order Placed - Pharmacy Management System";
            message.Body = new TextPart("html")
            {
                Text = textBody
            };
            using (var client = new SmtpClient())
            {
                client.Connect("smtp.gmail.com", 587, false);
                client.Authenticate("vtu14899@veltech.edu.in", "14899@veltech");
                client.Send(message);
                client.Disconnect(true);
            }

            return Ok("Email sent Successfully");
        }
        [HttpPost("AdminEmail/OrderConfirmation")]
        public IActionResult AdminEmailSending(FinalDb data_table)
        {
            double? totalamount = 0;
            string textBody = "<p> Hello Doctor, </p> <p>Thank you for ordering from Pharmacy Management system.</p> <p>We’re happy to let you know that we’ve received your order.</p> <p>Your order was approved by admin, and you will receive your order shortly.</p>";
            textBody += " <table border=" + 1 + " cellpadding=" + 0 + " cellspacing=" + 0 + " width = " + 400 + "><tr bgcolor='#4da6ff'><td><b>Drug Name</b></td> <td> <b> Drug Quantity</b> </td> <td> <b> Total Amount</b></tr>";

            textBody += "<tr><td>" + data_table.DrugName + "</td><td> " + data_table.Quantity + "</td><td> " + data_table.TotalPrice  + "</td> </tr>";
            

            textBody += "</table> <br>";
           
           
            
            textBody += "<br><i>If you have any questions, contact us here on <b>vtu14218@veltech.edu.in</b>! " +
                "We are here to help you! </i>";


            var message = new MimeMessage();
            message.From.Add(new MailboxAddress("RutujaPatil", "vtu14899@veltech.edu.in"));
            message.To.Add(new MailboxAddress("doctor", data_table.UserEmail));
            message.Subject = "Order Confirmed - Pharmacy Management System";
            message.Body = new TextPart("html")
            {
                Text = textBody
            };
            using (var client = new SmtpClient())
            {
                client.Connect("smtp.gmail.com", 587, false);
                client.Authenticate("vtu14899@veltech.edu.in", "14899@veltech");
                client.Send(message);
                client.Disconnect(true);
            }

            return Ok("Email sent Successfully");
        }
    }
}
