using System.Collections.Generic;
using NullGuard;

namespace SmartCubik.Engine.Model
{
    internal class SceneContainer : SceneObject
    {
        private readonly List<SceneObject> _elementList = new List<SceneObject>();
        private readonly List<ScenePoint> _pointList = new List<ScenePoint>();
        private readonly List<SceneProperty> _propertyList = new List<SceneProperty>();

        public SceneContainer(long id, [AllowNull]BaseSceneObject parent = null) : base(id, parent)
        {

        }
    }
}