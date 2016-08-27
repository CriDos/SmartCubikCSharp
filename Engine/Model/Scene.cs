using System.Collections.Generic;

namespace SmartCubik.Engine.Model
{
    internal class Scene
    {
        private readonly SceneContainer _entryContainer;
        private readonly List<SceneObject> _objectList = new List<SceneObject>();

        public Scene()
        {
            _entryContainer = new SceneContainer(this);
        }

        public void Add(SceneContainer sceneObject)
        {
            _entryContainer.Add(sceneObject);
        }

        public void Remove(SceneContainer sceneObject)
        {
            _entryContainer.Remove(sceneObject);
        }

        public int Count()
        {
            return _objectList.Count;
        }

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
            long lastId = Count() + 1;

            while(true)
            {
                if(!Contains(lastId))
                    break;
            }

            return lastId;
        }
    }
}