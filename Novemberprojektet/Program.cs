using System;
using Raylib_cs;

namespace Novemberprojektet
{
    class Program
    {
        static void Main(string[] args)
        {
            // Git och GitHub [x]
            // Klasser [x]
            // Variabler i klasser []
            // Metoder i klasser []
            // Instanser av klasser []
            // Konstruktorer []
            // Static []
            // Klassdiagram []
            // Synlighet (public/private/protected) []


            Paddle paddle1 = new Paddle();
            Paddle paddle2 = new Paddle();
            paddle1.x = 20; 
            paddle1.y = paddle2.y = 325;
            paddle2.x = 760;


            int windowSize = 800;

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
                else if(playerOneY > windowSize - paddle1.height)
                {
                    playerOneY -=.2f;
                }

                if(playerTwoY < windowSize - windowSize)
                {
                    playerTwoY += .2f;
                }
                else if(playerTwoY > windowSize - paddle2.height)
                {
                    playerTwoY -=.2f;
                }

                Raylib.BeginDrawing();

                Raylib.ClearBackground(Color.BLACK);

                Raylib.DrawRectangle((int)playerOneX,(int)playerOneY, paddle1.width, paddle1.height, Color.WHITE);

                Raylib.DrawRectangle((int)playerTwoX,(int)playerTwoY, paddle2.width, paddle2.height, Color.WHITE);

                Raylib.EndDrawing();
            
            }
        }
    }
}