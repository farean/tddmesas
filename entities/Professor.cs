namespace Mesas.Entities
{
    public class Professor
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string DisplayName 
        { 
            get
            {
                return string.Format("{0}, {1}", this.LastName, this.FirstName );
            } 
        }
    }
}