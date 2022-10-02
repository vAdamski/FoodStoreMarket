using Application.UnitTests.Common;
using AutoMapper;
using FoodStoreMarket.Application.Restaurants.Commands.CreateRestaurant;
using FoodStoreMarket.Common;
using Microsoft.EntityFrameworkCore;
using Shouldly;

namespace Application.UnitTests.Restaurants.Commands.CreateRestaurant;

public class CreateRestaurantHandlerTests : CommandTestBase, IClassFixture<CommandTestFixture>
{
    private readonly CreateRestaurantCommandHandler _handler;
    private readonly IMapper _mapper;

    public CreateRestaurantHandlerTests(CommandTestFixture fixture) : base()
    {
        _mapper = fixture.Mapper;
        _handler = new CreateRestaurantCommandHandler(_context, _mapper);
    }

    [Fact]
    public async Task Handle_GivenValidRequest_ShouldInsertRestaurant()
    {
        var command = new CreateRestaurantCommand()
        {
            Name = "Kebsik",
            Description = "Kebsik w Łodzi",
            City = "Lodz",
            PostCode = "94-001",
            Street = "Łódzka",
            HouseNumber = "1",
            FlatNumber = "",
            PhoneNumber = "123123123",
            Email = "kebsik@test.com"
        };

        var result = await _handler.Handle(command, CancellationToken.None);

        var restaurant = await _context.Restaurants.FirstAsync(x => x.Id == result, CancellationToken.None);
        
        restaurant.ShouldNotBeNull();
    }

    [Fact]
    public async Task Handle_GivenInvalidRequestName_ShouldReturnBadRequest()
    {
        try
        {
            var command = new CreateRestaurantCommand()
            {
                Name = "",
                Description = "Kebsik w Łodzi",
                City = "Lodz",
                PostCode = "94-001",
                Street = "Łódzka",
                HouseNumber = "1",
                FlatNumber = "",
                PhoneNumber = "123123123",
                Email = "kebsik@test.com"
            };

            var result = await _handler.Handle(command, CancellationToken.None);

            var restaurant = await _context.Restaurants.FirstAsync(x => x.Id == result, CancellationToken.None);

            restaurant.ShouldBeNull();
        }
        catch(Exception exception)
        {
            var code = (int)ExceptionHttpCode.GetHttpCodeFormException(exception);
            code.ShouldBe(400);
        }
    }
    
    [Fact]
    public async Task Handle_GivenInvalidRequestNameTooLong_ShouldReturnBadRequest()
    {
        try
        {
            var command = new CreateRestaurantCommand()
            {
                Name = GenerateRandomString.NextStrings(new Random(), 101),
                Description = "Kebsik w Łodzi",
                City = "Lodz",
                PostCode = "94-001",
                Street = "Łódzka",
                HouseNumber = "1",
                FlatNumber = "",
                PhoneNumber = "123123123",
                Email = "kebsik@test.com"
            };

            var result = await _handler.Handle(command, CancellationToken.None);

            var restaurant = await _context.Restaurants.FirstAsync(x => x.Id == result, CancellationToken.None);

            restaurant.ShouldBeNull();
        }
        catch(Exception exception)
        {
            var code = (int)ExceptionHttpCode.GetHttpCodeFormException(exception);
            code.ShouldBe(400);
        }
    }
    
    [Fact]
    public async Task Handle_GivenInvalidRequestNameIsNull_ShouldReturnBadRequest()
    {
        try
        {
            var command = new CreateRestaurantCommand()
            {
                Name = null,
                Description = "Kebsik w Łodzi",
                City = "Lodz",
                PostCode = "94-001",
                Street = "Łódzka",
                HouseNumber = "1",
                FlatNumber = "",
                PhoneNumber = "123123123",
                Email = "kebsik@test.com"
            };

            var result = await _handler.Handle(command, CancellationToken.None);

            var restaurant = await _context.Restaurants.FirstAsync(x => x.Id == result, CancellationToken.None);

            restaurant.ShouldBeNull();
        }
        catch(Exception exception)
        {
            var code = (int)ExceptionHttpCode.GetHttpCodeFormException(exception);
            code.ShouldBe(400);
        }
    }
    
