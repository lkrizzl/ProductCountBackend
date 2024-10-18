using Domain.Users.Emails;
using Domain.Users.UserNames;

namespace Domain.Users;

public class User
{
    private User() : base() { }

    private User(Guid id, Email email,UserName userName, string passwordHash)
    {
        Id = id;
        Email = email;
        UserName = userName;
    }

    public Guid Id { get; set; }
    public Email Email { get; set; }
    public UserName UserName { get; set; }

}
    