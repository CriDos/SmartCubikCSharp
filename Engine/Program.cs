using JetBrains.Annotations;
using System;
using SmartCubik.Engine.Model;

namespace SmartCubik.Engine
{
    [UsedImplicitly]
    internal class Program
    {
        private static void Main()
        {
            var sceneModel = new Scene();

            for(var i = 0L; i < 100; i++)
            {
                var sceneContainer = new SceneContainer(sceneModel);
                sceneModel.Add(sceneContainer);
            }

            Console.ReadLine();
        }
    }
}