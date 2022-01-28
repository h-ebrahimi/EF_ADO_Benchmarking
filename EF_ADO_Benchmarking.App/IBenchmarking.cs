using System.Collections.Generic;

namespace EF_ADO_Benchmarking.App
{
    public interface IBenchmarking
    {
        Employee GetEmployeeByID(int id);
        List<TeamEmployee> GetTeamEmployees(int teamId);
    }
}