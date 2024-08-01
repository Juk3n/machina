using app.Data.Repositories;
using app.Models;
using app.Utilities;
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
    private IRobotRepository _robotRepository;
    private FilterOption _filteredRobot;
    private BindableCollection<RobotModel>? _filteredRobots;
    public BindableCollection<RobotModel>? Robots { get; set; }
    public BindableCollection<RobotModel>? FilteredRobots { 
        get
        {
            return _filteredRobots;
        }
        set
        {
            _filteredRobots = value;
            NotifyOfPropertyChange(() => FilteredRobots);
        }
    }

    public BindableCollection<FilterOption> FilterOptions { get; set; }
    public FilterOption FilteredRobot { 
        get => _filteredRobot; 
        set
        {
            _filteredRobot = value;
            NotifyOfPropertyChange(() => FilteredRobot);
            FilteredRobots = RobotFilter.FilterRobots(Robots, _filteredRobot.Name);    
        } 
    }



    
    public ShellViewModel()
    {
        _robotRepository = new TestRobotRepository();

        Robots = new BindableCollection<RobotModel>(_robotRepository.GetAllRobots());

        FilterOptions = new BindableCollection<FilterOption>();
        FilterOptions.Add(new FilterOption("Wszystkie"));

        FilterOptions.AddRange(Robots.Select(x => new FilterOption(x.Name)));
        FilteredRobot = FilterOptions.ElementAt(0);
    }
}

public class FilterOption
{
    public string Name { get; set; }

    public FilterOption(string name)
    {
        Name = name;
    }

}