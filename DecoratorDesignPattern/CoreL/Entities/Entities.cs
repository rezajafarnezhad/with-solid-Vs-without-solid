using System.ComponentModel.DataAnnotations;

namespace DecoratorDesignPattern.CoreL.Entities;

public class User
{
    [Key]
    public int UserId { get; set; }
    public string Email { get; set; }
    public string FullName { get; set; }
    public bool IsActive { get; set; }
}


public class UserTwo
{
     public int Age { get; set; }
    public string Name { get; set; }
    public bool IsActive { get; set; }
}

