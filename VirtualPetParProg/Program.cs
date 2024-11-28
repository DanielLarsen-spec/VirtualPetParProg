using System;

namespace VirtualPetParProg
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Animal animal1 = new Animal("Kevin", 5, "Dog", "White", 10, 10, 10);
            Animal animal2 = new Animal("Frenk", 8, "Cat", "Brown", 10, 10, 10);


            animal1.ChooseAnimal(1);
            animal2.ChooseAnimal(2);


            var chosenAnimal = Console.ReadLine();


            Animal selectedAnimal = null;
            switch (chosenAnimal)
            {
                case "1":
                    selectedAnimal = animal1;
                    break;
                case "2":
                    selectedAnimal = animal2;
                    break;
                default:
                    Console.WriteLine("Invalid choice, exiting.");
                    return;
            }


            ShowAnimalMenu(selectedAnimal);
        }


        public static void ShowAnimalMenu(Animal animal)
        {
            Console.WriteLine($"You chose {animal.Name} the {animal.Race}.");
            Console.WriteLine($"Age: {animal.Age}");
            Console.WriteLine($"Colour: {animal.Colour}");
            Console.WriteLine($"Petting: {animal.Petting}");
            Console.WriteLine($"Toilet Time: {animal.ToiletTime}");
            Console.WriteLine($"Hunger: {animal.Hunger}");

            Console.WriteLine("1. Feed the animal");
            Console.WriteLine("2. Cuddle the animal");
            Console.WriteLine("3. Let the animal go to the toilet");

            int action;
            action = Convert.ToInt32(Console.ReadLine());


            switch (action)
            {
                case 1:
                    Feed(animal);
                    break;
                case 2:
                    Cuddle(animal);
                    break;
                case 3:
                    Toilet(animal);
                    break;
                default:
                    Console.WriteLine("Invalid action.");
                    break;
            }


            ShowAnimalMenu(animal);
        }


        public static void Feed(Animal animal)
        {
            animal.Hunger--;
            Console.WriteLine($"{animal.Name} has been fed. Hunger is now {animal.Hunger}.");
        }


        public static void Cuddle(Animal animal)
        {
            animal.Petting++;
            Console.WriteLine($"{animal.Name} is cuddled. Petting is now {animal.Petting}.");
        }


        public static void Toilet(Animal animal)
        {
            animal.ToiletTime--;
            Console.WriteLine($"{animal.Name} went to the toilet. Toilet time is now {animal.ToiletTime}.");
        }
    }
}



/*
  Virtual Pet
Lag en konsoll-applikasjon hvor man kan generere opp flere forskjellige virtuelle kjæledyr.
Bruk constructor i klassen, og man skal ikke ha lov til å endre data som navn, age eller noen andre egenskaper utenfra klassen. 
Lag funksjonalitet som gjør at man kan gi dyret mat, kose med dyret eller sjekke om dyret må på do
Her er et eksempel på hvordan det kan se ut:
Hvilket dyr vil du ta vare på? 
Pikachu
1. Gi Pikachu mat
2. Kos med Pikachu
3. Sjekk om Pikachu må på do
2
Pikachu smiler!
1. Gi Pikachu mat
2. Kos med Pikachu
3. Sjekk om Pikachu må på do
4. Pikachu er mett og fornøyd

 */
