using DelegatesAndEvents;

Video video = new Video() { Title = "Skyfall" };
VideoEncoder encoder = new VideoEncoder(); // publisher
MailService mailService = new MailService(); // subscriber
MessageService messageService = new MessageService(); //subscriber

encoder.VideoEncoded += mailService.OnVideoEncoded;
encoder.VideoEncoded += messageService.OnVideoEncoded;

encoder.Encode(video);
