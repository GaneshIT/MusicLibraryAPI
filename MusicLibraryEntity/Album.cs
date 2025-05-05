using System.ComponentModel.DataAnnotations;

namespace MusicLibraryEntity
{
    public class Album
    {
        [Key] //primary key- Identity
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}


/*
 * 1. ADO.NET
 * 2. EntityFrameworkCore - SQL Constriants must be set
 *     ORM(Object Relational Mapping) Pattern
 *      ->Database First Approach
 *      ->Code First Approach
 * 
 * EntityFrameworkCore setup
 * --install packages
 *   1. EntityFrameworkCore
 *   2. EntityFrameworkCore.Sqlserver
 *   3. EntityFrameworkCore.Tools -> use commands to DB setup
 */

//class A
//{}
//class B : A
//{
//    A objA=new A(); public void FuncB() { }
//}
//class C : B
//{
//   B objB=new B(); public void FuncC() { }
//}
//main(){ C objC=new C(); }

//DI Pattern
//step 1->Interface
//spte 2->Pass reference of interface over constructor

//SOLID
//abstract  class Report
//{
//}
//class PDF : Report { }
//class Excel:Report { }

//Report report= new PDF();
//Report report2 = new Excel();

//Generate generate=new Generate(report);
//class Generate
//{
//    public Generate(Report r) { }
//}


