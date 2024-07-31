using app.Models;
using Caliburn.Micro;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app.ViewModels;

public class ShellViewModel : Screen
{
    public BindableCollection<String>? Robots { get; set; }
    public BindableCollection<FilterType> RobotFilters { get; set; }

    public ShellViewModel()
    {
        RobotFilters = new BindableCollection<FilterType>();
        RobotFilters.Add(new FilterType("Chiron"));
        RobotFilters.Add(new FilterType("Robot 1"));
        RobotFilters.Add(new FilterType("Robot 2"));
        RobotFilters.Add(new FilterType("Robot 3"));

        Robots = new BindableCollection<string>();
        Robots.Add("a");
        Robots.Add("b");
        Robots.Add("c");
        Robots.Add("d");

    }
}

public class FilterType
{
    public string? Name { get; set; }

    public FilterType(string? name)
    {
        Name = name;
    }
}
