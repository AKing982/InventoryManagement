namespace InventoryManagement.Model;

public class User : IComparable<User>
{
    private string _username { get; set; }
    private string _firstName { get; set; }
    private string _lastName { get; set; }
    private string _email { get; set; }
    private string _password { get; set; }
    private Address _address { get; set; }

    public User(string user, string first, string last, string email, string pass, Address address)
    {
        _username = user;
        _firstName = first;
        _lastName = last;
        _email = email;
        _password = pass;
        _address = address;
    }

    public int CompareTo(User? other)
    {
        if (ReferenceEquals(this, other)) return 0;
        if (ReferenceEquals(null, other)) return 1;
        var usernameComparison = string.Compare(_username, other._username, StringComparison.Ordinal);
        if (usernameComparison != 0) return usernameComparison;
        var firstNameComparison = string.Compare(_firstName, other._firstName, StringComparison.Ordinal);
        if (firstNameComparison != 0) return firstNameComparison;
        var lastNameComparison = string.Compare(_lastName, other._lastName, StringComparison.Ordinal);
        if (lastNameComparison != 0) return lastNameComparison;
        var emailComparison = string.Compare(_email, other._email, StringComparison.Ordinal);
        if (emailComparison != 0) return emailComparison;
        return string.Compare(_password, other._password, StringComparison.Ordinal);
    }
}