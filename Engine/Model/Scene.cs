using System.Collections.Generic;

namespace SmartCubik.Engine.Model
{
    internal class Scene
    {
        public SceneContainer Container { get; }
        private readonly List<SceneObject> _objectList = new List<SceneObject>();

        public Scene()
        {
            Container = new SceneContainer(this);
        }

        public void AddObject(SceneObject sceneObject)
        {
            Container.Add(sceneObject);
        }

        public void RemoveObject(SceneObject sceneObject)
        {
            Container.Remove(sceneObject);
        }

        public int Count => _objectList.Count;

        public bool Contains(long id)
        {
            foreach(var obj in _objectList)
            {
                if(obj.Id == id)
                {
                    return true;
                }
            }

            return false;
        }

        public long GenElementId()
        {
            long lastId = Count + 1;

            while(true)
            {
                if(!Contains(lastId))
                    break;
            }

            return lastId;
        }
    }
}