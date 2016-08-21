using NullGuard;

namespace SmartCubik.Engine
{
    internal abstract class BaseObject
    {
        public long Id { get; }
        public BaseObject Parent { get; set; }
        public string Name { get; set; }

        protected BaseObject(long id, [AllowNull]BaseObject parent = null)
        {
            Id = id;
            Parent = parent;
        }
    }
}
