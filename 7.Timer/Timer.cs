﻿using System;
using System.Linq;
using System.Threading;


    public delegate void CallBack(object state);

    public class TimerCallBack
    {
        public static void Beep(object state)
        {
            Console.Beep();
            Console.WriteLine("Beep");
        }

        public static void Main()
        {
            CallBack callback = new CallBack(Beep);
            Timer time = new Timer(callback.Invoke, null, 0, 1000);

            Console.Read(); //press enter to exit
        }
    }
