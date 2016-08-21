using NullGuard;
using System;

namespace SmartCubik.Engine.Model
{
    [Flags]
    internal enum SceneObjectFlags
    {
    }

    internal abstract class BaseSceneObject
    {
        public long Id { get; }
        public BaseSceneObject Parent { get; set; }
        public string Name { get; set; }

        protected BaseSceneObject(long id, [AllowNull]BaseSceneObject parentSceneObject = null)
        {
            Id = id;
            Parent = parentSceneObject;
        }
    }

    internal abstract class SceneObject : BaseSceneObject
    {
        public float X { get; set; }
        public float Y { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }

        protected SceneObject(long id, SceneObject parentSceneObject = null) : base(id, parentSceneObject)
        {
        }
    }
}