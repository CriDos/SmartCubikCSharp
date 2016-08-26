using System.Collections.Generic;

namespace SmartCubik.Engine
{
    internal class SceneModel
    {
        private readonly List<ModelObject> _elements = new List<ModelObject> { Capacity = 100000 };

        public void Add(ModelElement e)
        {
            _elements.Add(e);
        }

        public void Remove(ModelElement e)
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