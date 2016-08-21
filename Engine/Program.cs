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
            var sceneModel = new SceneModel();

            for(var i = 0L; i < 100; i++)
            {
                sceneModel.Add(new SceneElement(sceneModel.GenElementId()));
            }

            Console.ReadLine();
        }
    }
}