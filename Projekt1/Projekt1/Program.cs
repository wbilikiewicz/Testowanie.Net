using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt1
{
    public class Test
    {
        int x { get; set; }
        public int daj(int y)
        {
            x = y + 5;
            return x;
        }

    }
    public class TestDane
    {
        string imie;

        public string poloncz(string nazwisko)
        {
            imie = "Anna";
            return nazwisko + imie;
        }
    }

    public class TestCollection
    {
        public List<int> actual = new List<int>();
        public TestCollection()
        {
            actual.Add(10);
            actual.Add(20);
            actual.Add(30);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
