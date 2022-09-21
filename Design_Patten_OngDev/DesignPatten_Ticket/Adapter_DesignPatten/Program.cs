using Adapter_DesignPatten.Adapter;
using Adapter_DesignPatten.Base;
using System;
using System.Collections.Generic;

namespace Adapter_DesignPatten
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * https://viblo.asia/p/huong-dan-adapter-design-pattern-ORNZqd7bK0n
             * Adapter pattern chuyển đổi interface của một class thành interface mà client yêu cầu.
             * Adapter ở giữa gắn kết các lớp làm việc với nhau dù cho có những interface không tương thích với nhau.
             * Nó nhận 1 interface và thích ứng để trở thành 1 interface client cần sử dụng
             */

            List<IShape> shapes = new List<IShape> { new LineAdapter(new LegacyLine()), new RectangleAdapter(new LegacyRectangle()) };
            int x1 = 5, y1 = 10, x2 = -3, y2 = 2;
            shapes.ForEach(shape => shape.Draw(x1, y1, x2, y2));
        }

    }
}
