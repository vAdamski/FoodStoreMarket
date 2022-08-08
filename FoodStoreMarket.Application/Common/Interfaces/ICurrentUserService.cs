namespace FoodStoreMarket.Application.Interfaces;

public class ICurrentUserService
{ 
    public string Email { get; set; } 
    public bool IsAuthenticated { get; set; }
}