using JetBrains.Annotations;
using SmartCubik.Engine.Model;
using System;

namespace SmartCubik.Engine
{
    [UsedImplicitly]
    internal class Program
    {
        private static void Main()
        {
            var sceneModel = new Scene();

            for(int j = 0; j < 100000; j++)
            {
                var c = new SceneContainer(sceneModel);
                c.AddObject(new SceneElement(sceneModel));
                sceneModel.Container.AddObject(c);
            }

            Console.ReadLine();
        }
    }
}