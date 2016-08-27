using NullGuard;

namespace SmartCubik.Engine.Model
{
    internal abstract class BaseObject
    {
        public BaseObject Parent { get; set; }
        public string Name { get; set; }

        protected BaseObject([AllowNull]BaseObject parent = null)
        {
            Parent = parent;
        }
    }
}