namespace DataEntryLibrary;

public class DataEntryController
{
    public required ProjectDetails projectDetails;
}

public record ProjectDetails (string ProjectName, List<string> FieldNames);
