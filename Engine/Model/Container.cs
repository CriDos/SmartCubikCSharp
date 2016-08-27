using System.Collections.Generic;
using NullGuard;

namespace SmartCubik.Engine.Model
{
    internal class Container : Object
    {
        private readonly List<Object> _elementList = new List<Object>();
        private readonly List<Point> _pointList = new List<Point>();
        private readonly List<Property> _propertyList = new List<Property>();

        public Container(long id, [AllowNull]BaseObject parent = null) : base(id, parent)
        {

        }
    }
}