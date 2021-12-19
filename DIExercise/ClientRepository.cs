using System;
using System.Collections.Generic;
using System.Text;

namespace DIExercise
{
    public class ClientRepository : IClientRepository
    {
        public bool AddClient(Client client)
        {
            bool isLoanGranted;
            try
            {
                // ADD client to DB
                isLoanGranted = true;
            }
            catch (Exception e)
            {
                isLoanGranted = false;
                Console.WriteLine("Błąd podczas zapisu do bazy");
                throw;
            }
            return isLoanGranted;
        }
    }
}
