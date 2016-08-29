using NullGuard;
using System.Collections;
using System.Collections.Generic;

namespace SmartCubik.Engine.Model
{
    internal class SceneContainer : SceneObject
    {
        private readonly List<SceneObject> _elementList = new List<SceneObject>();
        private readonly List<ScenePoint> _pointList = new List<ScenePoint>();
        private readonly List<SceneProperty> _propertyList = new List<SceneProperty>();

        public SceneContainer(int id, Scene scene, [AllowNull]BaseObject parent = null) :
            base(id, scene, parent)
        {
        }

        public SceneContainer(Scene scene, [AllowNull]BaseObject parent = null) :
            base(scene, parent)
        {
        }

        public SceneElement AddElement(int id, SceneContainer parent)
        {
            var sceneObject = new SceneElement(id, Scene, parent);
            _elementList.Add(sceneObject);
            return sceneObject;
        }

        public SceneElement AddElement(SceneContainer parent)
        {
            var sceneObject = new SceneElement(Scene, parent);
            _elementList.Add(sceneObject);
            return sceneObject;
        }

        public int Count()
        {
            return _elementList.Count;
        }

        public bool Contains(SceneObject sceneObject)
        {
            return _elementList.Contains(sceneObject);
        }

        public bool Contains(long id)
        {
            foreach(var sceneObject in _elementList)
            {
                if(sceneObject.Id == id)
                {
                    return true;
                }
            }

            return false;
        }
    }
}