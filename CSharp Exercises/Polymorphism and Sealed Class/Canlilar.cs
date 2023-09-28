namespace PolymorphismSealedClass
{
    public class Canlilar //başka sınıflara kalıtım veremesin istiyorsan sealed kelimesi kullanılır(public sealed class)
    {
        protected void Beslenme()
        {
            Console.WriteLine("Canlılar beslenir");
        }

        protected void Solunum()
        {
            Console.WriteLine("Canlılar solunum yapar");
        }

        protected void Bosaltim()
        {
            Console.WriteLine("Canlılar boşaltım yapar");
                        
        }

        public virtual void UyaranlaraTepki(){
            Console.WriteLine("Canlılar uyaranlara tepki verir");
        }

        //Çok biçimcilik ile birlikte hayatımıza sanal yani virtual metotlar giriyor. 
        //Virtual metotlar ile nesne yönelimli programlama ilkesi olan polymorphism'i uygularız. 
        //Sanal metotlar kalıtım alınan yani miras veren sınıf içerisinde yazılan ve daha sonra alt sınıflarda yeniden yazılabilen
        // metotlardır. Bunu da virtual ve override anahtar kelimeleri sağlar.


    }

}