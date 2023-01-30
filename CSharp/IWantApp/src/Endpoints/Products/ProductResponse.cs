namespace IWantApp.Endpoints.Products;

public record ProductResponse(string Name, string CategoryName, string Descrition, bool HasStock,decimal Price, bool Active);
