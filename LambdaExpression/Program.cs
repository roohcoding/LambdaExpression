// See https://aka.ms/new-console-template for more information
using LambdaExpression;

Console.WriteLine("Hello, World!");
List<Person> listPersonInCity = new List<Person>();
LambdaDemo.AddRecords(listPersonInCity);
//Retrieving_TopTwoRecord_ForAgels_LessThanSixty(listPersonInCity);
LambdaDemo.CheckingForTeenagerPerson(listPersonInCity);
LambdaDemo.AllPersonsAverageAge(listPersonInCity);
LambdaDemo.CheckNameExistOrNot(listPersonInCity);
Console.ReadKey();