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

            for(int j = 0; j < 30000; j++)
            {
                sceneModel.Container.AddObject(new SceneElement(sceneModel));
            }

            Console.ReadLine();
        }
    }
}