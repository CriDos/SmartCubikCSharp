using NullGuard;
using System.Collections;
using System.Collections.Generic;

namespace SmartCubik.Engine.Model
{
    internal class SceneContainer : SceneObject, IEnumerable
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

        public void AddObject(SceneObject sceneObject)
        {
            _elementList.Add(sceneObject);
            Scene.Objects.Add(sceneObject.Id, sceneObject);
        }

        public void RemoveObject(SceneObject sceneObject)
        {
            _elementList.Remove(sceneObject);
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

        public void ClearElements()
        {
            _elementList.Clear();
        }

        public IEnumerator GetEnumerator()
        {
            foreach(var sceneObject in _elementList)
            {
                yield return sceneObject;
            }
        }
    }
}