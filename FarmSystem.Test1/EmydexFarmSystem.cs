using System;
using System.Collections.Generic;
using FarmSystem.Test2;

namespace FarmSystem.Test1
{
    public class EmydexFarmSystem
    {
        private readonly List<Animal> _farmAnimals = new List<Animal>();
        //TEST 1
        public void Enter(Animal animal)
        {
            try
            {
                //TODO Modify the code so that we can display the type of animal (cow, sheep etc) 
                //Hold all the animals so it is available for future activities
                _farmAnimals.Add(animal);
                Console.WriteLine($"{animal.GetType().Name} has entered the farm");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
        //TEST 2
        public void MakeNoise()
        {
            //Test 2 : Modify this method to make the animals talk
            try
            {
                foreach (var animal in _farmAnimals)
                {
                    animal.Talk();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
            
        }
        //TEST 3
        public void MilkAnimals()
        {
            try
            {
                foreach (var animal in _farmAnimals)
                {
                    if (animal is IMilkableAnimal)
                    {
                        Console.WriteLine($"{animal.GetType().Name} produced milk");
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
        //TEST 4
        public void ReleaseAllAnimals()
        {
            try
            {
                int size = _farmAnimals.Count;
                for (int i = 0; i < size; i++)
                {
                    var animal = _farmAnimals[0].GetType().Name;
                    Console.WriteLine($"{animal} has left the farm");
                    _farmAnimals.RemoveAt(0);
                }
                if (_farmAnimals.Count == 0)
                {
                    Console.WriteLine("Emydex Farm is now empty");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}