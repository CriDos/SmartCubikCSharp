using NullGuard;

namespace SmartCubik.Engine
{
    internal class SceneProperty : BaseObject
    {
        public SceneProperty(long id, [AllowNull]BaseObject parent = null) : base(id, parent)
        {
        }
    }
}