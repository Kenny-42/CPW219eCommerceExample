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
    /// Alphanumberic characters only
    /// </summary>
    public required string Username { get; set; }

    /// <summary>
    /// Email for the member
    /// </summary>
    public required string Email { get; set; }

    /// <summary>
    /// The member's password
    /// </summary>
    public required string Password { get; set; }

    /// <summary>
    /// Date of birth for the member
    /// </summary>
    public DateOnly DateOfBirth { get; set; }
}
