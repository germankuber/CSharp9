class User:IUser
{
    public virtual User GetUser()=>  new User();
}
interface IUser {
    User GetUser();
}
class AdminUser : User{
    public override AdminUser GetUser() => new AdminUser();
}
