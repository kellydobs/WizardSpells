using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Microsoft.AspNetCore.Identity;


namespace WizardSpellsAPI.Models
{
    public class User
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "You must provide a name")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "You must provide your email")]
        public string Email { get; set; }

        [JsonIgnore]
        public string HashedPassword { get; set; }


        public string Password
        {   //only define the 'set' aspect of the property
            set
            {
                //when set, use the PasswordHasher to encrypt the password
                this.HashedPassword = new PasswordHasher<User>.HashedPassword(this, value);
            }
        }
        //add a method to validate this user's password
        public bool IsValidPassword(string password)
        {
            var passwordVerification = new PasswordHasher<User>().VerifyHashedPassword(this, this.HashedPassword, password);

            return passwordVerification == passwordVerificationResult.Success;

        }

    }
}


