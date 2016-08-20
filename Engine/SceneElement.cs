using System.Collections.Generic;

namespace SmartCubik.Engine
{
    internal class SceneElement : SceneObject
    {
        private readonly List<ScenePoint> _pointList = new List<ScenePoint>();
        private readonly List<SceneProperty> _propertyList = new List<SceneProperty>();

        public SceneElement(long id, ISceneObject parentSceneObject = null) : base(id, parentSceneObject)
        {
        }
    }
}