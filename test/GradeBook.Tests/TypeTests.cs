using System;
using Xunit;

namespace GradeBook.Tests
//delegates give us variable that I can use like method.
//delete type ile belirttiğim koşulu sağlayan herhangi bir metodu invoke edebilirim.
{   
    public delegate string WriteLogDelegete(string logMessage);
    public class TypeTests
    {
        int count = 0;
      
      [Fact]
      public void WriteLogDelegeteCanPointMethod(){
WriteLogDelegete log;
//log =new WriteLogDelegete(ReturnMessage); uzun hali
//log=ReturnMessage;
log =new WriteLogDelegete(ReturnMessage); 
log +=ReturnMessage; //2 kere ReturnMessage metodu çağrıldı
log +=Count;        //1 kere de Count metodu çağırıldı.

var result =log("Hello");
//Assert.Equal("Hello",result);
Assert.Equal(3,count);}

      string ReturnMessage(string message){
          count++;
          return message;
      }
string Count(string message){
    count++;
          return message;
      }

        [Fact]
        public void Test1()
        {
            var book1 = GetBook("Book 1");
            SetName(book1,"New name");

            
            Assert.Equal("New name",book1.Name);
 

        }

private void SetName(Book book,string name){
   book.Name=name;
}
        Book GetBook(string name){

            return new Book(name);
        }
    }
}
