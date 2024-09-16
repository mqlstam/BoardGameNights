public IActionResult Create(Models.BoardgameNight boardgameNight)
{
    // ... existing code ...
    boardgameNight.Organizer = user;
    // ... existing code ...
}

// ... existing code ...

private void CreateSampleData()
{
    var person = new Person
    {
        Name = "John Doe",
        Street = "Main Street",
        HouseNumber = "123",
        City = "Anytown",
        // Add any other required properties
    };
    // ... existing code ...
}

// ... existing code ...