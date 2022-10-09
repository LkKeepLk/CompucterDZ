using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compucter
{
    internal class Computer
    {
        private string _name;
        private int _sizeRAM;
        private  int _sizeHDD;
        private bool _condition = false;
        private string _OC;


        public Computer(string name, int sizeRAM, string OC, int sizeHDD)
        {
            _name = name;
            _sizeRAM = sizeRAM;
            _sizeHDD = sizeHDD;
            _OC = OC;

        }
        public void GetInfo()
        {
            Console.WriteLine($"Имя утройства - {_name}");
            Console.WriteLine($"Имя системы - {_OC}");
            Console.WriteLine($"кол-во памяти в диске - {_sizeHDD}ГБ");
            Console.WriteLine($"кол-во оперативной памяти - {_sizeRAM}ГБ");
        }
        public void TurnOn()
        {
            _condition = true;
            Console.WriteLine("Устройство включено");
        }
        public void TurnOff()
        {
            _condition = false;
            Console.WriteLine("Устройство выключено");
        }
        public void InstallOC(string OC)
        { _OC = OC;
            if (_condition == false)
            {
                Console.WriteLine("Невозможно установить ОС при выключенном устройстве");
            }
            else if (_condition == true)
            {
                Console.WriteLine("Идет установка MacOS");
            }
        }
    }
}
