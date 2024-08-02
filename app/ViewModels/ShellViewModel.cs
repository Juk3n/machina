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
            FilteredRobots = new BindableCollection<RobotModel>(RobotFilter.FilterRobots(Robots, _filteredRobot.Name));    
        } 
    }
    
    public ShellViewModel()
    {
        //_robotRepository = new TestRobotRepository();

        //FilterOptions = new BindableCollection<FilterOption>();
        //FilterOptions.Add(new FilterOption("Wszystkie"));
        //FilteredRobot = FilterOptions.First();
    }

    public async void LoadRobotData()
    {
        var robots = await _robotRepository.GetAllRobotsAsync();
        Robots = new BindableCollection<RobotModel>(robots);
        if (FilterOptions.ToArray().Length < 2)
            FilterOptions.AddRange(Robots.Select(x => new FilterOption(x.Name)));
        FilteredRobot = FilterOptions.First();
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