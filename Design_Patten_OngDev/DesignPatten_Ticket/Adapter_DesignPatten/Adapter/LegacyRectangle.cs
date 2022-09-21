using System;

namespace Adapter_DesignPatten.Adapter
{
    internal class LegacyRectangle
    {
        internal void Draw(int x, int y, int w, int h)
        {
            Console.WriteLine($"Drawing rectangle {x} {y} {w} {h}");
        }
    }
}