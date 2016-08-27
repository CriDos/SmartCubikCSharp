using NullGuard;

namespace SmartCubik.Engine.Model
{
    internal abstract class BaseSceneObject
    {
        public long Id { get; }
        public BaseSceneObject Parent { get; set; }
        public string Name { get; set; }

        protected BaseSceneObject(long id, [AllowNull]BaseSceneObject parent = null)
        {
            Id = id;
            Parent = parent;
        }
    }
}