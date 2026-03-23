namespace BlogApp.Entitiy
{
    public class Tag
    {
        public int TagId { get; set; }
        public string? Text { get; set; }

        public List<Post> Posts { get; set; } = new List<Post>(); 
        // herhangi bir etikete tıkladığımızda o etikete sahip tüm gönderileri göstermek istediğimiz için böyle bir liste oluşturduk. Bu, bir etiketin birden fazla gönderiye sahip olabileceği anlamına gelir. Ayrıca, bu listeyi boş bir liste olarak başlattık, böylece null referans hatası almazsınız.
    }
}
