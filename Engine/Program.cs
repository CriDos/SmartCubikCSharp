using JetBrains.Annotations;
using System;

namespace SmartCubik.Engine
{
    [UsedImplicitly]
    internal class Program
    {
        private static void Main()
        {
            var sceneModel = new SceneModel();

            for(var i = 0L; i < 100; i++)
            {
                sceneModel.Add(new Element(sceneModel.GenElementId()));
            }

            
            Console.ReadLine();
        }
    }
}