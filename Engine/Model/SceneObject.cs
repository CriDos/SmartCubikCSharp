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
        public int Id { get; }
        public float X { get; set; }
        public float Y { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public ObjectFlags Flags { get; set; }
        public Scene Scene { get; }

        protected SceneObject(int id, Scene scene, [AllowNull]BaseObject parent = null) :
            base(parent)
        {
            Id = id;
            Scene = scene;
        }
        protected SceneObject(Scene scene, [AllowNull]BaseObject parent = null) :
            base(parent)
        {
            Id = scene.GenId();
            Scene = scene;
        }

    }
}