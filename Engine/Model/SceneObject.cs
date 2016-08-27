using System;
using NullGuard;

namespace SmartCubik.Engine.Model
{
    [Flags]
    internal enum ObjectFlags
    {
    }

    internal abstract class SceneObject : BaseObject
    {
        public long Id { get; }
        public float X { get; set; }
        public float Y { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public ObjectFlags Flags { get; set; }
        public Scene Scene { get; }

        protected SceneObject(long id, Scene scene, [AllowNull]BaseObject parent = null) : base(parent)
        {
            Id = id;
            Scene = scene;
        }
    }
}