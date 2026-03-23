namespace BlogApp.Entitiy
{
    public class User
    {
        public int UserId { get; set; }
        public string? UserName { get; set; }

        public List<Post> Posts { get; set; } = new List<Post>(); 
        // burda şunu yaptık: User sınıfının içinde Post sınıfına ait bir liste oluşturduk. Bu, bir kullanıcının birden fazla gönderisi olabileceği anlamına gelir. Ayrıca, bu listeyi boş bir liste olarak başlattık, böylece null referans hatası almazsınız.

        public List<Comment> Comments { get; set; } = new List<Comment>();
    }
}
