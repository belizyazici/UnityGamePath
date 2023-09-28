namespace AbstractExample
{
    public abstract class Otomobil
    {
        public int KacTekerlektenOlusur(){
            return 4; //hepsinde ortak olduğu için tek tek yazmak yerine bir kere burada yazılabilir
        }

        public virtual Renk StandartRengiNe(){
            return Renk.Beyaz; //çoğunluk beyaz olduğu için tek tek yazmak yerine bir kere burada yazılabilir
        }

        public abstract Marka HangiMarkaninAraci();// hepsi farklı olduğu için gövdesi yok
    }
}