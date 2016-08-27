using System.Collections.Generic;
using NullGuard;

namespace SmartCubik.Engine.Model
{
    internal class Element : Object
    {
        private readonly List<Point> _pointList = new List<Point>();
        private readonly List<Property> _propertyList = new List<Property>();

        public Element(long id, [AllowNull]BaseObject parent = null) : base(id, parent)
        {
        }
    }
}