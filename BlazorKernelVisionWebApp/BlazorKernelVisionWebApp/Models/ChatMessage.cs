namespace BlazorKernelVisionWebApp.Models
{
    public class ChatMessage
    {
        public string Text { get; set; }
        public bool IsUserMessage { get; set; }

        //Constructor for the ChatMessage class
        //isUserMessage is a boolean that indicates whether the message is from the user or the bot
        public ChatMessage(string text, bool isUserMessage)
        {
            Text = text;
            IsUserMessage = isUserMessage;
        }

    }
}
