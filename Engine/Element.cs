﻿using System.Collections.Generic;

namespace SmartCubik.Engine
{
    internal class Element : BaseElement
    {
        private readonly List<IElement> _pointList = new List<IElement>();
        private readonly List<IElement> _propList = new List<IElement>();

        public Element(long id) : base(id)
        {
        }
    }
}