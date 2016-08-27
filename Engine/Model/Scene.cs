using System.Collections.Generic;

namespace SmartCubik.Engine.Model
{
    internal class Scene
    {
        public SceneContainer Container { get; }
        public Dictionary<long, SceneObject> Objects { get; } = new Dictionary<long, SceneObject>();

        public Scene()
        {
            Container = new SceneContainer(0, this);
        }

        public long GenElementId()
        {
            long lastId = Objects.Count + 1;

            while(true)
            {
                if(Objects.ContainsKey(lastId))
                {
                    ++lastId;
                    break;
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