using System;
using System.Collections.Generic;
namespace GradeBook{
    public class Book
    {
    public Book(string name){
    grades=new List<double>();
    Name=name;

   unchangable="but_changed"; //we can only change our readonly in constructor 
    }
    readonly string unchangable="unchangable";
    //unchangable="jkk"; this won't work 
    List<double> grades;

    public string Name{get;  set;} //adı konulduktan sonra değiştirilemez
//  public string Name{get; private set;} 
public void readonlyy(string hello){
    hello=unchangable;
    System.Console.WriteLine(hello);

}
 public  void AddGrade(double grade){
  
if(grade>0 && grade<=100){
grades.Add(grade);
}
}


public double avarage(){
   
    var result=0.0;
    foreach(double h in grades){
    result+=h;
    }
    result=result/grades.Count;
    return result;    
}

public Statistics GetStatistics()
{
    var result= new Statistics();

    result.Avarage= avarage();
    result.Low = double.MaxValue;
    result.High = double.MinValue;
    foreach(var h in grades){
        result.Low= Math.Min(h,result.Low);
        result.High= Math.Max(h,result.High);
        }

    return result;
}

public void AddLetterGrade(char letter){
    switch(letter)
    { case 'A':
       AddGrade(90);
       break;
      case 'B':
       AddGrade(80);
       break;

       case 'C':
       AddGrade(70);
       break;

      default:
      AddGrade(0);
      break;



    }
}
 
    }
}
