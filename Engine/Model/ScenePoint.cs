using NullGuard;

namespace SmartCubik.Engine.Model
{
    internal class ScenePoint : BaseSceneObject
    {
        public ScenePoint(long id, [AllowNull]BaseSceneObject parent = null) : base(id, parent)
        {
        }
    }
}