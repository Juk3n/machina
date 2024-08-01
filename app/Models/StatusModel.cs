using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app.Models;

public class StatusModel
{
    public StatusModel(int id, string name)
    {
        Id = id;
        Name = name;
    }

    public int Id { get; set; }

    private string? _name;

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

}
