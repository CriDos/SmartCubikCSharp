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

        protected SceneObject(long id, Scene scene, ObjectClass @class, [AllowNull]BaseObject parent = null) :
            base(@class, parent)
        {
            Id = id;
            Scene = scene;
        }
        protected SceneObject(Scene scene, ObjectClass @class, [AllowNull]BaseObject parent = null) :
            base(@class, parent)
        {
            Id = scene.GenElementId();
            Scene = scene;
        }
    }
}