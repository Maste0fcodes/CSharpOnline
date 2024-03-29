﻿using CSharpDesignPatterns.Base;
using System;
using System.Collections;
using System.Collections.Generic;

namespace CSharpDesignPatterns
{
    class Program
    {
        private static Speedometer mySpeedoMeter;

        static void Main(string[] args)
        {
            VisitorDemo();
             //ObserverDemo();
            //IteratorDemo2();
            //IteratorDemo1();
            //FacadeDemo();
            //DecoratorDemo();
            //AdapterDemo();
            //SingletonDemo();
            //BuilderDemo();
            //AbstractFactoryDemo();
        }

        static void VisitorDemo()
        {
            IWheel wheel = new WideWheel(22);
            wheel.AcceptVisitor(new WheelDiagnostics());
            wheel.AcceptVisitor(new WheelInventory());
        }

        static void ObserverDemo()
        {
            Speedometer speedometer = new Speedometer();
            SpeedMonitor monitor = new SpeedMonitor(mySpeedoMeter);
            Gearbox gear = new Gearbox(mySpeedoMeter);

            mySpeedoMeter.CurrentSpeed = 10;
            mySpeedoMeter.CurrentSpeed = 15;
            mySpeedoMeter.CurrentSpeed = 20;
            mySpeedoMeter.CurrentSpeed = 27;
            mySpeedoMeter.CurrentSpeed = 32;
        }

        static void IteratorDemo2()
        {
            Console.WriteLine("==== Road Bikes ====");
            RoadBikeRange rbRange = new RoadBikeRange();
            foreach (IBicycle bicycle in rbRange.Range)
            {
                Console.WriteLine(bicycle);
            }

            Console.WriteLine("++++ MountainBikeRange");
            MountainBikeRange mbRange = new MountainBikeRange();
            foreach (IBicycle bike in mbRange.Range)
            {
                Console.WriteLine(bike);
            }

        }

        static void PrintIterator(IEnumerator iter)
        {
            while (iter.MoveNext())
            {
                Console.WriteLine(iter.Current);
            }
        }

        static void IteratorDemo1()
        {
            Console.WriteLine("===== Road Bikes =====");
            RoadBikeRange roadRange = new RoadBikeRange();
            PrintIterator(roadRange.GetEnumerator());

            Console.WriteLine("+++++ Moutain Bikes +++++");
            MountainBikeRange mountainBikeRange = new MountainBikeRange();
            PrintIterator(mountainBikeRange.GetEnumerator());
        }

        static void FacadeDemo()
        {
            BikeFacade facade = new BikeFacade();
            facade.PrepareForSale(new DownHill(new WideWheel(20), BikeColor.Red));
        }

        static void DecoratorDemo()
        {
            IBicycle tourBike = new Touring(new NarrowWheel(23));
            Console.WriteLine(tourBike);

            tourBike = new GoldFrame(tourBike);
            Console.WriteLine(tourBike);

            tourBike = new CustomGrip(tourBike);
            Console.WriteLine(tourBike);
        }

        static void AdapterDemo()
        {
            IList<IWheel> wheels = new List<IWheel>();
            wheels.Add(new NarrowWheel(24));
            wheels.Add(new NarrowWheel(20));
            wheels.Add(new WideWheel(24));

            UltraWheel ultraWheel = new UltraWheel(22);
            wheels.Add(new UltraWheelAdapter(ultraWheel));

            foreach(IWheel item in wheels)
            {
                Console.WriteLine(item);
            }
        }

        static void SingletonDemo()
        {
            SerialNumberGenerator generator = SerialNumberGenerator.Instance;

            Console.WriteLine("next serial: {0}", generator.NextSerial());
            Console.WriteLine("next serial: {0}", generator.NextOtherSerial);
            Console.WriteLine("next serial: {0}", generator.NextSerial());
            Console.WriteLine("next serial: {0}", generator.NextOtherSerial);

        }

        static void BuilderDemo()
        {
            AbstractMoutainBike moutainBike = new DownHill (new WideWheel(24), BikeColor.Red);
            BikeBuilder builder = new MountainBikeBuilder(moutainBike);
            BikeDirector director = new MountainBikeDirector();
            IBicycle bicycle = director.Build(builder);
            Console.WriteLine(bicycle);
        }

        static void AbstractFactoryDemo()
        {
            AbstractBikeFactory factory = new RoadBikeFactory();

            // create the bike parts 
            IBikeFrame bikeFrame = factory.CreateBikeFrame();
            IBikeSeat bikeSeat = factory.CreateBikeSeat();
            // Show what we created 
            Console.WriteLine(bikeFrame.BikeFrameParts);
            Console.WriteLine(bikeSeat.BikeSeatParts);
        }
    }
}
