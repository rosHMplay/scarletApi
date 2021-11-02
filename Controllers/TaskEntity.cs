namespace ScarletAPI.Controllers
{
    public class TaskEntity
    {
        public string Title { get; internal set; }
        public string Message { get; internal set; }
        public string[] Items { get; internal set; }
    }
}