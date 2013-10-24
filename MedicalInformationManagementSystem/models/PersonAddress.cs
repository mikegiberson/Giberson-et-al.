class PersonAddress
{
    public PersonAddress()
    {
    }

    public int personID             { get; private set; }
    public string timestamp         { get; private set; }
    public string type              { get; private set; }
    public string deliveryAddress   { get; private set; }
    public string subdivision       { get; private set; }
    public string division          { get; private set; }
    public string postalCode        { get; private set; }
    public string country           { get; private set; }
}
