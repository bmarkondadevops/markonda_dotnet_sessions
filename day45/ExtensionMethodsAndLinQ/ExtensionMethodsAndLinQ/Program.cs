



using ExtensionMethodsAndLinQ.Extensions;
using ExtensionMethodsAndLinQ.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

CaseSTudy1();

//CaseStudy2();

//CaseStudy3();

//CaseStudy4();
//CaseStudy5();

//CaseStudy6();
//CaseStudy7();

void CaseStudy7()
{
    var mynames = new string[] { "Sachin", "Minu", "Venakatesh", "Akhil" ,"sahlini"};
    var query1 = mynames.Where((n) => n.ToLower().Contains("s"));//deferred
    var query2 = query1.OrderBy((SortByLength));//deferred

    var listOfNamesWithS = query2.ToList();//Immediate execution

    Console.WriteLine(listOfNamesWithS.Count);

    listOfNamesWithS.ForEach((n) => Console.WriteLine(n.ToString().ToUpper()));
}

void CaseStudy6()
{
    IEnumerable<string> mynames = new string[] { "Sachin", "Minu", "Venakat","Akhil" };
    IEnumerable<string> orderednames= mynames.OrderBy(SortByAlphabet);
    foreach (var item in orderednames)
    {
        Console.WriteLine(item);
    }
}

string SortByAlphabet(string name)
{
    return name;
}
int SortByLength(string name) { 
    return name.Length; 
}
void CaseStudy5()
{
    var mynames = new string[] { "Sachin", "Minu", "Venakat" };

    foreach (var item in mynames) {
        Console.WriteLine(item);
    }
}

void CaseStudy4()
{
    IEnumerable<string> mynames = new string[] {  "Sachin","Minu","Venakat" };

    IEnumerator<string> dataReader = mynames.GetEnumerator();
    while (dataReader.MoveNext()) {
        Console.WriteLine(dataReader.Current);
    }
}

void CaseStudy3()
{
    var name = "Akhilesh";
    Console.WriteLine(name.HelloRRD());

    var acc = new Account { Name = "Sachin" };
    acc.PrintAccountDetails();

}

void CaseStudy2()
{
    
    Func<string,bool> isLongName= (n)=> {

       Console.WriteLine("inside a function");
       return n.Length > 8;
       
       
       };

   Console.WriteLine(isLongName("Venakat"));


    Action<int, int> add = (n1, n2) => {

        Console.WriteLine("inside add proecuedure");
        Console.WriteLine($"Addition result is {n1 + n2}");
        
        };

    add(10, 20);

    //Predicate<int> isEven = (n) =>
    //{
    //    return n % 2==0;
    //    //if(n%2 == 0)
    //    //      return true;
    //    //else
    //    //    return false;
    //};
    Predicate<int> isEven = (n) => n % 2 == 0;


    Console.WriteLine(isEven(10));

}

void CaseSTudy1()
{
    Func<string, bool> isALongName = CheckIfNameIsLong;

    Console.WriteLine(isALongName("Sachin Dhopte"));




}

bool CheckIfNameIsLong(string name) {
    return name.Length > 8;
    
}