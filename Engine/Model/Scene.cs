using System.Collections.Generic;

namespace SmartCubik.Engine.Model
{
    internal class Scene
    {
        private readonly List<SceneObject> _elements = new List<SceneObject> { Capacity = 100000 };

        public void Add(SceneObject sceneObject)
        {
            _elements.Add(sceneObject);
        }

        public void Remove(SceneObject sceneObject)
        {
            _elements.Remove(sceneObject);
        }

        public long GenElementId()
        {
            long lastId = _elements.Count + 1;

            while(true)
            {
                var isFindId = false;

                foreach(var e in _elements)
                {
                    if(e.Id == lastId)
                    {
                        ++lastId;
                        isFindId = true;
                        break;
                    }
                }

                if(!isFindId)
                    break;
            }

            return lastId;
        }
    }
}