using NullGuard;

namespace SmartCubik.Engine.Model
{
    internal class Property : BaseObject
    {
        public Property(long id, [AllowNull]BaseObject parent = null) : base(id, parent)
        {
        }
    }
}