using System;
using System.Collections.Generic;
using System.Text;

namespace Observer
{
    using Observer.Base;
    using Observer.Notifier;
    internal class VideoData:Subject
    {
        #region Private Properties
        private string _title;
        private string _description;
        private string _filename;
        //private readonly EmailNotifier _emailNotifier;
        //private readonly PhoneNotifier _phoneNotifier;
        //private readonly YoutubeNotifier _youtubeNotifier;
        #endregion

        #region GetSetProperties
        public string GetTitle()
        {
            return _title;
        }
        public void SetTitle(string value)
        {
            _title = value;
            VideoDataChanged();
        }
        public string GetDescription()
        {
            return _description;
        }
        public void SetDecription(string value)
        {
            _description = value;
            VideoDataChanged();
        }
        public string GetFileName()
        {
            return _filename;
        }
        public void SetFileName(string value)
        {
            _filename = value;
            VideoDataChanged();
        }
        #endregion


        public void VideoDataChanged()
        {
            //NotifierObserver chỗ này là của Subject vì nó được kế thừa
            NotifierObserver(this, null);// this chỗ này là bao gồm instance của VideoData(các properties)
                                         // và nó sẽ check thử xem nó có phải là VideoData hay không
        }

    }
}
