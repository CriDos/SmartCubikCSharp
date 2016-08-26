using System.Collections.Generic;
using NullGuard;

namespace SmartCubik.Engine
{
    internal class ModelElement : ModelObject
    {
        private readonly List<ModelPoint> _pointList = new List<ModelPoint>();
        private readonly List<ModelProperty> _propertyList = new List<ModelProperty>();

        public ModelElement(long id, [AllowNull]BaseObject parent = null) : base(id, parent)
        {
        }
    }
}