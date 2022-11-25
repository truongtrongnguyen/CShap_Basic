using Observer.Notifier;
using System;

namespace Observer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // LINK WEB: https://viblo.asia/p/design-pattern-observer-V3m5WO8W5O7
            //LINK YOUTUBE: https://www.youtube.com/watch?v=qHlSHoOCfbM&list=PLoaAbmGPgTSOrVuxwbnDJ14U9J6CXJXUk&index=5
            // TRUY CẬP DIAGRAM: https://app.diagrams.net/#G1Hs5u44P35AQ0ukLooNIGrMCswV0Az2W_
            /*
             * - Subject là lớp cha của VideoData, có nhiệm vụ thêm xóa và xuất 
             * - Observer là lớp cha của các đối tượng notifier, các lớp con phải implement funtion của lớp cha này
             * Observer Pattern được áp dụng khi:
             *     + Sự thay đổi trạng thái ở 1 đối tượng có thể được thông báo đến các đối tượng khác mà không phải giữ chúng liên kết quá chặt chẽ
             *     + Cần mở rộng dự án với ít sự thay đổi nhất.
             */



            // Khi ta thông báo cho đối tượng videoData thì nó sẽ cập nhật thông báo đến tấc cả các phần tử khác có liên quan đến videoData
            var videoData = new VideoData();

            _ = new EmailNotifier(videoData);   //Tạo ra một đối tượng nhưng không lưu lại, nó chỉ được thực hiện một lần ngay từ khi tạo nó
            _ = new PhoneNotifier(videoData);
            var youtubeNotifier= new YoutubeNotifier(videoData);

            videoData.SetTitle("Observer Design Patten");

            videoData.DetachObserver(youtubeNotifier);  // Tiến hành xóa đi một phần tử
            Console.WriteLine("============================================");
            videoData.SetDecription("OngDev is Video");
            _ = new FaceBookNotifier(videoData);
            Console.WriteLine("============================================");
            videoData.SetFileName("Very good");

            Console.ReadKey();
        }
    }
}
