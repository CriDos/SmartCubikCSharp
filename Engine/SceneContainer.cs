using System.Collections.Generic;

namespace SmartCubik.Engine
{
    internal class SceneContainer : SceneObject
    {
        private readonly List<SceneObject> _elementList = new List<SceneObject>();
        private readonly List<ScenePoint> _pointList = new List<ScenePoint>();
        private readonly List<SceneProperty> _propertyList = new List<SceneProperty>();

        public SceneContainer(long id, SceneObject parentSceneObject = null) : base(id, parentSceneObject)
        {

        }
    }
}