using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app.Models;

public class StatusModel
{
    public int Id { get; set; }
    public string Name
    {
        get {
            if (_name == "working")
                return "W trakcie akcji";
            else if (_name == "busy")
                return "Niedostepny zajety";
            else if (_name == "available")
                return "Dostepny";
            else if (_name == "error")
                return "Niedostepny Potrzebny asystent";
            else
                return _name;
        }
        set { _name = value; }
    }

    private string _name = "";
}
