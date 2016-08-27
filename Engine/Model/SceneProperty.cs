using NullGuard;

namespace SmartCubik.Engine.Model
{
    internal class SceneProperty : BaseObject
    {
        public SceneProperty([AllowNull]BaseObject parent = null) :
            base(ObjectClass.Property, parent)
        {
        }
    }
}