
using ProjectDataAccess.Data;
using Microsoft.EntityFrameworkCore;
using ProjectModels;
// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

//DBCreated and migrations execute if it missed
//using var context = new AddDBContext();
//{
//    context.Database.EnsureCreated();
//    if (context.Database.GetPendingMigrations().Any())// we can use Count()>0 at place of any
//    {
//        context.Database.Migrate();
//    }
//}

//Get
//GetAllAuthors();

void GetAllAuthors()
{
    using var context = new AddDBContext();
    var author = context.Authors.ToList();
    foreach (var item in author)
    {
        Console.WriteLine(item.FirstName + "-" + item.LastName);
    }
}

//ADD
//AddAuthors();

void AddAuthors()
{
    Author author = new (){FirstName = "Tom", LastName = 8, Location = "Ambala"};
    using var context = new AddDBContext();
    var author1 = context.Authors.Add(author);
    context.SaveChanges();
    Console.WriteLine("Record added!");
}


//FirstOrdefaultANdwhere  //If we will use for each then no need to use FirstOrDefault
//WHEREAuthors();

void WHEREAuthors()
{
    using var context = new AddDBContext();
    var author = context.Authors.Where(u=>u.Author_Id==2 && u.Location=="Pune").FirstOrDefault();
    Console.WriteLine(author.FirstName + "-" + author.LastName);
    //foreach (var item in author)
    //{
    //    Console.WriteLine(item.FirstName + "-" + item.LastName);
    //}
}


//FirstOrdefaultANdwhere  //If we will use for each then no need to use FirstOrDefault
//FirstOrDefaultAuthors();

void FirstOrDefaultAuthors()
{
    using var context = new AddDBContext();
    var author = context.Authors.FirstOrDefault(u => u.Author_Id == 2 && u.Location == "Pune");
    Console.WriteLine(author.FirstName + "-" + author.LastName);
}


//SingleOrSingleOrDefaultAuthors();

void SingleOrSingleOrDefaultAuthors()
{
    using var context = new AddDBContext();
    var author = context.Authors.Single(u => u.Author_Id == 2 && u.Location == "Pune");
    Console.WriteLine(author.FirstName + "-" + author.LastName);
}

//ContainsLikeAggregateFunctions();

void ContainsLikeAggregateFunctions()
{
    using var context = new AddDBContext();
    var author = context.Authors.Where(u => u.Location.Contains("Pune"));//.Max(u=>u.BirthDate);
    //var author = context.Authors.Where(u => EF.Functions.Like(u.Location,"Pu%"));
    foreach (var item in author)
    {
        Console.WriteLine(item.FirstName + "-" + item.LastName);
    }
}

//SortedList();

void SortedList()
{
    using var context = new AddDBContext();
    var author = context.Authors.Where(u => u.Location.Contains("Pune")).OrderBy(u=>u.BirthDate).ThenByDescending(u=>u.FirstName);//.Max(u=>u.BirthDate);
    //var author = context.Authors.Where(u => EF.Functions.Like(u.Location,"Pu%"));
    foreach (var item in author)
    {
        Console.WriteLine(item.FirstName + "-" + item.LastName);
    }
}

//Pagination();

void Pagination()
{
    using var context = new AddDBContext();
    var author = context.Authors.Skip(2).Take(3);
    //var author = context.Authors.Where(u => EF.Functions.Like(u.Location,"Pu%"));
    foreach (var item in author)
    {
        Console.WriteLine(item.FirstName + "-" + item.LastName);
    }
}

//FindAuthors();

void FindAuthors()
{
    using var context = new AddDBContext();
    var author = context.Authors.Find(2);

        Console.WriteLine(author.FirstName + "-" + author.LastName);
    
}

//UpdateUsingFind();
void UpdateUsingFind()
{
    using var context = new AddDBContext();
    var author = context.Authors.Find(2);
    author.Location = "Shimla";
    context.SaveChanges();
    
}

UpdateUsingWhere();
void UpdateUsingWhere()
{
    using var context = new AddDBContext();
    var author = context.Authors.Where(u=>u.Location=="Pune");
    foreach (var item in author)
    {
        item.Location = "Shimla";
    }
    context.SaveChanges();

}