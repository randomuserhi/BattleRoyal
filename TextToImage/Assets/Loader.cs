using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Loader
{
    public static void LoadAllSprites()
    {
        new ConsoleSprite(@"C:\Users\LenovoY720\Documents\Compsci\Unity Coding\TextToImage\Assets\Sprites\Test.txt", "TestSprite");
        new ConsoleSprite(@"C:\Users\LenovoY720\Documents\Compsci\Unity Coding\TextToImage\Assets\Sprites\Cat_Sleeping.txt", "Cat_Sleeping");
        new ConsoleSprite(@"C:\Users\LenovoY720\Documents\Compsci\Unity Coding\TextToImage\Assets\Sprites\Happy_Birthday.txt", "Happy_Birthday");
        new ConsoleSprite(@"C:\Users\LenovoY720\Documents\Compsci\Unity Coding\TextToImage\Assets\Sprites\WalkTest.txt", "Walk");
    }
}
