using CommanderDb.Model;
using CommanderDB.Model;
using Data.AppCommandDbContext;

namespace QueryData.Query
{

public class Query
{
   [UseDbContext(typeof(AppCommandDbContext))]
   [UseProjection]
   [UseFiltering]
   [UseSorting]
   public IQueryable<Commander> GetCommands( AppCommandDbContext context){
      return context.Commanders;
   }

 [UseDbContext(typeof(AppCommandDbContext))]
   [UseProjection]
    [UseFiltering]
   [UseSorting]
   public IQueryable<Macmiilka> GetMacmiilka(AppCommandDbContext context){
      return context.Macmiilkas;
      
   }
}

}