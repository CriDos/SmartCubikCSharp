using System.Collections.Generic;

namespace SmartCubik.Engine.Model
{
    internal class Scene
    {
        private readonly List<SceneObject> _elements = new List<SceneObject> { Capacity = 100000 };

        public void Add(SceneObject e)
        {
            _elements.Add(e);
        }

        public void Remove(SceneObject e)
        {
            _elements.Remove(e);
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