    [Fact]
    public async Task Handle_GivenInvalidRequestDescriptionIsNull_ShouldReturnBadRequest()
    {
        try
        {
            var command = new CreateRestaurantCommand()
            {
                Name = "Kebsik",
                Description = null,
                City = "Lodz",
                PostCode = "94-001",
                Street = "Łódzka",
                HouseNumber = "1",
                FlatNumber = "",
                PhoneNumber = "123123123",
                Email = "kebsik@test.com"
            };

            var result = await _handler.Handle(command, CancellationToken.None);

            var restaurant = await _context.Restaurants.FirstAsync(x => x.Id == result, CancellationToken.None);

            restaurant.ShouldBeNull();
        }
        catch(Exception exception)
        {
            var code = (int)ExceptionHttpCode.GetHttpCodeFormException(exception);
            code.ShouldBe(400);
        }
    }
    
    [Fact]
    public async Task Handle_GivenInvalidRequestDescriptionIsTooLong_ShouldReturnBadRequest()
    {
        try
        {
            var command = new CreateRestaurantCommand()
            {
                Name = "Kebsik",
                Description = GenerateRandomString.NextStrings(new Random(), 101),
                City = "Lodz",
                PostCode = "94-001",
                Street = "Łódzka",
                HouseNumber = "1",
                FlatNumber = "",
                PhoneNumber = "123123123",
                Email = "kebsik@test.com"
            };

            var result = await _handler.Handle(command, CancellationToken.None);

            var restaurant = await _context.Restaurants.FirstAsync(x => x.Id == result, CancellationToken.None);

            restaurant.ShouldBeNull();
        }
        catch(Exception exception)
        {
            var code = (int)ExceptionHttpCode.GetHttpCodeFormException(exception);
            code.ShouldBe(400);
        }
    }
    
    [Fact]
    public async Task Handle_GivenInvalidRequestCityIsNull_ShouldReturnBadRequest()
    {
        try
        {
            var command = new CreateRestaurantCommand()
            {
                Name = "Kebsik",
                Description = "Test",
                City = null,
                PostCode = "94-001",
                Street = "Łódzka",
                HouseNumber = "1",
                FlatNumber = "",
                PhoneNumber = "123123123",
                Email = "kebsik@test.com"
            };

            var result = await _handler.Handle(command, CancellationToken.None);

            var restaurant = await _context.Restaurants.FirstAsync(x => x.Id == result, CancellationToken.None);

            restaurant.ShouldBeNull();
        }
        catch(Exception exception)
        {
            var code = (int)ExceptionHttpCode.GetHttpCodeFormException(exception);
            code.ShouldBe(400);
        }
    }
    
    [Fact]
    public async Task Handle_GivenInvalidRequestCityPropertyIsTooLong_ShouldReturnBadRequest()
    {
        try
        {
            var command = new CreateRestaurantCommand()
            {
                Name = "Kebsik",
                Description = "Test",
                City = GenerateRandomString.NextStrings(new Random(), 26),
                PostCode = "94-001",
                Street = "Łódzka",
                HouseNumber = "1",
                FlatNumber = "",
                PhoneNumber = "123123123",
                Email = "kebsik@test.com"
            };

            var result = await _handler.Handle(command, CancellationToken.None);

            var restaurant = await _context.Restaurants.FirstAsync(x => x.Id == result, CancellationToken.None);

            restaurant.ShouldBeNull();
        }
        catch(Exception exception)
        {
            var code = (int)ExceptionHttpCode.GetHttpCodeFormException(exception);
            code.ShouldBe(400);
        }
    }
    
