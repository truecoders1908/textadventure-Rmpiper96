using System;

namespace TextAdventure
{
    class Program
    {
        static void Main(string[] args)
        {
            string replay = "yes";
            double totaltime = 1440;
            //Introductory Lines
            Console.WriteLine("Welcome to my text adventure. In this game, your objective is to escape the hedge maze.");
            Console.WriteLine("You have 12 hours to do so. Every action you take will reduce how much time you have.");
            Console.WriteLine("Good luck! Press enter to continue");
            Console.ReadLine();
            Console.Clear();

            
            if (replay == "yes")  
                // Instructions
            {
                Console.WriteLine("When you want to go somewhere, type 'go to' hit enter, then 'place' If you want to use an item on something,");
                Console.WriteLine("type 'use' (item) (object). If you wish to use your hands, leave the item section blank.");
                Console.WriteLine("To pick up an item, simply type 'take' enter (item)");
                Console.WriteLine("You can also explore the area you're currently in to 'investigate' parts of an area you are currently in");
                Console.WriteLine("that may not have been available to you earlier");
                Console.WriteLine("Press enter to continue");
                Console.ReadLine();
                // The Game begins
                Console.WriteLine("It's dark. The air is cool, and above you the moon is shining brightly, casting a low light on your surroundings");
                Console.WriteLine("You look around and see hedges. They look to be thrice as tall as any normal person.");
                Console.WriteLine("You check your pockets for your phone, but come up empty. You did find that you have a digital watch");
                Console.WriteLine("which reads 8:00pm. After glancing around again, you see there is an opening in the hedges in front of you,");
                Console.WriteLine("and you also think you notice a small Shed in the corner of the hedges");
                Console.WriteLine("Now that you're looking more closely, you think you can see something shining on the moonlight");
                Console.WriteLine("near the Hedge Maze Entrance.");
                Console.WriteLine("What would you like to do?");
                Console.WriteLine("You can 'go to' 'investigate' 'use' 'take'");
                Console.WriteLine("Not all actions are available at all locations");
                Console.WriteLine("");

            //First Choice
            TheStart:
                int axe = 0;
                int crowbar = 0;
                string go = "go to";
                string use = "use";
                string destination0 = "the clearing";
                string destination1 = "hedge maze entrance";
                string destination2 = "shed";
                TheClearing:
                Console.WriteLine("You are in the middle of a clearing, what would you like to do?");
                string act1= Console.ReadLine(); string dest1 = Console.ReadLine();
                act1 = act1.ToLower();
                dest1 = dest1.ToLower();
                if (dest1 == destination2 && act1 == go)
                {
                ShedStart:
                    string act2 = "";
                    Console.WriteLine("As you approch the shed, you can moke some more details about it.");
                    Console.WriteLine("The wood that makes out it's exterior is in pristine condition.");
                    Console.WriteLine("It almost appears as if it was recently built");
                    Console.WriteLine("as you get closer to the door you notice that");
                    Console.WriteLine("A hefty lock resides on the door.");

                    int TheLock = 1;
                ShedAct:
                    Console.WriteLine("You are currently at the shed. You can return to the clearing from here. what do you do?");
                    act2 = Console.ReadLine();
                    act2.ToLower();
                    if (act2 == go)
                    {
                        string dest2 = Console.ReadLine();
                        dest2.ToLower();
                        if (dest2 == destination0)
                        {
                            Console.WriteLine("You walk back to the middle of the clearing.");
                            goto TheClearing;

                        }
                    }
                    else if (act2 == use)
                    {
                        string tool2 = Console.ReadLine();
                        string obj2 = Console.ReadLine();
                        tool2.ToLower(); obj2.ToLower();
                        if (tool2 == "" && obj2 == "lock")
                        {
                            Console.WriteLine("You try the lock with your hands but nothing happens.");
                            goto ShedAct;
                        }
                        else if (tool2 == "axe" && axe > 0 && obj2 == "lock")
                        {
                            Console.WriteLine("You ready the axe and strike the lock with the blunt end of it.");
                            Console.WriteLine("It takes several swings, but you manage to take the lock from the door.");
                            Console.WriteLine("With the lock gone, the doors to the shed swing wide open.");
                            TheLock--;
                            goto ShedAct;
                        }
                        else
                        {
                            Console.WriteLine("You can't do that.");
                            goto ShedAct;
                        }
                    }
                    
                    else if (act2 == "investigate" && TheLock == 0)
                    {
                        Console.WriteLine("With the lock gone, you are able to enter the shed.");
                        Console.WriteLine("Inside you can see in the dim light a large quantity of gardening supplies, fertilzer,");
                        Console.WriteLine("and one thing that sort of stands out from the rest, a crowbar.");
                        goto ShedAct;
                    }
                    else if (act2 == "investigate")
                    {
                        Console.WriteLine("You search around the building and find a small note taped to the back wall which reads:");
                        Console.WriteLine("IT'S HERE, IT'S HERE, the beating heart! It must be for it does not change. but beyond this");
                        Console.WriteLine("box, I cannot tell, it all seems so strange. These walls, you see, are not made");
                        Console.WriteLine("of hedge alone, but also stone and it seems to have overgrown its bounds,");
                        Console.WriteLine("and now it sounds like my box will become my hole.");
                        goto ShedAct;

                    }
                    else if (act2 == "take" && TheLock == 0)
                    {
                        string item2 = Console.ReadLine();
                        item2.ToLower();
                        if (item2 == "crowbar")
                        {
                            Console.WriteLine("You pick up the crowbar");
                            crowbar += 3;
                            goto ShedAct;
                        }

                    }
                    else if (act2 == "take" && TheLock != 0)
                    {
                        Console.WriteLine("What Crowbar?");
                        goto ShedAct;
                    }

                    if (act1 == go)
                    {
                        string dest2 = Console.ReadLine();

                    }

                }
                else if (dest1 == destination1)
                {
                HedgeStart:
                    Console.WriteLine("You approach the entrance to the hedge maze. you remember seeing something shining around here...");
                HedgeAct:
                    Console.WriteLine("What do you do?");
                    string act3 = Console.ReadLine();
                    act3 = act3.ToLower();

                    if (act3 == go)
                    {
                        string dest3 = Console.ReadLine();
                        dest3 = dest3.ToLower();
                        if (dest3 == destination0)
                        {
                            Console.WriteLine("You walk back to the middle of the clearing");
                            goto TheClearing;
                        }
                        else
                        {
                            Console.WriteLine("Unknown Location");
                            goto HedgeAct;
                        }

                    }
                    if (act3 == "use")
                    {
                        Console.WriteLine("There's nothing to do.");
                    }
                    if (act3 == "investigate")
                    {
                        Console.WriteLine("You search around for a moment and find an axe resting against one of the surrounding hedge walls.");
                        goto HedgeAct;
                    }
                    if (act3 == "take")
                    {
                        string item1 = Console.ReadLine();
                        item1 = item1.ToLower();

                        if (item1 == "axe")
                        {
                            Console.WriteLine("You pick up the axe");
                            axe += 3;
                            goto HedgeAct;
                        }

                    }
                }
                else
                {
                    Console.WriteLine("Unknown Command");
                    goto TheClearing;
                }
            }
        }
    }
    // Unfortunately I didnt have the time to officially finish this but at least the first two sections work
} 
