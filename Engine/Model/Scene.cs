using System.Collections.Generic;

namespace SmartCubik.Engine.Model
{
    internal class Scene
    {
        public SceneContainer Container { get; }
        public Dictionary<int, SceneObject> Objects { get; } = new Dictionary<int, SceneObject>();

        public Scene()
        {
            Container = new SceneContainer(0, this);
        }

        public int GenId()
        {
            int lastId = Objects.Count + 1;

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