using System.Collections.Generic;

namespace SmartCubik.Engine
{
    internal class SceneContainer : AbstractSceneObject
    {
        private readonly List<ISceneObject> _elementList = new List<ISceneObject>();
        private readonly List<IScenePoint> _pointList = new List<IScenePoint>();
        private readonly List<ISceneProperty> _propertyList = new List<ISceneProperty>();

        public SceneContainer(long id) : base(id)
        {
        }
    }
}