namespace BlogApp.Entitiy
{
    public class Comment
    {
        public int CommentId { get; set; }
        public string? Text { get; set; }
        public DateTime PublishedOn { get; set; }

        public int PostId { get; set; } 
        // PostId, her yorumun hangi gönderiye ait olduğunu belirtmek için kullanılır. Bu, yorumun hangi gönderiye ait olduğunu belirlemek için bir yabancı anahtar olarak işlev görür.
        public Post Post { get; set; } = null!; 
        // tekil navigation property, yani her yorumun sadece bir gönderiye ait olduğunu belirtir.
        // Post sınıfına ait bir nesne oluşturduk. Bu, her yorumun bir gönderiye ait olduğunu belirtir. Ayrıca, bu nesneyi null olmayan bir şekilde başlattık, böylece null referans hatası almazsınız.

        public int UserId { get; set; } 
        // UserId, her yorumun hangi kullanıcı tarafından yapıldığını belirtmek için kullanılır. Bu, yorumun hangi kullanıcıya ait olduğunu belirlemek için bir yabancı anahtar olarak işlev görür.
        public User User { get; set; } = null!; 
        // tekil navigation property, her yorumun bir kullanıcıya ait olduğunu belirtir.
        // User sınıfına ait bir nesne oluşturduk. Bu, her yorumun bir kullanıcıya ait olduğunu belirtir. Ayrıca, bu nesneyi null olmayan bir şekilde başlattık, böylece null referans hatası almazsınız.
    }
}
