using System;

namespace Topic_5_Assignment_Part_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Raine DeVries
            int score = 0;
            string answer1;
            string answer2;
            string answer3;
            string answer4;



            Console.WriteLine("Welcome to the animal quiz! are you ready?");
            Console.ReadLine();
            Console.WriteLine("Good! Let's go!");
            Console.WriteLine("Hears a few clues: I live in jungle, I only live in Madasgascar, besides humains, I am one of the only primates with blue eyes");
            Console.WriteLine("Who am I?");
            Console.WriteLine("1. Tiger 2. Monkey 3. Lemur 4. Python");
            answer1 = Console.ReadLine();
            if (answer1.ToLower() == "tiger")
                Console.WriteLine("Nope! we don't live in Madasgascar");
            else if (answer1.ToLower() == "monkey")
                Console.WriteLine("Nope! we don't have blue eyes!");
            else if (answer1.ToLower() == "lemur")
            {
                Console.WriteLine("Correct! That's one point!");
                score += 1;

            }
            else if (answer1.ToLower() == "python")
                Console.WriteLine("Nope! I'm not as long as a snake!");
            else
                Console.WriteLine("That's not an answer!");


            Console.WriteLine("Press Enter to continue");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Question two: I live in the warm oceans, I'm a type of fish, I can get up to 300 pounds!");
            Console.WriteLine("What am I?");
            Console.WriteLine("1. Turtle 2. Stingray 3. Shark 4. Goldfish");
            answer2 = Console.ReadLine();
            if (answer2.ToLower() == "turtle")
                Console.WriteLine("Nope! Turtles are not fish!");
            else if (answer2.ToLower() == "stingray")
            {
                Console.WriteLine("Correct! you must know a lot about the sea!");
                score += 1;
            }
                
            else if (answer2.ToLower() == "shark")
                Console.WriteLine("Nope! But you were very close");
            else if (answer2.ToLower() == "goldfish")
                Console.WriteLine("No! have you ever seen a 300 pound Goldfish!");
            else Console.WriteLine("That's not an answer!");

            Console.WriteLine("Press Enter to continue");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Question three");
            Console.WriteLine("I live in swamps, I'm small, I make a lot of noise for my size");
            Console.WriteLine("What am I");
            Console.WriteLine("1. Bullfrog 2. Rattlesnake 3. Spider 4. Mudskiper ");
            answer3 = Console.ReadLine();
            if (answer3.ToLower() == "bullfrog")
            {
                Console.WriteLine("Correct! wow your a smart one!");
                score += 1;
            }
      
            else if (answer3.ToLower() == "rattlesnake")
                Console.WriteLine("Nope! Have you seen a Rattlesnake in a swamp?");
            else if (answer3.ToLower() == "spider")
                Console.WriteLine("Nope! What noise do spiders make?");
            else if (answer3.ToLower() == "mudskiper")
                Console.WriteLine("Nope! But they are pretty cool!");
            else Console.WriteLine("That's not an answer!");
         

            Console.WriteLine("Press Enter to continue");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Question four");
            Console.WriteLine("I live in the savana, I'm pretty fast, many people like my colours");
            Console.WriteLine("What am I");
            Console.WriteLine("1. Lion 2. Zebra 3. Giraffe 4. Tree ");
            answer4 = Console.ReadLine();
            if (answer4.ToLower() == "lion")
                Console.WriteLine("Nope! there colours are boring");
            else if (answer4.ToLower() == "zebra")
            {
                Console.WriteLine("Correct! do you live in the savana?");
                score += 1;
            }
            else if (answer4.ToLower() == "giraffe")
                Console.WriteLine("NO!");
            else if (answer4.ToLower() == "tree")
                Console.WriteLine("Are you stupid!?!?!");
            else Console.WriteLine("That's not an answer!");

            Console.WriteLine("Press Enter to continue");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Good Job Completing the quiz, Here your score");
            Console.WriteLine("Your score is: ");
            Console.WriteLine(score * .25 * 100+"%");

            if (score == 0) Console.WriteLine("Wow you should go back to second grade!");
            if (score == 100) Console.WriteLine("Wow your a big nerd");


        }
    }
}


