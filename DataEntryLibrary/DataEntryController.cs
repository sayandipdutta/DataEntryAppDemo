namespace DataEntryLibrary;

using System.IO;
public class DataEntryController
{
    public required ProjectConfig projectDetails;

    public static void SaveProject(ProjectConfig projectDetails, string projectPath, string username)
    {
        if (Path.Exists(projectPath)) {
            throw new InvalidOperationException("Project file already exists at the specified path.");
        };

        try {
            using (StreamWriter writer = new StreamWriter(projectPath)) {
                writer.WriteLine($"# Project Name:\n{projectDetails.ProjectName}");
                writer.WriteLine("---");
                writer.WriteLine("# Field Names:");
                foreach (var fieldName in projectDetails.FieldNames) {
                    writer.WriteLine(fieldName);
                }
                writer.WriteLine("---");
                writer.WriteLine($"# Created by:\n{username}");
                writer.WriteLine("---");
                writer.WriteLine($"# Created on:\n{DateTime.Now}");
            }
        } catch (Exception ex) {
            throw new IOException("Failed to save project file.", ex);
        }
    }

    public static ProjectDetails LoadProject(string projectPath)
    {
        if (!Path.Exists(projectPath)) {
            throw new FileNotFoundException("Project file not found at the specified path.");
        };
        using StreamReader reader = new StreamReader(projectPath);
        string line;
        string projectName = "";
        List<string> fieldNames = new List<string>();
        string username = "";
        DateTime createdTime = DateTime.MinValue;
        while ((line = reader.ReadLine()) != null)
        {
            if (line.StartsWith("# Project Name:"))
            {
                projectName = reader.ReadLine() ?? "";
            }
            else if (line.StartsWith("# Field Names:"))
            {
                while ((line = reader.ReadLine()) != null && !line.StartsWith("---"))
                {
                    fieldNames.Add(line);
                }
            }
            else if (line.StartsWith("# Created by:"))
            {
                username = reader.ReadLine() ?? "";
            }
            else if (line.StartsWith("# Created on:"))
            {
                string dateLine = reader.ReadLine() ?? "";
                DateTime.TryParse(dateLine, out createdTime);
            }
        }
        return new(new(projectName, fieldNames), username, createdTime);
    }

}

public record struct ProjectConfig (string ProjectName, List<string> FieldNames);
public record struct ProjectDetails (ProjectConfig config, string username, DateTime createdTime);
