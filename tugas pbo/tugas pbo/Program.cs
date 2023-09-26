using System;

namespace AurynDeviS
{
    class Processor
    {
        public string merk;
        public string tipe;

        public Processor(string merk, string tipe)
        {
            this.merk = merk;
            this.tipe = tipe;
        }
    }

    class Intel : Processor
    {
        public Intel(string _tipe) : base("Intel", _tipe)
        {

        }
    }

    class Corei3 : Intel
    {
        public Corei3() : base("Core i3")
        {

        }
    }

    class Corei5 : Intel
    {
        public Corei5() : base("Core i5")
        {

        }
    }

    class Corei7 : Intel
    {
        public Corei7() : base("Core i7")
        {

        }
    }

    class AMD : Processor
    {
        public AMD(string _tipe) : base("AMD", _tipe)
        {

        }
    }

    class Ryzen : AMD
    {
        public Ryzen() : base("RAYZEN")
        {

        }
    }

    class Athlon : AMD
    {
        public Athlon() : base("RZ")
        {

        }
    }

    class Vga
    {
        public string merk;

        public Vga(string _merk)
        {
            this.merk = _merk;
        }
    }

    class Nvidia : Vga
    {
        public Nvidia() : base("Nvidia")
        {

        }
    }

    class Vga_AMD : Vga
    {
        public Vga_AMD() : base("AMD")
        {

        }
    }

    class Laptop
    {
        public string merk;
        public string tipe;
        public Vga vga;
        public Processor processor;

        public Laptop(string merk, string tipe, Vga vga, Processor processor)
        {
            this.merk = merk;
            this.tipe = tipe;
            this.vga = vga;
            this.processor = processor;
        }

        public void LaptopDinyalakan()
        {
            Console.WriteLine("Laptop " + merk + " " + tipe + " menyala");
        }

        public void LaptopDimatikan()
        {
            Console.WriteLine("Laptop " + merk + " " + tipe + " mati");
        }
    }

    class ASUS : Laptop
    {
        public ASUS(string tipe, Vga vga, Processor processor) : base("ASUS", tipe, vga, processor)
        {

        }
    }

    class ROG : ASUS
    {
        public ROG(Vga vga, Processor processor) : base("ROG", vga, processor)
        {

        }
    }

    class Vivobook : ASUS
    {
        public Vivobook(Vga vga, Processor processor) : base("Vivobook", vga, processor)
        {

        }
        
        public void Ngoding()
        {
            Console.WriteLine("Ctak Ctak Ctak, error lagi!!");
        }
    }

    class ACER : Laptop
    {
        public ACER(string tipe, Vga vga, Processor processor) : base("ACER", tipe, vga, processor)
        {

        }
    }

    class Swift : ACER
    {
        public Swift(Vga vga, Processor processor) : base("Swift", vga, processor)
        {

        }
    }

    class Predator : ACER
    {
        public Predator(Vga vga, Processor processor) : base("Predator", vga, processor)
        {

        }
        
        public void BermainGame()
        {
            Console.WriteLine("Laptop " + merk + " " + tipe + " sedang memainkan game");
        }
    }

    class Lenovo : Laptop
    {
        public Lenovo(string tipe, Vga vga, Processor processor) : base("Lenovo", tipe, vga, processor)
        {

        }
    }

    class IdeaPad : Lenovo
    {
        public IdeaPad(Vga vga, Processor processor) : base("IdeaPad", vga, processor)
        {

        }
    }

    class Legion : Lenovo
    {
        public Legion(Vga vga, Processor processor) : base("Legion", vga, processor)
        {

        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Laptop laptop1, laptop2;
            Predator predator;

            laptop1 = new Vivobook(new Nvidia(), new Corei5());

            laptop2 = new IdeaPad(new Vga_AMD(), new Ryzen());

            predator = new Predator(new Vga_AMD(), new Corei7());

            //laptop2.LaptopDinyalakan();
            //laptop2.LaptopDimatikan();
 
            // laptop1.Ngoding();

            //Console.WriteLine("Merk VGA dari laptop1 : " + laptop1.vga.merk);
            //Console.WriteLine("Merk Processor dari laptop1 : " + laptop1.processor.merk);
            //Console.WriteLine("Tipe Processor dari laptop1 : " + laptop1.processor.tipe);

            predator.BermainGame();

            //ACER acer = new Predator(new Vga_AMD(), new Athlon());

            //acer.BermainGame();
        }
    }
}

