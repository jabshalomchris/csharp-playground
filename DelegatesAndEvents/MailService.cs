using DelegatesAndEvents;

public class MailService
{
    public void OnVideoEncoded(object source, VideoEventArgs args)
    {
        Console.WriteLine($"Mail Service: Sending an email..... {args.Video.Title}");
    }
}