namespace VirtualPetParProg
{
    internal class Animal
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Race { get; set; }
        public string Colour { get; set; }
        public int Petting { get; set; }
        public int ToiletTime { get; set; }
        public int Hunger { get; set; }


        public Animal(string name, int age, string race, string colour, int petting, int toiletTime, int hunger)
        {
            Name = name;
            Age = age;
            Race = race;
            Colour = colour;
            Petting = petting;
            ToiletTime = toiletTime;
            Hunger = hunger;
        }


        public void ChooseAnimal(int optionNumber)
        {
            Console.WriteLine($"Choose your pet: \n {optionNumber}: {Name} the {Race}");
        }
    }
}
