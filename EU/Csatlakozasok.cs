using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EU
{
  class Csatlakozasok
  {

    private string Orszag;

    public string orszag
    {
      get { return Orszag; }
      set { Orszag = value; }
    }

    private DateTime Ev;



    public DateTime ev
    {
      get { return Ev; }
      set { Ev = value; }
    }

    public Csatlakozasok(string orszag, DateTime ev)
    {
      Orszag = orszag;
      Ev = ev;
    }

  }
}
