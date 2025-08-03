using E_Commerce.Core.Entities;

namespace E_Commerce.Core.DTOs;

public record UserRegisterRequest(string? Email, string? Password, string? PersonName, Gender? Gender);
