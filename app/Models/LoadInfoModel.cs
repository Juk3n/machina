using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app.Models;

public class LoadInfoModel
{
    public int Id { get; set; }
    public string Name
    {
        get
        {
            if (_name == "available")
                return "(Dostepny do pracy)";
            else if (_name == "docked")
                return "(Zadokowany)";
            else if (_name == "dismissed")
                return "(E-stop zwolniony)";
            else
                return _name;
        }
        set { _name = value; }
    }

    private string _name = "";
}