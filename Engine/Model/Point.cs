using NullGuard;

namespace SmartCubik.Engine.Model
{
    internal class Point : BaseObject
    {
        public Point(long id, [AllowNull]BaseObject parent = null) : base(id, parent)
        {
        }
    }
}