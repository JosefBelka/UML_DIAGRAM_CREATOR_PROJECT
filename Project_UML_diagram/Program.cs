
namespace Belka_project_uml_diagram
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            List<Box> boxes = new List<Box>();
            Application.Run(new FormMain(boxes));
        }
    }
}