using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace EU
{
  class Program
  {
    static List<Csatlakozasok> csatlakozas = new List<Csatlakozasok>();
    static void Main(string[] args)
    {
      MasodikFeladat();
      HarmadikFeladat();
      NegyedikFeladat();
      OtodikFeladat();
      HatodikFeladat();
      HetedikFeladat();
      NyolcadikFeladat();
      Console.ReadKey();
    }


    private static void NyolcadikFeladat()
    {

    }

    private static void HetedikFeladat()
    {

    }

    private static void HatodikFeladat()
    {

    }

    private static void OtodikFeladat()
    {

    }

    private static void NegyedikFeladat()
    {

    }

    private static void HarmadikFeladat()
    {

    }

    private static void MasodikFeladat()
    {
      Console.WriteLine("2. feladat: adatok beolvasása");
      StreamReader be = new StreamReader("EUcsatlakozas.txt");
      while (!be.EndOfStream)
      {
        string[] a = be.ReadLine().Split(';');
        csatlakozas.Add(new Csatlakozasok(
          a[0], Convert.ToDateTime(a[1])));
      }
      be.Close();
    }
  }
}

