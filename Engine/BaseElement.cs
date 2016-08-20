using System;

namespace SmartCubik.Engine
{
    internal enum ElementClass
    {
        Element,
        Container
    }

    [Flags]
    internal enum ElementFlags
    {
    }

    internal interface IElement
    {
        long Id { get; }
        string Name { get; set; }
        float X { get; set; }
        float Y { get; set; }
        int Width { get; set; }
        int Height { get; set; }
        ElementClass Class { get; set; }
        ElementFlags Flags { get; set; }
    }

    internal abstract class BaseElement : IElement
    {
        public long Id { get; }
        public string Name { get; set; }
        public float X { get; set; }
        public float Y { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public ElementClass Class { get; set; }
        public ElementFlags Flags { get; set; }

        protected BaseElement(long id)
        {
            Id = id;
        }
    }
}