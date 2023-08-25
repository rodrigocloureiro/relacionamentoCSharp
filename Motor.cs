namespace relacionamentoCSharp
{
    public class Motor
    {
        private float _cilindrada;

        public Motor(float cilindrada)
        {
            this._cilindrada = cilindrada;
        }

        public float Cilindrada
        {
            get { return _cilindrada; }
        }
    }
}
