using System;
using System.Collections.Generic;
using System.Text;

namespace DIExercise
{
    public interface IClientRepository
    {
        public bool AddClient(Client client);
    }
}
