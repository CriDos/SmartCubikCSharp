using System.Collections.Generic;

namespace SmartCubik.Engine.Model
{
    internal class Scene
    {
        public SceneContainer Container { get; }
        private List<SceneObject> _allSceneObjects = new List<SceneObject>();

        public Scene()
        {
            Container = new SceneContainer(0, this);
        }

        public void _AddObject(SceneObject sceneObject)
        {
            _allSceneObjects.Add(sceneObject);
        }

        public long GenElementId()
        {
            long lastId = _allSceneObjects.Count + 1;
            var foundId = false;

            while(true)
            {
                foreach(var sceneObject in _allSceneObjects)
                {
                    if(sceneObject.Id == lastId)
                    {
                        foundId = true;
                        ++lastId;
                        break;
                    }
                }

                if(!foundId)
                {
                    break;
                }
            }

            return lastId;
        }
    }
}