using CORConsoleApp.models;

internal class Program
{
    private static void Main(string[] args)
    {

        var level1 = new Level1Support();
        var level2 = new Level2Support();
        var escalationManager = new EscalationManager();

        level1.SetNext(level2);
        level2.SetNext(escalationManager);
        

        level1.Handle("simple issue"); // Output: Level 1 support handled the request.
        level1.Handle("complex issue"); // Output: Level 2 support handled the request.
        level1.Handle("critical issue"); // Output: Request escalated to manager.

    }
}