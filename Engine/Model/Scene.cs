using System.Collections.Generic;
using NullGuard;

namespace SmartCubik.Engine.Model
{
    internal class Scene
    {
        private readonly List<SceneContainer> _containers = new List<SceneContainer>();

        public Scene()
        {

        }

        public SceneContainer AddContainer(int id, [AllowNull]BaseObject parent = null)
        {
            var sceneContainer = new SceneContainer(id, this, parent);
            _containers.Add(sceneContainer);
            return sceneContainer;
        }

        public SceneContainer AddContainer([AllowNull]BaseObject parent = null)
        {
            var sceneContainer = new SceneContainer(this, parent);
            _containers.Add(sceneContainer);
            return sceneContainer;
        }

        public int Count()
        {
            var sum = 0;
            foreach(var o in _containers)
            {
                sum += o.Count();
            }
            return 0;
        }

        public bool Contains(long id)
        {
            foreach(var o in _containers)
            {
                if(o.Id == id)
                {
                    return true;
                }
            }

            return false;
        }

        public int GenId()
        {
            var lastId = Count();

            while(true)
            {
                if(Contains(lastId))
                {
                    ++lastId;
                }
                else
                {
                    break;
                }
            }

            return lastId;
        }
    }
}