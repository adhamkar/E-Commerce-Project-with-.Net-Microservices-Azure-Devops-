using E_Commerce.Core.Entities;

namespace E_Commerce.Core.DTOs;

public record UserAuthentificationResponse(
    Guid UsereID,
    string? Email, string? Password, 
    string? PersonName, string? Gender,
    string? Token, bool Success)
{
    //parametreless ctor
public UserAuthentificationResponse() : this (default, default, default, default,
    default, default, default){ }
}
