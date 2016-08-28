using System.Collections.Generic;

namespace SmartCubik.Engine.Model
{
    internal class Scene
    {
        public SceneContainer Container { get; }
        public Dictionary<int, SceneObject> Objects { get; } = new Dictionary<int, SceneObject>();
        
        public Scene()
        {
            Container = new SceneContainer(this);
        }

        public int GenId()
        {
            var lastId = Objects.Count;

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