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
            // Variabler i klasser [x]
            // Metoder i klasser [x]
            // Instanser av klasser [x]
            // Konstruktorer []
            // Static []
            // Klassdiagram []
            // Synlighet (public/private/protected) []
            // Kommentarer []

            //Skapar två instanser av klassen Paddle, men den används inte i själva spelet.

            Paddle paddle1 = new Paddle();
            Paddle paddle2 = new Paddle();

            //Positioner för hörnen av paddlarna

            paddle1.x = 20; 
            paddle1.y = paddle2.y = 325;    
            paddle2.x = 760;

            int squareWindowSize = 800;

            //Öppnar ett fönster och kallar det "Pong But Only The Paddles"

            Raylib.InitWindow(squareWindowSize, squareWindowSize, "Pong But Only The Paddles");

            while(!Raylib.WindowShouldClose())
            {
                //Gör det möjligt att använda A och Z för den första spelaren

                if (Raylib.IsKeyDown(KeyboardKey.KEY_A))
                {
                    paddle1.y -= .2f;
                }
                else if (Raylib.IsKeyDown(KeyboardKey.KEY_Z))
                {
                    paddle1.y += .2f;
                }

                //GÖr det möjligt att använda K och M för den andra spelaren

                if (Raylib.IsKeyDown(KeyboardKey.KEY_K))
                {
                    paddle2.y -= .2f;
                }
                else if (Raylib.IsKeyDown(KeyboardKey.KEY_M))
                {
                    paddle2.y += .2f;
                }

                //Gör det omöjligt för den första spelaren att röra sig nedför fönstret

                if(paddle1.y < squareWindowSize - squareWindowSize)
                {
                    paddle1.y += .2f;
                }

                //Gör det omöjligt för den första spelaren att röra sig ovanför fönstret

                else if(paddle1.y > squareWindowSize - paddle1.height)
                {
                    paddle1.y -=.2f;
                }
                
                //Gör det omöjligt för den andra spelaren att röra sig nedför fönstret

                if(paddle2.y < squareWindowSize - squareWindowSize)
                {
                    paddle2.y += .2f;
                }
                
                //Gör det omöjligt för den första spelaren att röra sig ovanför fönstret

                else if(paddle2.y > squareWindowSize - paddle2.height)
                {
                    paddle2.y -=.2f;
                }

                //Skapar ett rityta

                Raylib.BeginDrawing();

                //Gör bakgrundsfärgen till svart

                Raylib.ClearBackground(Color.BLACK);
                
                //Ritar ut två paddlar

                Raylib.DrawRectangle((int)paddle1.x,(int)paddle1.y, paddle1.width, paddle1.height, Color.WHITE);

                Raylib.DrawRectangle((int)paddle2.x,(int)paddle2.y, paddle2.width, paddle2.height, Color.WHITE);

                //Stänger fönstret

                Raylib.EndDrawing();
            
            }
        }
    }
}