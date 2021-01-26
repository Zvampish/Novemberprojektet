using System.ComponentModel;
using System;
using Raylib_cs;

namespace Novemberprojektet
{
    
    public class Paddle
    {
        public int height = 125;
        public int width = 20;
        
        public float x;
        public float y;

        //En statisk slumpgenerator som alla paddlar delar på

        static Random generator = new Random();

        private int grade;

        //En konstruktor som använder en slumpgeneratorn ovan

        public Paddle()
        {
            grade = generator.Next(1, 11);
        }
    }
}