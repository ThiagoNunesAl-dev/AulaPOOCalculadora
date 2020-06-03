namespace AulaPOOCalculadora
{
    public class Adicionais : Fundamentais
    {
        public float num3 { get; set; }
        public float num4 { get; set; }

        public float CalcularMedia (float num1, float num2, float num3, float num4) {
            return (Somar(num1, num2) + Somar(num3, num4))/4;
        }
    }
}