    [Fact]
    public async Task Handle_GivenInvalidRequestPostCodeIsNull_ShouldReturnBadRequest()
    {
        try
        {
            var command = new CreateRestaurantCommand()
            {
                Name = "Kebsik",
                Description = "Test",
                City = "Lodz",
                PostCode = null,
                Street = "Łódzka",
                HouseNumber = "1",
                FlatNumber = "",
                PhoneNumber = "123123123",
                Email = "kebsik@test.com"
            };

            var result = await _handler.Handle(command, CancellationToken.None);

            var restaurant = await _context.Restaurants.FirstAsync(x => x.Id == result, CancellationToken.None);

            restaurant.ShouldBeNull();
        }
        catch(Exception exception)
        {
            var code = (int)ExceptionHttpCode.GetHttpCodeFormException(exception);
            code.ShouldBe(400);
        }
    }
    
    [Fact]
    public async Task Handle_GivenInvalidRequestPostCodeIsTooLong_ShouldReturnBadRequest()
    {
        try
        {
            var command = new CreateRestaurantCommand()
            {
                Name = "Kebsik",
                Description = "Test",
                City = "Lodz",
                PostCode = GenerateRandomString.NextStrings(new Random(), 11),
                Street = "Łódzka",
                HouseNumber = "1",
                FlatNumber = "",
                PhoneNumber = "123123123",
                Email = "kebsik@test.com"
            };

            var result = await _handler.Handle(command, CancellationToken.None);

            var restaurant = await _context.Restaurants.FirstAsync(x => x.Id == result, CancellationToken.None);

            restaurant.ShouldBeNull();
        }
        catch(Exception exception)
        {
            var code = (int)ExceptionHttpCode.GetHttpCodeFormException(exception);
            code.ShouldBe(400);
        }
    }
    
    [Fact]
    public async Task Handle_GivenInvalidRequestStreetIsNull_ShouldReturnBadRequest()
    {
        try
        {
            var command = new CreateRestaurantCommand()
            {
                Name = "Kebsik",
                Description = "Test",
                City = "Lodz",
                PostCode = "94-000",
                Street = null,
                HouseNumber = "1",
                FlatNumber = "",
                PhoneNumber = "123123123",
                Email = "kebsik@test.com"
            };

            var result = await _handler.Handle(command, CancellationToken.None);

            var restaurant = await _context.Restaurants.FirstAsync(x => x.Id == result, CancellationToken.None);

            restaurant.ShouldBeNull();
        }
        catch(Exception exception)
        {
            var code = (int)ExceptionHttpCode.GetHttpCodeFormException(exception);
            code.ShouldBe(400);
        }
    }
    
    [Fact]
    public async Task Handle_GivenInvalidRequestStreetIsTooLong_ShouldReturnBadRequest()
    {
        try
        {
            var command = new CreateRestaurantCommand()
            {
                Name = "Kebsik",
                Description = "Test",
                City = "Lodz",
                PostCode = "94-000",
                Street = GenerateRandomString.NextStrings(new Random(), 26),
                HouseNumber = "1",
                FlatNumber = "",
                PhoneNumber = "123123123",
                Email = "kebsik@test.com"
            };

            var result = await _handler.Handle(command, CancellationToken.None);

            var restaurant = await _context.Restaurants.FirstAsync(x => x.Id == result, CancellationToken.None);

            restaurant.ShouldBeNull();
        }
        catch(Exception exception)
        {
            var code = (int)ExceptionHttpCode.GetHttpCodeFormException(exception);
            code.ShouldBe(400);
        }
    }
    
