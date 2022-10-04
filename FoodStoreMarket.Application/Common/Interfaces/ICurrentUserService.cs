namespace FoodStoreMarket.Application.Interfaces;

public interface ICurrentUserService
{ 
    string Email { get; set; } 
    bool IsAuthenticated { get; set; }
    string Role { get; set; }
}