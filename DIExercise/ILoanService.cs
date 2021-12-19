using System;
using System.Collections.Generic;
using System.Text;

namespace DIExercise
{
    public interface ILoanService
    {
        public int CalculateAmount(int salary, int requestedLoanAmount);
    }
}
