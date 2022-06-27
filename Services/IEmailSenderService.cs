using CatalogoBlazorServer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CatalogoBlazorServer.Services
{
    public interface IEmailSenderService
    {
        Task SendEmailAsync(MailRequest mailrequest);
    }
}
