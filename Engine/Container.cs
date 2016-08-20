using System.Collections.Generic;

namespace SmartCubik.Engine
{
    internal class Container : BaseElement
    {
        private readonly List<IElement> _elementList = new List<IElement>();
        private readonly List<IElement> _pointList = new List<IElement>();
        private readonly List<IElement> _propList = new List<IElement>();

        public Container(long id) : base(id)
        {
        }
    }
}