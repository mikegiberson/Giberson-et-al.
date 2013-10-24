class Schedule
{
    public Schedule()
    {
    }

    public int scheduleID         { get; private set; }
    public int doctorID           { get; private set; }
    public string calender        { get; private set; }
    public string timeZone        { get; private set; }
    public string dateTimeStart   { get; private set; }
    public string dateTimeEnd     { get; private set; }
    public string duration        { get; private set; }
    public string exclusionDate   { get; private set; }
    public string exclusionRule   { get; private set; }
    public string recurrenceDate  { get; private set; }
    public string recurrenceRule  { get; private set; }
}
