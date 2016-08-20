using System.Collections.Generic;

namespace SmartCubik.Engine
{
    internal class SceneModel
    {
        private readonly List<IElement> _elements = new List<IElement> { Capacity = 100000 };

        public void Add(Element e)
        {
            _elements.Add(e);
        }

        public void Remove(Element e)
        {
            _elements.Remove(e);
        }

        public long GenElementId()
        {
            long lastId = _elements.Count;

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