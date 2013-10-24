class Medication
{
    public Medication(int allergyID, string name, string description)
    {
      medicationID  = medicationID;
      name          = name;
      description   = description;
    }
    public int medicationID     { get; private set; }
    public string name          { get; private set; }
    public string description   { get; private set; }
}
