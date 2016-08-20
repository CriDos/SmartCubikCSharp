using System.Collections.Generic;

namespace SmartCubik.Engine
{
    internal class SceneContainer : SceneObject
    {
        private readonly List<ISceneObject> _elementList = new List<ISceneObject>();
        private readonly List<ScenePoint> _pointList = new List<ScenePoint>();
        private readonly List<SceneProperty> _propertyList = new List<SceneProperty>();

        public SceneContainer(long id, ISceneObject parentSceneObject = null) : base(id, parentSceneObject)
        {
        }
    }
}