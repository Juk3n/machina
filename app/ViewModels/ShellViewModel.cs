using app.Data.Repositories;
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
            FilterRobots();    
        } 
    }

    private void FilterRobots()
    {
        if (Robots != null)
            if (_filteredRobot.Name == "Wszystkie")
                FilteredRobots = new BindableCollection<RobotModel>(Robots);
            else
                FilteredRobots = new BindableCollection<RobotModel>(Robots.Where(x => x.Name == _filteredRobot.Name));

    }

    private IRobotRepository _robotRepository;
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