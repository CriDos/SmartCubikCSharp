using System.Collections.Generic;

namespace SmartCubik.Engine
{
    internal class SceneElement : AbstractSceneObject
    {
        private readonly List<IScenePoint> _pointList = new List<IScenePoint>();
        private readonly List<ISceneProperty> _propertyList = new List<ISceneProperty>();

        public SceneElement(long id) : base(id)
        {
        }
    }
}