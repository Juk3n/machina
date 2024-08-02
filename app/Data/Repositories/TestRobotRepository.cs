using app.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app.Data.Repositories;

public class TestRobotRepository : IRobotRepository
{
    private AppDataTestContext _context;

    public TestRobotRepository(AppDataTestContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<RobotModel>> GetAllRobotsAsync()
    {
        return await _context.Robots.ToListAsync();
    }

}
