using Xunit;
using Lab2Q5;

namespace Lab2Q5Test;
public class UnitTest1{
    [Fact]
	public void TestEqual2Numbers() {
	
		int n1 = 5; // arrange
		int n2 = 5; // arrange
		double expected = 5;
	
		double actual = NumCompare.Max(n1,n2); // act
 
		Assert.Equal(expected, actual); // assert
	}	
    [Fact]
	public void TestDiff2Numbers() {
	
		int n1 = 15; // arrange
		int n2 = 85; // arrange
		double expected = 85;
	
		double actual = NumCompare.Max(n1,n2); // act
 
		Assert.Equal(expected, actual); // assert
	}
    [Fact]
	public void TestDiff3Numbers() {
	
		int n1 = 15; // arrange
		int n2 = 25; // arrange
		int n3 = 5; // arrange
		double expected = 25;
	
		double actual = NumCompare.Max(n1,n2,n3); // act
 
		Assert.Equal(expected, actual); // assert
	}
    [Fact]
	public void TestSame3Numbers() {
	
		int n1 = 18; // arrange
		int n2 = 18; // arrange
		int n3 = 18; // arrange
		double expected = 18;
	
		double actual = NumCompare.Max(n1,n2,n3); // act
 
		Assert.Equal(expected, actual); // assert
	}	
}