    [Fact]
    public async Task Handle_GivenInvalidRequestHouseNumberIsNull_ShouldReturnBadRequest()
    {
        try
        {
            var command = new CreateRestaurantCommand()
            {
                Name = "Kebsik",
                Description = "Test",
                City = "Lodz",
                PostCode = "94-000",
                Street = "al.Politechniki",
                HouseNumber = null,
                FlatNumber = "",
                PhoneNumber = "123123123",
                Email = "kebsik@test.com"
            };

            var result = await _handler.Handle(command, CancellationToken.None);

            var restaurant = await _context.Restaurants.FirstAsync(x => x.Id == result, CancellationToken.None);

            restaurant.ShouldBeNull();
        }
        catch(Exception exception)
        {
            var code = (int)ExceptionHttpCode.GetHttpCodeFormException(exception);
            code.ShouldBe(400);
        }
    }
    
    
    [Fact]
    public async Task Handle_GivenInvalidRequestHouseNumberIsEmpty_ShouldReturnBadRequest()
    {
        try
        {
            var command = new CreateRestaurantCommand()
            {
                Name = "Kebsik",
                Description = "Test",
                City = "Lodz",
                PostCode = "94-000",
                Street = "al.Politechniki",
                HouseNumber = "",
                FlatNumber = "",
                PhoneNumber = "123123123",
                Email = "kebsik@test.com"
            };

            var result = await _handler.Handle(command, CancellationToken.None);

            var restaurant = await _context.Restaurants.FirstAsync(x => x.Id == result, CancellationToken.None);

            restaurant.ShouldBeNull();
        }
        catch(Exception exception)
        {
            var code = (int)ExceptionHttpCode.GetHttpCodeFormException(exception);
            code.ShouldBe(400);
        }
    }
    
    [Fact]
    public async Task Handle_GivenInvalidRequestHouseNumberIsTooLong_ShouldReturnBadRequest()
    {
        try
        {
            var command = new CreateRestaurantCommand()
            {
                Name = "Kebsik",
                Description = "Test",
                City = "Lodz",
                PostCode = "94-000",
                Street = "al.Politechniki",
                HouseNumber = GenerateRandomString.NextStrings(new Random(), 6),
                FlatNumber = "",
                PhoneNumber = "123123123",
                Email = "kebsik@test.com"
            };

            var result = await _handler.Handle(command, CancellationToken.None);

            var restaurant = await _context.Restaurants.FirstAsync(x => x.Id == result, CancellationToken.None);

            restaurant.ShouldBeNull();
        }
        catch(Exception exception)
        {
            var code = (int)ExceptionHttpCode.GetHttpCodeFormException(exception);
            code.ShouldBe(400);
        }
    }
    
    [Fact]
    public async Task Handle_GivenInvalidRequestFlatNumberIsNull_ShouldReturnBadRequest()
    {
        try
        {
            var command = new CreateRestaurantCommand()
            {
                Name = "Kebsik",
                Description = "Test",
                City = "Lodz",
                PostCode = "94-000",
                Street = "al.Politechniki",
                HouseNumber = "1",
                FlatNumber = null,
                PhoneNumber = "123123123",
                Email = "kebsik@test.com"
            };

            var result = await _handler.Handle(command, CancellationToken.None);

            var restaurant = await _context.Restaurants.FirstAsync(x => x.Id == result, CancellationToken.None);

            restaurant.ShouldBeNull();
        }
        catch(Exception exception)
        {
            var code = (int)ExceptionHttpCode.GetHttpCodeFormException(exception);
            code.ShouldBe(400);
        }
    }
    
    [Fact]
    public async Task Handle_GivenInvalidRequestFlatNumberIsTooLong_ShouldReturnBadRequest()
    {
        try
        {
            var command = new CreateRestaurantCommand()
            {
                Name = "Kebsik",
                Description = "Test",
                City = "Lodz",
                PostCode = "94-000",
                Street = "al.Politechniki",
                HouseNumber = "1",
                FlatNumber = GenerateRandomString.NextStrings(new Random(), 21),
                PhoneNumber = "123123123",
                Email = "kebsik@test.com"
            };

            var result = await _handler.Handle(command, CancellationToken.None);

            var restaurant = await _context.Restaurants.FirstAsync(x => x.Id == result, CancellationToken.None);

            restaurant.ShouldBeNull();
        }
        catch(Exception exception)
        {
            var code = (int)ExceptionHttpCode.GetHttpCodeFormException(exception);
            code.ShouldBe(400);
        }
    }
    
