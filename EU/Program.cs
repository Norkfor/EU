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
      bool volte = false;
      foreach (var cs in csatlakozas)
      {
        if (cs.ev.Month == 05)
        {
          volte = true;
        }
      }
      if (volte == true)
      {
        Console.WriteLine("6. feladat: Májusban volt csatlakozás.");
      }
      else
      {
        Console.WriteLine("6. feladat: Májusban nem volt csatlakozás.");
      }
    }

    private static void OtodikFeladat()
    {
      int hanyadik = 0;
      for (int i = 0; i < csatlakozas.Count; i++)
      {
        if (csatlakozas[i].orszag == "Magyarország")
        {
          hanyadik = i;
        }
      }
      Console.WriteLine("5. feladat: Magyarország csatlakozásának dátuma: {0}", csatlakozas[hanyadik].ev.ToString("yyyy/MM/dd"));
    }

    private static void NegyedikFeladat()
    {
      int db = 0;
      for (int i = 0; i < csatlakozas.Count; i++)
      {
        if (csatlakozas[i].ev.Year == 2007)
        {
          db++;
        }
      }
      Console.WriteLine("4. feladat: 2007-ben {0} ország csatlakozott.", db);
    }

    private static void HarmadikFeladat()
    {
      int db = 0;
      for (int i = 0; i < csatlakozas.Count; i++)
      {
        if (csatlakozas[i].ev < DateTime.Parse("2018. 01. 01"))
        {
          db++;
        }
      }
      Console.WriteLine("3. feladat: EU tagállamainak száma: {0} db", db);
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

