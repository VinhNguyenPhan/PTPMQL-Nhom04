using System.ComponentModel.DataAnnotations;
namespace MvcMovie.Models;
public class Person
{
    //id, fullname, address
    public string? PersonId {get; set;}
    public string? FullName {get; set;}
    public string? Address {get; set;}
}