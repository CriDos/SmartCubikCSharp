using System.Collections.Generic;
using NullGuard;

namespace SmartCubik.Engine.Model
{
    internal class SceneElement : SceneObject
    {
        private readonly List<ScenePoint> _pointList = new List<ScenePoint>();
        private readonly List<SceneProperty> _propertyList = new List<SceneProperty>();

        public SceneElement(long id, Scene scene, [AllowNull]BaseObject parent = null) :
            base(id, scene, parent)
        {
        }
        public SceneElement(Scene scene, [AllowNull]BaseObject parent = null) :
            base(scene.GenElementId(), scene, parent)
        {

        }
    }
}