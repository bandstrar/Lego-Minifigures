﻿using System;
using System.Collections.Generic;
using System.Text;

namespace LegoMinifigures.Pieces.Legs
{
    class SpiderLegs : LegsBase
    {
        public SpiderLegs()
        {
            Shoes = "Rollerskates";
            NumberOfLegs = 8;
            Speed = 100;
            _musicGenre = "Shoegaze";
            Size = Size.Spider;
            Covering = "Hair";
        }

        public override void Dance()
        {
            {
                Console.WriteLine("Spiders don't dance.");
            }
        }
    }
}
