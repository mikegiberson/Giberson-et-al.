class Patient
{
    public Patient(int patientID, int referialDoctorID, string registratonDate)
    {
      patientID         = patientID;
      referialDoctorID  = referialDoctorID;
      registratonDate   = registratonDate;
    }
    public int patientID          { get; private set; }
    public int referialDoctorID   { get; private set; }
    public string registratonDate { get; private set; }
}
