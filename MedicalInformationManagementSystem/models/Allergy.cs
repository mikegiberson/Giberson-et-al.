class Allergy
{
    public Allergy(int allergyID, string name, string category)
    {
      allergyID = allergyID;
      name      = name;
      category  = category;
    }
    public int allergyID    { get; private set; }
    public string name      { get; private set; }
    public string category  { get; private set; }
}
