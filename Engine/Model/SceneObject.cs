using System;
using NullGuard;

namespace SmartCubik.Engine.Model
{
    [Flags]
    internal enum ObjectFlags
    {
    }

    internal abstract class SceneObject : BaseSceneObject
    {
        public float X { get; set; }
        public float Y { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public ObjectFlags Flags { get; set; }

        protected SceneObject(long id, [AllowNull]BaseSceneObject parent = null) : base(id, parent)
        {
        }
    }
}