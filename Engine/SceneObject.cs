using System;

namespace SmartCubik.Engine.Model
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

        protected SceneObject(long id, SceneObject parent = null) : base(id, parent)
        {
        }
    }
}