namespace eCommerce.Models;
using System.ComponentModel.DataAnnotations;

/// <summary>
/// Represents an individual website user
/// </summary>
public class Member
{
    /// <summary>
    /// Unique identifier for the member
    /// </summary>
    [Key]
    public int MemberId { get; set; }

    /// <summary>
    /// Public facing username for the member.
    /// Alphanumberic characters only up to 25 characters.
    /// </summary>
    [RegularExpression("^[a-zA-Z0-9]*$", 
        ErrorMessage = "Username must be alphanumberic only.")]
    [StringLength(25)]
    public required string Username { get; set; }

    /// <summary>
    /// Email for the member
    /// </summary>
    public required string Email { get; set; }

    /// <summary>
    /// The member's password
    /// </summary>
    [StringLength(50, MinimumLength = 6, 
        ErrorMessage = "Your password must be between 6 and 50 characters")]
    public required string Password { get; set; }

    /// <summary>
    /// Date of birth for the member
    /// </summary>
    public DateOnly DateOfBirth { get; set; }
}

public class RegistrationViewModel
{
    /// <summary>
    /// Unique identifier for the member
    /// </summary>
    [Key]
    public int MemberId { get; set; }

    /// <summary>
    /// Public facing username for the member.
    /// Alphanumberic characters only up to 25 characters.
    /// </summary>
    [RegularExpression("^[a-zA-Z0-9]*$",
        ErrorMessage = "Username must be alphanumberic only.")]
    [StringLength(25)]
    public required string Username { get; set; }

    /// <summary>
    /// Email for the member
    /// </summary>
    [DataType(DataType.EmailAddress)]
    public required string Email { get; set; }

    /// <summary>
    /// The member's password
    /// </summary>
    [StringLength(50, MinimumLength = 6,
        ErrorMessage = "Your password must be between 6 and 50 characters")]
    [DataType(DataType.Password)]
    public required string Password { get; set; }

    [Compare(nameof(Password))]
    [DataType(DataType.Password)]
    public required string ConfirmPassword { get; set; }

    /// <summary>
    /// Date of birth for the member
    /// </summary>
    [DataType(DataType.Date)]
    public DateOnly DateOfBirth { get; set; }
}

public class LoginViewModel
{
    public required string UsernameOrEmail { get; set; }

    [DataType(DataType.Password)]
    public required string Password { get; set; }
}