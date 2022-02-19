using System.ComponentModel.DataAnnotations;

namespace Vynnyk01.Models.User
{
  public class ValidBirthDateAttribute : ValidationAttribute
  {
    public string GetErrorMessage() => "Birth Date is not valid";

    public override bool IsValid(object value)
    {
      if (value is UserModel user)
      {
        return user.BirthDate != default;
      }
      return false;
    }
  }
}
