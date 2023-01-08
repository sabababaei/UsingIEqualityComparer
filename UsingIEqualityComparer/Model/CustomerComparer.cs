namespace UsingIEqualityComparer.Model;

public class CustomerComparerOnName:IEqualityComparer<Customers>
{
    public bool Equals(Customers? x, Customers? y)
    {
        if (x.Name == y.Name)
            return true;
        return false;

    }

    public int GetHashCode(Customers obj)
    {
        return obj.Name.GetHashCode();
    }
}

public class CustomerComparerOnNameAndCity:IEqualityComparer<Customers>
{
    public bool Equals(Customers? x, Customers? y)
    {
        if (x.Name == y.Name && x.City==y.City)
            return true;
        return false;

    }

    public int GetHashCode(Customers obj)
    {
        return obj.Name.GetHashCode();
    }
}