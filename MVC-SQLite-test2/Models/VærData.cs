namespace MVC_SQLite_test2.Models
{
#nullable disable
    public class VærData
    {
        public int Id { get; set; }
        public DateTime? Dato { get; set; }
        public int? Temperatur { get; set; }
        public string Kommentar { get; set; }
        public string Bruker { get; set; }
    }
}
