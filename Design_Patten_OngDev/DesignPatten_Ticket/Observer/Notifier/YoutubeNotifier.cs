using System;
using System.Collections.Generic;
using System.Text;

namespace Observer.Notifier
{
    using Observer.Base;
    internal class YoutubeNotifier:Observer
    {
        public YoutubeNotifier(Subject subject)
        {
            this.subject = subject;
            this.subject.AttachObserver(this);
        }
        public override void Notify(Subject subject, object arg)
        {
            //Trong trường hợp này chúng ta cần check xem cái subject nà có phải là VideoData hay không
            if (subject is VideoData videoData)  // Nó sẽ check nếu là VideoData thì nó sẽ tạo ra một biến temp videoData
            {
                Console.WriteLine(
                    String.Format($"Notify all subcribers via YOUTUBE with data " +
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
