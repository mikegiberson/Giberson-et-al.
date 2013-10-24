class Diagnosis
{
    public Diagnosis(int diagnosisID, string name, string description)
    {
      diagnosisID   = diagnosisID;
      name          = name;
      description   = description;
    }
    public int diagnosisID      { get; private set; }
    public string name          { get; private set; }
    public string description   { get; private set; }
}
