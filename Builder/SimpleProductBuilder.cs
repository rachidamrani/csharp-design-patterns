namespace Builder;

public class SimpleProductBuilder : IBuilder
{
    private string _name = String.Empty;
    private string _description = String.Empty;
    
    public void BuildName()
    {
        _description = "This is a simple product";
    }

    public void BuildDescription()
    {
        _name = "Simple Product";
    }

    public Product Build()
    { 
        return new Product(Name: _name, Description: _description);
    }
}