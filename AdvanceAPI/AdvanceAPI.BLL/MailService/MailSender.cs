using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net.Mime;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace AdvanceAPI.BLL.MailService
{
	public class MailSender
	{
		private readonly SmtpSettings _smtpSettings;

		public MailSender(IOptions<SmtpSettings> smtpSettings)
		{
			_smtpSettings = smtpSettings.Value;
		}

		public void SendEmail(string toAddresss, string subject, string body, string attachmentPath=null)
		{
			var smtpClient = new SmtpClient("smtp.office365.com")
			{
				Port = 587,
				Credentials = new NetworkCredential(_smtpSettings.Username, _smtpSettings.Password),
				EnableSsl = true,
			};

			var fromAddress = new MailAddress(_smtpSettings.Username, "Avans Yönetim");

			var toAddress = new MailAddress(toAddresss);

			var mailMessage = new MailMessage(fromAddress, toAddress)
			{
				Subject = subject,
				Body = body,
				IsBodyHtml = true,
			};

			if (!string.IsNullOrEmpty(attachmentPath) && File.Exists(attachmentPath))
			{
				var attachment = new Attachment(attachmentPath, MediaTypeNames.Application.Octet);
				ContentDisposition disposition = attachment.ContentDisposition;
				disposition.CreationDate = File.GetCreationTime(attachmentPath);
				disposition.ModificationDate = File.GetLastWriteTime(attachmentPath);
				disposition.ReadDate = File.GetLastAccessTime(attachmentPath);
				mailMessage.Attachments.Add(attachment);
			}

			smtpClient.Send(mailMessage);
		}
	}
}
