namespace relacionamentoCSharp
{
    public class Carro
    {
        private string _modelo;
        private Motor _motor;

        public Carro(string modelo, Motor motor)
        {
            this._modelo = modelo;
            this._motor = motor;
        }

        public float VelocidadeMaxima()
        {
            if (_motor.Cilindrada <= 1.0f) return 140.0f;
            else if (_motor.Cilindrada <= 1.6f) return 180.0f;
            else if (_motor.Cilindrada <= 2.0f) return 220.0f;
            else return 260.0f;
        }

        public override string ToString()
        {
            return $"{_modelo} - Velocidade máxima: {VelocidadeMaxima()}Km/h";
        }
    }
}
