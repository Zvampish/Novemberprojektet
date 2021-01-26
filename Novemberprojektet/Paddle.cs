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

        public Rectangle rectangle = new Rectangle();

        //En statisk slumpgenerator som alla paddlar delar på

        static Random generator = new Random();

        public Paddle()
        {
            
        }
    }
}