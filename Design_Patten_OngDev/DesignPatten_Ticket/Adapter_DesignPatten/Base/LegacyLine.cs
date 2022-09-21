using System;

namespace Adapter_DesignPatten.Base
{
    internal class LegacyLine
    {
        internal void Draw(int x1, int y1, int x2, int y2)
        {
            Console.WriteLine($"Drawing line: {x1} {y1} {x2} {y2}");
        }
    }
}