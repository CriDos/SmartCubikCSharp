using System.Collections.Generic;
using NullGuard;

namespace SmartCubik.Engine
{
    internal class ModelContainer : ModelObject
    {
        private readonly List<ModelObject> _elementList = new List<ModelObject>();
        private readonly List<ModelPoint> _pointList = new List<ModelPoint>();
        private readonly List<ModelProperty> _propertyList = new List<ModelProperty>();

        public ModelContainer(long id, [AllowNull]BaseObject parent = null) : base(id, parent)
        {

        }
    }
}