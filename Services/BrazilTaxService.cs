namespace estudos_interface.Services
{
    class BrazilTaxService : ITaxService
    {
        //Tax pois na interface esta como Tax 
        public double Tax(double amount) 
        {
            if(amount <= 100.0)
            {
                return amount * 0.2;
            }
            else
            {
                return amount * 0.15;
            }
        }
    }
}
