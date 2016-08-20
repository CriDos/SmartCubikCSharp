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

    internal abstract class BaseSceneObject : IBaseSceneObject
    {
        public long Id { get; }
        public string Name { get; set; }
        public IBaseSceneObject Parent { get; set; }

        protected BaseSceneObject(long id, [AllowNull]ISceneObject parentSceneObject = null)
        {
            Id = id;
            Parent = parentSceneObject;
        }
    }

    internal interface ISceneObject : IBaseSceneObject
    {
        float X { get; set; }
        float Y { get; set; }
        int Width { get; set; }
        int Height { get; set; }
        ElementFlags Flags { get; set; }
    }

    internal abstract class SceneObject : BaseSceneObject, ISceneObject
    {
        public float X { get; set; }
        public float Y { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public ElementFlags Flags { get; set; }

        protected SceneObject(long id, ISceneObject parentSceneObject = null) : base(id, parentSceneObject)
        {
        }
    }
}