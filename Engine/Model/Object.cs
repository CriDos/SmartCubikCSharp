using System;
using NullGuard;

namespace SmartCubik.Engine.Model
{
    [Flags]
    internal enum ModelObjectFlags
    {
    }

    internal abstract class Object : BaseObject
    {
        public float X { get; set; }
        public float Y { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public ModelObjectFlags Flags { get; set; }

        protected Object(long id, [AllowNull]BaseObject parent = null) : base(id, parent)
        {
        }
    }
}