using System;
using NullGuard;

namespace SmartCubik.Engine
{
    [Flags]
    internal enum SceneObjectFlags
    {
    }

    internal abstract class ModelObject : BaseObject
    {
        public float X { get; set; }
        public float Y { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public SceneObjectFlags Flags { get; set; }

        protected ModelObject(long id, [AllowNull]BaseObject parent = null) : base(id, parent)
        {
        }
    }
}