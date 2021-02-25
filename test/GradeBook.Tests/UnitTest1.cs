using System;
using Xunit;

namespace GradeBook.Tests
{
    public class BookTests
    {
        [Fact]
        public void CalculationTest()
        {//arrage
        var book= new Book("");
        book.AddGrade(10);
        book.AddGrade(40);
          
        //act
          var result =book.GetStatistics(); 
        //assert
     Assert.Equal(25,result.Avarage);

        }
    }
}
