using System;

namespace MediSure
{
    public class Program
    {
        static bool hasLastBill = false;
        static PatientBill? lastBill = null;
        static bool isApplicationRunning = true;

        static void CreateNewBill()
        {
            System.Console.WriteLine("Creating New Bill ");
            PatientBill patientBillObj = new PatientBill();

            System.Console.Write("Enter the Bill ID: ");
            string? billID = Console.ReadLine();
            while(billID == null)
            {
                System.Console.WriteLine("Bill id should not be null, Try again");
                System.Console.Write("Enter the Bill ID: ");
                billID = Console.ReadLine();

            }
            patientBillObj.BillID = billID;

            System.Console.WriteLine("Enter the patient's Name: ");
            string patientName = Console.ReadLine();
            patientBillObj.PatientName = patientName;

            System.Console.WriteLine("Does patient have an Insurance? (true/false) : ");
            bool hasInsurance = bool.Parse(Console.ReadLine());
            patientBillObj.HasInsurance = hasInsurance;

            System.Console.WriteLine("Enter the ConsultationFee : ");
            decimal consultationFee = decimal.Parse(Console.ReadLine());
            while(consultationFee <= 0)
            {
                System.Console.WriteLine("Consultation fee should be more than 0");
                System.Console.WriteLine("Enter the ConsultationFee : ");
                consultationFee = decimal.Parse(Console.ReadLine());
            }
            patientBillObj.ConsultationFee = Math.Round(consultationFee,2);

            System.Console.WriteLine("Enter the Lab Charges : ");
            decimal labCharges = decimal.Parse(Console.ReadLine());
            while(labCharges < 0)
            {
                System.Console.WriteLine("Lab charges can't be in negative Try Again");
                System.Console.WriteLine("Enter the Lab Charges : ");
                labCharges = decimal.Parse(Console.ReadLine());
            }
            patientBillObj.LabCharges = Math.Round(labCharges,2);

            System.Console.WriteLine("Enter the medicine Charges : ");
            decimal medicineCharges = decimal.Parse(Console.ReadLine());
            if (medicineCharges < 0)
            {
                System.Console.WriteLine("Medicine charges should be positive : Try again");
                System.Console.WriteLine("Enter the medicine Charges : ");
                medicineCharges = decimal.Parse(Console.ReadLine());

            }
            patientBillObj.MedicineCharges = Math.Round(medicineCharges,2);

            ComputeBill(patientBillObj);
            lastBill = patientBillObj;
            hasLastBill = true;

            System.Console.WriteLine("Bill Created Successfully");
            System.Console.WriteLine($"Gross Amount : {patientBillObj.GrossAmount}");
            System.Console.WriteLine($"Discount Amount : {patientBillObj.DiscountAmount}");
            System.Console.WriteLine($"Final Payable : {patientBillObj.FinalPayable}");
        }

        static void ComputeBill(PatientBill patientBillObj)
        {
            patientBillObj.GrossAmount = patientBillObj.ConsultationFee + patientBillObj.LabCharges + patientBillObj.MedicineCharges;
            if(patientBillObj.HasInsurance == true)
            {
                patientBillObj.DiscountAmount = patientBillObj.GrossAmount * (decimal)0.10;
            }
            else
            {
                patientBillObj.DiscountAmount = 0;
            }
            patientBillObj.FinalPayable = patientBillObj.GrossAmount - patientBillObj.DiscountAmount;
        }

        static void ViewLastBill()
        {
            if (!hasLastBill)
            {
                System.Console.WriteLine("No bill available. Please create a new bill first.");
            }
            else
            {
                System.Console.WriteLine("The last bill : ");
                System.Console.WriteLine($"Bill ID : {lastBill.BillID}");
                System.Console.WriteLine($"Patient name : {lastBill.PatientName}");
                System.Console.WriteLine($"Insured? : {lastBill.HasInsurance}");
                System.Console.WriteLine($"Consulatation Fee : {Math.Round(lastBill.ConsultationFee,2)}");
                System.Console.WriteLine($"Lab chargess : {Math.Round(lastBill.LabCharges,2)}");
                System.Console.WriteLine($"Medicine charges : {Math.Round(lastBill.MedicineCharges,2)}");
                System.Console.WriteLine($"Gross Amount {Math.Round(lastBill.GrossAmount,2)}");
                System.Console.WriteLine($"Discount Amount : {Math.Round(lastBill.DiscountAmount,2)}");
                System.Console.WriteLine($"Final Payabal : {Math.Round(lastBill.FinalPayable,2)}");
            }
        }

        static void ClearLastBill()
        {
            if (hasLastBill)
            {
                lastBill = null;
                hasLastBill = false;
                System.Console.WriteLine("Last Bill Cleared");   
            }
            else
            {
                System.Console.WriteLine("No last bill to clear");
            }
        }
        public static void Main(string[] args)
        {
            while (isApplicationRunning)
            {
                System.Console.WriteLine("=====================Hospital Billing System======================");
                System.Console.WriteLine("Select One of these to interact:");
                System.Console.WriteLine("1. Create New Bill ");
                System.Console.WriteLine("2. View Last Bill ");
                System.Console.WriteLine("3. Clear Last Bill");
                System.Console.WriteLine("4. Exit");
                System.Console.Write("Enter your input : ");
                string? input = Console.ReadLine();
                int choice = Int32.Parse(input);
                switch (choice)
                {
                    case 1:
                        {
                            CreateNewBill();
                            break;
                        }
                    case 2:
                        {
                            ViewLastBill();
                            break;
                        }
                    case 3:
                        {
                            ClearLastBill();
                            break;
                        }
                    case 4:
                        {
                            System.Console.WriteLine("Application Closed Successfully");
                            isApplicationRunning = false;
                            break;
                        }
                    default:
                        {
                            System.Console.WriteLine("Please enter a valid response!");
                            break;
                        }
                }
            }
        }
    }
}