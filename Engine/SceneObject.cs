using System;
using NullGuard;

namespace SmartCubik.Engine
{
    [Flags]
    internal enum SceneObjectFlags
    {
    }

    internal abstract class SceneObject : BaseObject
    {
        public float X { get; set; }
        public float Y { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public SceneObjectFlags Flags { get; set; }

        protected SceneObject(long id, [AllowNull]BaseObject parent = null) : base(id, parent)
        {
        }
    }
}