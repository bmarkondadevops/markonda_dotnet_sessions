

using Microsoft.EntityFrameworkCore.Query.Internal;
using SimpleEFProject.Data;
using SimpleEFProject.Domain;

//CaseSTudy1();

//CaseSTudy2();

CaseStudy3();

void CaseStudy3()
{
    var db = new RrdDbcontext();

    var customerlist = db.Customers
                  .ToList()
                  .Where(c => c.Id == 4)
                  .Select(c => new
                  {
                      c.Id,
                      c.Name,
                      c.City
                  }); //Deferred exeuction/lazy exuciton

    //var customerlist = query.ToList(); //imeedidately exeucte


    foreach (var c in customerlist)
    {
        Console.WriteLine(c.Name + " " + c.Id);
    }
}

void CaseSTudy2()
{
    var db = new RrdDbcontext();

    var query = db.Customers
                   
                  .Where(c => c.Id == 4)
                  .Select(c => new
                  {
                      c.Id,
                      c.Name,
                      c.City
                  }); //Deferred exeuction/lazy exuciton

    var customerlist =query.ToList(); //imeedidately exeucte


    foreach (var c in customerlist) {
        Console.WriteLine(c.Name + " "+c.Id);
    }
    


}

void CaseSTudy1()
{

    var c1 = new Customer { Name= "Sachin Dhopte",City="Mubmai" };

    var c2 = new Customer { Name = "Shalini", City = "Delhi" };

    var db = new RrdDbcontext();
    db.Customers.Add(c1);
    db.Customers.Add(c2);

    db.SaveChanges();

    Console.WriteLine("added tow customers");

}