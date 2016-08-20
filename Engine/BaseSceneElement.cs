using NullGuard;
using System;

namespace SmartCubik.Engine
{
    [Flags]
    internal enum ElementFlags
    {
    }

    internal interface IBaseSceneObject
    {
        long Id { get; }
        string Name { get; set; }
        IBaseSceneObject Parent { get; set; }
    }

    internal interface ISceneObject : IBaseSceneObject
    {
        float X { get; set; }
        float Y { get; set; }
        int Width { get; set; }
        int Height { get; set; }
        ElementFlags Flags { get; set; }
    }

    internal abstract class AbstractSceneObject : ISceneObject
    {
        public long Id { get; }
        public IBaseSceneObject Parent { get; set; }
        public string Name { get; set; }
        public float X { get; set; }
        public float Y { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public ElementFlags Flags { get; set; }

        protected AbstractSceneObject(long id, [AllowNull]ISceneObject parentSceneObject = null)
        {
            Id = id;
            Parent = parentSceneObject;
        }
    }
}