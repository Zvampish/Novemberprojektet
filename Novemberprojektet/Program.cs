using System;
using Raylib_cs;

namespace Novemberprojektet
{
    class Program
    {
        static void Main(string[] args)
        {
            // Git och GitHub [x]
            // Klasser []
            // Variabler i klasser []
            // Metoder i klasser []
            // Instanser av klasser []
            // Konstruktorer []
            // Static []
            // Klassdiagram []
            // Synlighet (public/private/protected) []

            int windowSize = 800;
            int rectangleSizeX = 20;
            int rectangleSizeY = 125;

            Raylib.InitWindow(800, 800, "Hello Man!");

            Random generator = new Random();

            float playerOneX = 20;
            float playerOneY = 325;
            float playerTwoX = 760;
            float playerTwoY = 325;

            while(!Raylib.WindowShouldClose())
            {
                if (Raylib.IsKeyDown(KeyboardKey.KEY_A))
                {
                    playerOneY -= .2f;
                }
                else if (Raylib.IsKeyDown(KeyboardKey.KEY_Z))
                {
                    playerOneY += .2f;
                }

                if (Raylib.IsKeyDown(KeyboardKey.KEY_K))
                {
                    playerTwoY -= .2f;
                }
                else if (Raylib.IsKeyDown(KeyboardKey.KEY_M))
                {
                    playerTwoY += .2f;
                }

                if(playerOneY < windowSize - windowSize)
                {
                    playerOneY += .2f;
                }
                else if(playerOneY > windowSize - rectangleSizeY)
                {
                    playerOneY -=.2f;
                }

                if(playerTwoY < windowSize - windowSize)
                {
                    playerTwoY += .2f;
                }
                else if(playerTwoY > windowSize - rectangleSizeY)
                {
                    playerTwoY -=.2f;
                }

                Raylib.BeginDrawing();

                Raylib.ClearBackground(Color.BLACK);

                Raylib.DrawRectangle((int)playerOneX,(int)playerOneY, rectangleSizeX, rectangleSizeY, Color.WHITE);

                Raylib.DrawRectangle((int)playerTwoX,(int)playerTwoY, rectangleSizeX, rectangleSizeY, Color.WHITE);

                Raylib.EndDrawing();
            
            }
        }
    }
}
