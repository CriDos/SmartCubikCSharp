using NullGuard;

namespace SmartCubik.Engine
{
    internal class ScenePoint : BaseObject
    {
        public ScenePoint(long id, [AllowNull]BaseObject parent = null) : base(id, parent)
        {
        }
    }
}