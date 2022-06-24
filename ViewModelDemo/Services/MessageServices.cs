using System.Collections.Generic;
using ViewModelDemo.Models;

namespace ViewModelDemo.Services
{
    public static  class MessageServices
    {
        static List<Messages> messages = new List<Messages>();
        public static void AddMessages()
        {
            Messages message = new Messages();
            message.Allstudents = "overview of the campus students";
            message.PartialStudents = "overview van partialStudents";
            message.ForeignStudents = "overview van ForeignStudents";
            messages.Add(message);

           
        }
        public static List<Messages> GetAllMessages()
        {
            AddMessages();
            return messages;
        }
    }
}
