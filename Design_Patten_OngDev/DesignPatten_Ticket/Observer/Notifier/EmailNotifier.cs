using System;
using System.Collections.Generic;
using System.Text;

namespace Observer.Notifier
{
    using Observer.Base;
    internal class EmailNotifier : Observer
    {
        public EmailNotifier(Subject subject)
        {
            this.subject = subject; // this.subject trong TH này là của Observer
            this.subject.AttachObserver(this);   // Đây chính là ta thêm một cái Observer vào một Subject
        }
        public override void Notify(Subject subject, object arg)
        {
            //Trong trường hợp này chúng ta cần check xem cái subject nà có phải là VideoData hay không
            if (subject is VideoData videoData)  // Nó sẽ check nếu là VideoData thì nó sẽ tạo ra một biến temp videoData
            {
                Console.WriteLine(
                    String.Format($"Notify all subcribers via EMAIL with data " +
                    "\n\tName: {0}" +
                    "\n\tDescription: {1}" +
                    "\n\tFile Name: {2}",
                    videoData.GetTitle(), 
                    videoData.GetDescription(), 
                    videoData.GetFileName()));
            }
        }
    }
}
