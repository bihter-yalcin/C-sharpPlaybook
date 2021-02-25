using System;
using Xunit;

namespace GradeBook.Tests
{
    public class TypeTests
    {
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
