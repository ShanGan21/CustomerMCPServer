namespace CustomerMCPServer.data
{
    public record Order(int Id, int CustomerId, string Product, decimal Price, decimal Total, DateTime Date);
    
    
}