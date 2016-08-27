using NullGuard;

namespace SmartCubik.Engine.Model
{
    internal class ScenePoint : BaseObject
    {
        public ScenePoint([AllowNull]BaseObject parent = null)
            : base(ObjectClass.Point, parent)
        {
        }
    }
}