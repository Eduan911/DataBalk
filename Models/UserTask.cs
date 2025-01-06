namespace DataBalkCSharp.Models
{
    public class UserTask
    {
        public int ID { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public int Assignee { get; set; } 
        public DateTime DueDate { get; set; }
        public List<string> Comments { get; set; } = new List<string>();
        public List<string> Attachments { get; set; } = new List<string>();
    }
}
