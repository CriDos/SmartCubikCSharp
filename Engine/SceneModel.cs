using System.Collections.Generic;

namespace SmartCubik.Engine
{
    internal class SceneModel
    {
        private readonly List<ISceneObject> _elements = new List<ISceneObject> { Capacity = 100000 };

        public void Add(SceneElement e)
        {
            _elements.Add(e);
        }

        public void Remove(SceneElement e)
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