    [Fact]
    public async Task Handle_GivenInvalidRequestPhoneNumberIsNull_ShouldReturnBadRequest()
    {
        try
        {
            var command = new CreateRestaurantCommand()
            {
                Name = "Kebsik",
                Description = "Test",
                City = "Lodz",
                PostCode = "94-000",
                Street = "al.Politechniki",
                HouseNumber = "1",
                FlatNumber = "",
                PhoneNumber = null,
                Email = "kebsik@test.com"
            };

            var result = await _handler.Handle(command, CancellationToken.None);

            var restaurant = await _context.Restaurants.FirstAsync(x => x.Id == result, CancellationToken.None);

            restaurant.ShouldBeNull();
        }
        catch(Exception exception)
        {
            var code = (int)ExceptionHttpCode.GetHttpCodeFormException(exception);
            code.ShouldBe(400);
        }
    }
    
    [Fact]
    public async Task Handle_GivenInvalidRequestPhoneNumberIsTooShort_ShouldReturnBadRequest()
    {
        try
        {
            var command = new CreateRestaurantCommand()
            {
                Name = "Kebsik",
                Description = "Test",
                City = "Lodz",
                PostCode = "94-000",
                Street = "al.Politechniki",
                HouseNumber = "1",
                FlatNumber = "",
                PhoneNumber = "123456",
                Email = "kebsik@test.com"
            };

            var result = await _handler.Handle(command, CancellationToken.None);

            var restaurant = await _context.Restaurants.FirstAsync(x => x.Id == result, CancellationToken.None);

            restaurant.ShouldBeNull();
        }
        catch(Exception exception)
        {
            var code = (int)ExceptionHttpCode.GetHttpCodeFormException(exception);
            code.ShouldBe(400);
        }
    }
    
    [Fact]
    public async Task Handle_GivenInvalidRequestPhoneNumberIsTooLong_ShouldReturnBadRequest()
    {
        try
        {
            var command = new CreateRestaurantCommand()
            {
                Name = "Kebsik",
                Description = "Test",
                City = "Lodz",
                PostCode = "94-000",
                Street = "al.Politechniki",
                HouseNumber = "1",
                FlatNumber = "",
                PhoneNumber = "12345678901",
                Email = "kebsik@test.com"
            };

            var result = await _handler.Handle(command, CancellationToken.None);

            var restaurant = await _context.Restaurants.FirstAsync(x => x.Id == result, CancellationToken.None);

            restaurant.ShouldBeNull();
        }
        catch(Exception exception)
        {
            var code = (int)ExceptionHttpCode.GetHttpCodeFormException(exception);
            code.ShouldBe(400);
        }
    }
    
    [Fact]
    public async Task Handle_GivenInvalidRequestEmailIsNull_ShouldReturnBadRequest()
    {
        try
        {
            var command = new CreateRestaurantCommand()
            {
                Name = "Kebsik",
                Description = "Test",
                City = "Lodz",
                PostCode = "94-000",
                Street = "al.Politechniki",
                HouseNumber = "1",
                FlatNumber = "",
                PhoneNumber = "123456789",
                Email = null
            };

            var result = await _handler.Handle(command, CancellationToken.None);

            var restaurant = await _context.Restaurants.FirstAsync(x => x.Id == result, CancellationToken.None);

            restaurant.ShouldBeNull();
        }
        catch(Exception exception)
        {
            var code = (int)ExceptionHttpCode.GetHttpCodeFormException(exception);
            code.ShouldBe(400);
        }
    }
    
    [Fact]
    public async Task Handle_GivenInvalidRequestEmailIsNotValid_ShouldReturnBadRequest()
    {
        try
        {
            var command = new CreateRestaurantCommand()
            {
                Name = "Kebsik",
                Description = "Test",
                City = "Lodz",
                PostCode = "94-000",
                Street = "al.Politechniki",
                HouseNumber = "1",
                FlatNumber = "",
                PhoneNumber = "123456789",
                Email = "testtest.pl"
            };

            var result = await _handler.Handle(command, CancellationToken.None);

            var restaurant = await _context.Restaurants.FirstAsync(x => x.Id == result, CancellationToken.None);

            restaurant.ShouldBeNull();
        }
        catch(Exception exception)
        {
            var code = (int)ExceptionHttpCode.GetHttpCodeFormException(exception);
            code.ShouldBe(400);
        }
    }
}