using System;
using System.Collections.Generic;

namespace GradeBook
{
   
    class Program
    {
        static void Main(string[] args)
        {

var id =Console.ReadLine();
Book book= givemestudentId(id);
System.Console.WriteLine(book.Name);
book.Name="hell";
System.Console.WriteLine(book.Name);

 
 while(true){
 System.Console.WriteLine("Enter Grades");
   var input =Console.ReadLine();

   if(input=="q"){
       break;
   }
    

   var grade =double.Parse(input);
   book.AddGrade(grade);
   
        } 

        Statistics stat= book.GetStatistics();
        stat=book.GetStatistics();
           System.Console.WriteLine(stat.High);
             System.Console.WriteLine(stat.Low);
               System.Console.WriteLine(stat.Avarage);

      
        }

        public static Book givemestudentId(string id){
        var book = new Book(id); 
        return book;
   }
    }
}

