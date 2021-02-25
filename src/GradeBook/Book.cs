using System;
using System.Collections.Generic;
namespace GradeBook{
    public class Book
    {
    public Book(string name){
    grades=new List<double>();
    this.name=name;
      
    }
    List<double> grades;
private string name;
         public string Name{
             get{
                 return name;
                  }
                  
                set{
                    if(value!="hell"){name=value;}
                 
                  }  }
         int s;

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
