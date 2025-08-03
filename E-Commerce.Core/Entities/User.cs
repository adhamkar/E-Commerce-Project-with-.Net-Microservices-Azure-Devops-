using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.Core.Entities;

public class User
{
    public Guid UserID { get; set; }
    public string? Email { get; set; }

    public string? PersonName { get; set; }

    public string? Password { get; set; }

    public Gender? Gender { get; set; }


}
public enum Gender
{
    Male,Female
}
