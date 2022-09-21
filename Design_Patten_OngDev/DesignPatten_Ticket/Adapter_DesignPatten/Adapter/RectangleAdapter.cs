using Adapter_DesignPatten.Base;
using System;

namespace Adapter_DesignPatten.Adapter
{
    internal class RectangleAdapter : IShape
    {
        private readonly LegacyRectangle _legacyrectangle;
        public RectangleAdapter(LegacyRectangle legacyRectangle)
        {
            _legacyrectangle = legacyRectangle;
        }

        void IShape.Draw(int x1, int y1, int x2, int y2)
        {
            int x = Math.Min(x1, x2);
            int y = Math.Min(y1, y2);
            int w = Math.Abs(x2 - x1);
            int h = Math.Abs(y2 - y1);

            _legacyrectangle.Draw(x, y, w, h);
        }
    }
}