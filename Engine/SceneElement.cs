using System.Collections.Generic;

namespace SmartCubik.Engine
{
    internal class SceneObject : AbstractSceneObject
    {
        private readonly List<IPoint> _pointList = new List<IPoint>();
        private readonly List<IProperty> _propertyList = new List<IProperty>();

        public SceneObject(long id) : base(id)
        {
        }
    }
}