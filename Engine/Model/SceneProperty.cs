using NullGuard;

namespace SmartCubik.Engine.Model
{
    internal class SceneProperty : BaseSceneObject
    {
        public SceneProperty(long id, [AllowNull]BaseSceneObject parent = null) : base(id, parent)
        {
        }
    }
}