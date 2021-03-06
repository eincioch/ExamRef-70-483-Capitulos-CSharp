﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events_003
{
    public class MyArgs : EventArgs
    {
        public int Value { get; set; }

        public MyArgs(int value)
        {
            Value = value;
        }
    }

    public class Pub
    {
        public event EventHandler<MyArgs> OnChange = delegate { };

        public void Raise()
        {
            OnChange(this, new MyArgs(42));
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Pub p = new Pub();

            p.OnChange += (sender, e) => Console.WriteLine("Event raised: {0}", e.Value);

            p.Raise();
        }
    }
}
