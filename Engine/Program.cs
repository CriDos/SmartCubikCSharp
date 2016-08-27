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
                sceneModel.Add(new SceneElement(sceneModel.GenElementId()));
            }

            Console.ReadLine();
        }
    }
}