using NullGuard;

namespace SmartCubik.Engine
{
    internal class ModelPoint : BaseObject
    {
        public ModelPoint(long id, [AllowNull]BaseObject parent = null) : base(id, parent)
        {
        }
    }
}