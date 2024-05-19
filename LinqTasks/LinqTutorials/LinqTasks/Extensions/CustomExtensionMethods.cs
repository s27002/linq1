using LinqTasks.Models;

namespace LinqTasks.Extensions;

public static class CustomExtensionMethods
{
    //Put your extension methods here
    public static IEnumerable<Emp> GetEmpsWithSubordinates(this IEnumerable<Emp> emps)
    {
        return emps.Where(e => e.Mgr != null)
            .Select(e => e.Mgr)
            .OrderBy(e => e.Ename)
            .ThenByDescending(e => e.Salary);
    }
}