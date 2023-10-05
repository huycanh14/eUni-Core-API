using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http;


namespace eUni_Core_NetCore.Shared.Services.Email;

public class MailRequest
{
    [EmailAddress]
    public string From { get; set; } = null!;

    [EmailAddress]
    public string ToAddress { get; set; } = null!;

    public IEnumerable<string> ToAddresses { get; set; } = new List<string>();

    [Required]
    public string Subject { get; set; } = null!;

    [Required]
    public string Body { get; set; } = null!;

    public IFormFileCollection? Attachments { get; set; } = null;
}
