using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using ymtPorje.DataAccess.Abstract;
using ymtPorje.DataAccess.Context;

public class GenericRepository<T> : IRepository<T> where T : class
{
    private readonly YmtProjeContext _context;

    public GenericRepository(YmtProjeContext context)
    {
        _context = context;
    }

    public DbSet<T> Table => _context.Set<T>();

    public List<T> GetList()
    {
        return Table.ToList();
    }

    public T GetByFilter(Expression<Func<T, bool>> predicate)
    {
        return Table.FirstOrDefault(predicate);
    }

    public T GetById(int id)
    {
        return Table.Find(id);
    }

    public void Create(T entity)
    {
        Table.Add(entity);
        _context.SaveChanges();
    }

    public void Update(T entity)
    {
        Table.Update(entity);
        _context.SaveChanges();
    }

    public void Delete(int id)
    {
        var entity = Table.Find(id);
        if (entity != null)
        {
            Table.Remove(entity);
            _context.SaveChanges();
        }
    }

    public int Count()
    {
        return Table.Count();
    }

    public int FilteredCount(Expression<Func<T, bool>> predicate)
    {
        return Table.Count(predicate);
    }

    public List<T> GetFilteredList(Expression<Func<T, bool>> predicate)
    {
        return Table.Where(predicate).ToList();
    }
}
