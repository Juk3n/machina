using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app.Models;

public class JobStatusModel
{
    public int Id { get; set; }
    public string Name
    {
        get
        {
            if (_name == "working")
                return "W trakcie akcji";
            else
                return _name;
        }
        set { _name = value; }
    }

    private string _name = "";
}
