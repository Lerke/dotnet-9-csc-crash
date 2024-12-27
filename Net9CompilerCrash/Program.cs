using System.Linq.Expressions;
IList<string> dataSource = ["1", "2"];

Filter(dataSource.AsQueryable(), new()
{
    {
        "testColumn",
        (q, str) => q.Where(x => x == $"{str}")
    }
});
    
void Filter<T>(IQueryable<T> queryable, Dictionary<string, Expression<Func<IQueryable<T>, string[], IQueryable<T>>>> filterMembers)
{
    // Implementation not important
}