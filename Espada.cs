namespace InterfaceCLassesAbstratas
{
    internal class Espada : Arma
    {
        public override int CalcularAtaqueCritico()
        {
            return DanoBase * 2;
        }
    }
}
