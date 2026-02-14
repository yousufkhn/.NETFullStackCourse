using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartBank
{
    public class CreditRiskProcessor
    {
        public bool ValidateCustomerDetails(int age,string employementType,double monthlyIncome,double dues,int creditScore,int defaults)
        {
            if(age<21 || age > 65)
            {
                throw new InvalidCreditDataException("Invalid age");
            }
            if(!(employementType.Equals("Salaried") || employementType.Equals("Self-Employed")))
            {
                throw new InvalidCreditDataException("Invalid employment type");
            }
            if (monthlyIncome < 20000)
            {
                throw new InvalidCreditDataException("Invalid monthly income");
            }
            if (dues < 0)
            {
                throw new InvalidCreditDataException("Invalid credit dues");
            }
            if(creditScore < 300 || creditScore > 900)
            {
                throw new InvalidCreditDataException("Invalid default count");
            }
            return true;
        }

        public double CalculateCreditLimit(double monthlyIncome,double dues,int creditScore,int defaults)
        {
            double debtRatio = dues / (monthlyIncome * 12);

            double creditLimit = 0;

            if(creditScore < 600 || defaults >= 3 || debtRatio > 0.4)
            {
                creditLimit = 50000;
            }
            else if((creditScore >= 600 && creditScore <= 749) || (defaults >0 && defaults <= 2)){
                creditLimit = 150000;
            }
            else if(creditScore >= 750 && defaults == 0 && debtRatio < 0.25)
            {
                creditLimit = 300000;
            }

            return creditLimit;

        }
    }
}
