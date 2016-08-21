using NullGuard;
using System;

namespace SmartCubik.Engine
{
    [Flags]
    internal enum SceneObjectFlags
    {
    }

    internal enum ClassSceneObject
    {
        Element,
        Container,
        Point,
        Line
    }

    internal abstract class BaseSceneObject
    {
        public long Id { get; }
        public string Name { get; set; }
        public BaseSceneObject Parent { get; set; }

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
        public SceneObjectFlags Flags { get; set; }

        protected SceneObject(long id, SceneObject parentSceneObject = null) : base(id, parentSceneObject)
        {
        }
    }
}