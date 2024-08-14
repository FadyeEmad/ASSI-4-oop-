//ASSI 4 OOP
#region part 1
#region q1
//b) To define a blueprint for a class
#endregion

#region q2
//a) private

#endregion

#region q3
//b) No
#endregion
#region q4
//b) Yes, interfaces can inherit from multiple interfaces
#endregion

#region q5
//d) implements
#endregion

#region q6
//a) Yes
#endregion

#region q7
//b) No, all members are implicitly public
#endregion

#region q8
//b) To provide a clear separation between interface and class members
#endregion

#region q9
//b) No, interfaces cannot have constructors

#endregion

#region q10
//c) By separating interface names with commas
#endregion
#endregion


#region part2
#region q1
internal interface Ishape
{
    double area { get; set; }
    void DisplayShapeInfo();
}

internal interface IRectangle : Ishape
{
}

internal interface ICircle : Ishape
{
}


internal class circle : ICircle
{
    public double area { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

    public void DisplayShapeInfo()
    {
        throw new NotImplementedException();
    }
}

internal class Rectangle : IRectangle
{
    public double area { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

    public void DisplayShapeInfo()
    {
        throw new NotImplementedException();
    }
}

#endregion

#region q2
public interface IAuthenticationService
{
    bool AuthorizeUser(string name, string password);
    bool AuthenticateUser(string username, string password);

}
internal class BasicAuthenticationService : IAuthenticationService
{
    public bool AuthenticateUser(string username, string password)
    {
        throw new NotImplementedException();
    }

    public bool AuthorizeUser(string name, string password)
    {
        throw new NotImplementedException();
    }
}
#endregion

#endregion