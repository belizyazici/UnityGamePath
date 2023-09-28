namespace Inheritance
{
    public class Bitkiler:Canlilar
    {
        protected void FotosentezYapmak()
        {
            Console.WriteLine("Bitkile fotosentez yapar");
        }
    }

    public class TohumluBitkiler:Bitkiler
    {
        public TohumluBitkiler(){
            base.FotosentezYapmak(); //Kalıtımda üst sınıfına erişebilmek için base kullanılır
            base.Beslenme();
            base.Bosaltim();
            base.Solunum();
        }
        public void TohumlaCogalma()
        {
            Console.WriteLine("Tohumlu bitkiler tohumla çoğalır");
        }
    }

    public class TohumsuzBitkiler:Bitkiler
    {
        public TohumsuzBitkiler()
        {
            base.FotosentezYapmak();
            base.Beslenme();
            base.Bosaltim();
            base.Solunum();
        }

        public void SporlaCogalma()
        {
            Console.WriteLine("Tohumsuz bitkiler sporla çoğalır");
        }
    }

}