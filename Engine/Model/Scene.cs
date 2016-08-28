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

        public int GenId()
        {
            var lastId = Objects.Count;

            while(true)
            {
                if(Objects.ContainsKey(lastId))
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