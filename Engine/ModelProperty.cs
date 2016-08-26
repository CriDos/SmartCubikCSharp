using NullGuard;

namespace SmartCubik.Engine
{
    internal class ModelProperty : BaseObject
    {
        public ModelProperty(long id, [AllowNull]BaseObject parent = null) : base(id, parent)
        {
        }
    }
}