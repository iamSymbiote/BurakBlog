using BurakBlog.Shared.Entities.Abstract;

namespace BurakBlog.Entities.Concrete
{
    public class Comment : EntityBase, IEntity
    {
        public string? Text { get; set; }
        public int ArticleId { get; set; }

        // bu altta yaptigimiz isin ben ilk zamanlar derdini cok cekmistim("neden abi neden" diye :), buraya yazayim ilerde belki birilerine faydasi olur ^.^

        // Bunun adi `Navigation Property` , EntityFramework'te ne ise yariyor peki?
        // Bu is bir entity'den baska "BAGLI" bir entity'ye gitmemizi sagliyor.
        // ornegin burda actigim `User` bir role bagliysa, user ile iliskili rolu okumak ve incelemek icin bu navigasyonu kullaniyoruz.
        // burda mevzubahis konu Article, onu bagladim. Ilerde cok basimizi agritacak keske her sey bu kadar pembe olsa :)

        // bunun benzerini `Article` ve `User`in icine de yazdim, mantik burda karistiysa onlara da bakabiliriz.
        public Article? Article { get; set; } 
    }
}
