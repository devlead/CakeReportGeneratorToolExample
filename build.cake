// Install modules
#module nuget:?package=Cake.DotNetTool.Module&version=0.4.0

// Install .NET Core Global tools.
#tool "dotnet:?package=dotnet-reportgenerator-globaltool&version=4.8.5"


FilePath coveragePath = "./coverage.xml";
DirectoryPath targetDir = "./report/";

CleanDirectory(targetDir);

ReportGenerator(coveragePath, targetDir, new ReportGeneratorSettings {
    ArgumentCustomization = args => args.AppendSwitch("-reporttypes", ":", "lcov")
});