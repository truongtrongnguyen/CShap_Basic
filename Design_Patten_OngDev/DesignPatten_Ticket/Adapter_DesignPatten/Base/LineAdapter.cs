namespace Adapter_DesignPatten.Base
{
    internal class LineAdapter : IShape
    {
        private readonly LegacyLine _legacyline;
        public LineAdapter(LegacyLine legacyline)
        {
            _legacyline = legacyline;
        }
        public void Draw(int x1, int y1, int x2, int y2)
        {
            _legacyline.Draw(x1, y1, x2, y2);
        }
    }
}