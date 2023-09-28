namespace AbstractExample
{
    public class NewCivic : Otomobil
    {
        public override Marka HangiMarkaninAraci() //farklı değerde olduğu için override edilmeli
        {
            return Marka.Honda;
        }

        public override Renk StandartRengiNe() //rengi farklı olarak gri olduğu için override edilir
        {
            return Renk.Gri;
        }
    }
}