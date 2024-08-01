using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app.Models;

public class PositionModel
{
    public PositionModel(int id, string name)
    {
        Id = id;
        Name = name;
    }

    public int Id { get; set; }

    private string _name;
    public string Name
    {
        get {
            if (_name == "safe")
                return "Bezpieczna";
            else
                return _name;
        }
        set { _name = value; }
    }
}
