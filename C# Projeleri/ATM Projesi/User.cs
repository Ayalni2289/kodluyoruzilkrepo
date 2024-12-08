class User{
    public string Username { get; set; }
    public int balance { get; set; }

    public User(string username, int balance)
    {
        Username = username;
        this.balance = balance;
    }
}