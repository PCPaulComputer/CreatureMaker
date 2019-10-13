using System;
using System.Collections.Generic;
using System.Text;
/// <summary>
/// Author: Paul Madduma
/// </summary>
namespace CreatureMaker
{
    /// <summary>
    /// Monster Class processes the body parts to 
    /// build a creature
    /// </summary>
    public class Monster
    {
        ///initializing variables
        public string Head { get; set; }
        public string Body { get; set; }
        public string Feet { get; set; }
        public int headNum { get; set; }
        public int bodyNum { get; set; }
        public int feetNum { get; set; }

        /// <summary>
        /// Monster constructor
        /// </summary>
        /// <param name="top"></param>
        /// <param name="middle"></param>
        /// <param name="bottom"></param>
        public Monster(string top, string middle, string bottom)
        {
            Head = top;
            Body = middle;
            Feet = bottom;
        }

        /// <summary>
        /// Configuration of creature; 3 parts are required
        /// </summary>
        /// <param name="head"></param>
        /// <param name="body"></param>
        /// <param name="feet"></param>
        public void BuildACreature(string head = "bug", string body = "ghost", string feet = "monster")
        {
            headNum = TranslateToNumber(head);
            bodyNum = TranslateToNumber(body);
            feetNum = TranslateToNumber(feet);
            SwitchCase(headNum, bodyNum, feetNum);
        } //end of BuildACreature

        public void RandomMode()
        {
            Random randomNumber = new Random();
            int head = randomNumber.Next(1, 4);
            int body = randomNumber.Next(1, 4);
            int feet = randomNumber.Next(1, 4);
            SwitchCase(head, body, feet);
        }

        /// <summary>
        /// SwitchCase mix and match parts according to user inputs
        /// </summary>
        /// <param name="head"></param>
        /// <param name="body"></param>
        /// <param name="feet"></param>
        public void SwitchCase(int head, int body, int feet)
        {
            switch (head)
            {
                case 1:
                    GhostHead();
                    break;
                case 2:
                    BugHead();
                    break;
                case 3:
                    MonsterHead();
                    break;
            }
            switch (body)
            {
                case 1:
                    GhostBody();
                    break;
                case 2:
                    BugBody();
                    break;
                case 3:
                    MonsterBody();
                    break;
            }
            switch (feet)
            {
                case 1:
                    GhostFeet();
                    break;
                case 2:
                    BugFeet();
                    break;
                case 3:
                    MonsterFeet();
                    break;
            }
        }

        /// <summary>
        /// where the user string inputs will be converter into number
        /// to make SwitchCase switch loop easier to use 
        /// </summary>
        /// <param name="creature"></param>
        /// <returns></returns>
        public int TranslateToNumber(string creature)
        {
            switch (creature)
            {
                case "ghost":
                    return 1;
                    break;
                case "bug":
                    return 2;
                    break;
                case "monster":
                    return 3;
                    break;
                default:
                    return 1;
                    break;
            }
        }

        /// <summary>
        /// Methods below are strings that resembles 
        /// ghost, monster and bug anatomy
        /// </summary>
        public void GhostHead()
        {
            Console.WriteLine("     ..-..");
            Console.WriteLine("    ( o o )");
            Console.WriteLine("    |  O  |");
        }

        public void GhostBody()
        {
            Console.WriteLine("    |     |");
            Console.WriteLine("    |     |");
            Console.WriteLine("    |     |");
        }

        public void GhostFeet()
        {
            Console.WriteLine("    |     |");
            Console.WriteLine("    |     |");
            Console.WriteLine("    '~~~~~'");
        }

        public void BugHead()
        {
            Console.WriteLine("     /   \\");
            Console.WriteLine("     \\. ./");
            Console.WriteLine("    (o + o)");
        }

        public void BugBody()
        {
            Console.WriteLine("  --|  |  |--");
            Console.WriteLine("  --|  |  |--");
            Console.WriteLine("  --|  |  |--");
        }

        public void BugFeet()
        {
            Console.WriteLine("     v   v");
            Console.WriteLine("     *****");
        }

        public void MonsterHead()
        {
            Console.WriteLine("     _____");
            Console.WriteLine(" .-,;='';_),-.");
            Console.WriteLine("  \\_\\(),()/_/");
            Console.WriteLine("　  (,___,)");
        }

        public void MonsterBody()
        {
            Console.WriteLine("   ,-/`~`\\-,___");
            Console.WriteLine("  / /).:.('--._)");
            Console.WriteLine(" {_[ (_,_)");
        }

        public void MonsterFeet()
        {
            Console.WriteLine("    |  Y  |");
            Console.WriteLine("   /   |   \\");
            Console.WriteLine("   \"\"\"\" \"\"\"\"");
        }
    }
}
