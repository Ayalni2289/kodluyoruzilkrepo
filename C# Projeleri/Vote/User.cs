class User
{
    public string Username { get; set; }
    public bool HasVoted { get; set; }

    public User(string username)
    {
        Username = username;
        HasVoted = false;
    }
}