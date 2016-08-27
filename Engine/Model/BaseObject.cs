using NullGuard;

namespace SmartCubik.Engine.Model
{
    internal enum ObjectClass
    {
        Object,
        Container,
        Element,
        Point,
        Property
    }

    internal abstract class BaseObject
    {
        public BaseObject Parent { get; set; }
        public string Name { get; set; }

        public ObjectClass Class { get; }

        protected BaseObject(ObjectClass @class, [AllowNull]BaseObject parent = null)
        {
            Class = @class;
            Parent = parent;
        }
    }
}