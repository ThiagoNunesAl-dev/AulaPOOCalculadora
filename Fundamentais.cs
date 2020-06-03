namespace AulaPOOCalculadora
{
    public class Fundamentais
    {
        public float num1 { get; set; }
        public float num2 { get; set; }
        public float Somar (float num1, float num2) {
            return num1 + num2;
        }
        public float Subtrair (float num1, float num2) {
            return num1 - num2;
        }
        public float Multiplicar (float num1, float num2) {
            return num1 * num2;
        }
        public float Dividir (float num1, float num2) {
            return num1/num2;
        }        
    }
}