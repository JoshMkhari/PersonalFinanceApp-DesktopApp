using _20104681JoshMkhariProg6221POE.MVVM.Model;
using System;
using System.Collections.Generic;
using System.Windows;

delegate void ExpenseWarning(string msg);

namespace _20104681JoshMkhariProg6221POE.Logic

{
    class MainClass
    {
        public static double TotalExpenses = 0;//Stores total expenses
        public static double availableBalance = 0;
        public static String HomeLoanExpense;
        public static double VehicleExpense;
        public static double monthlySavings;
        public static double rentExpense;
        public static double vehicleInsurance = 0;
        public static List<decimal> ListOfExpenses = new List<decimal>();// retrieves the users expenses array
        public static double userTax = 0;

        static string livingType = " ";//stores user selected option between h(home loan) or r(rent)
        static double GrossMonthlyIncome = 0;
        public static double LivingMonthlyExpense = 0;//stores the unique expense based on whether it is rental or homeloan repayment
        static List<decimal> homeLoanValuesList = new List<decimal>();// retrieves the users expenses array

        public static decimal[] propertyValuesArray = new decimal[4];// creating an array to store (property price, deposit, interest, numOfMonths).
        static readonly string[] ArrayOfOutputs = {"your Gross monthly income (before deductions)","estimated monthly tax that will be deducted",//1
             "Groceries cost","Water and lights cost","Travel costs (including petrol)","Your phone bill cost (cell and tell)" ,//5
             "Other expenses in total","your monthly rental amount","purchase price of the property","Property deposit",//9
            "the annual interest rate as a percentage (example: 10,5 or 10)","number of months between 240 and 360","Purchase Price",//12
            "Total deposit","the annual interest rate as a percentage (example: 10,5 or 10)","Estimated insurance premium",//15
            "What would you like to save up for? eg: Honours Degree","How much would you like to save? eg 100000",//17
            "How many years yould you like to save up for?","starting amount","the annual interest rate as a percentage (example: 10,5 or 10)"};//20

        public static void HomeLoan(decimal Monthly, decimal tax, decimal[] expenses)//Used to calculate homeloan class
        {
            HomeLoan h1 = new HomeLoan();
            if (BudgetPlannerModel.getBudgetPlanner())
            {
                PopulateMonthlyExpenses(h1, Monthly, tax, expenses);//Populates Monthly Gross income, Tax, Grocceries, Water...

            }
            h1.SetLoanExpensesList(propertyValuesArray);//Recieves Property Values Array from HomeLoan xaml
            h1.CalculateExpenses();//Calculates the home loan expenses 
            livingType = "Home Loan";//Sets living type
            LivingMonthlyExpense = Convert.ToDouble(Math.Round(h1.MonthlyExpense));//Stores expense
            HomeLoanExpense = "" + Math.Round(h1.MonthlyExpense);
            availableBalance = Convert.ToDouble(Math.Round(h1.AvailBalValue, 2));//Updates avaialable Balance
            userTax = Convert.ToDouble(tax);//Stores user tax
        }

        public static void Vehicles(decimal[] expenses)//Used to calculate Vehicle class
        {
            Vehicle v1 = new Vehicle();
            v1.SetUserExpensesList(expenses);//Set expenses such as Purchase price, interest, number of months
            v1.CalculateExpenses();//Calculates the vehicle expenses
            vehicleInsurance = Convert.ToDouble(expenses[3]);// stores vehicle insurance
            VehicleExpense = Convert.ToDouble(v1.TotalExpensesValue);// stores vehicle expense
        }

        public static void SavingsCall(decimal[] expenses)//Used to calculate savings class
        {

            Savings s1 = new Savings();
            s1.SetUserExpensesList(expenses);//sets expenses such as goal, interest,  starting balance and years
            s1.CalculateExpenses();//Calculates the savings expenses
            monthlySavings = Convert.ToDouble(Math.Round(s1.MonthlyExpense, 2));// stores savings expense
        }
        static void PopulateMonthlyExpenses(Expense e1, decimal MonthlyIncone, decimal MonthlyTax, decimal[] expenses)//Used to populate monthly expenses
        {

            e1.GrossMonthlyIncomeValue = MonthlyIncone;//Stores the validated gross monthly income. 
            e1.MonthlyTaxValue = MonthlyTax;//Stores the validated monthly tax value.
            e1.SetUserExpensesList(expenses);//stores the groceries, water lights, cell phone etc
            ListOfExpenses.Clear();
            ListOfExpenses.AddRange(expenses);//updates the list of expenses
        }
        public static void setRent(double rent)//Used to calculate rent class
        {
            livingType = "Rent";//stores the type of living
            rentExpense = rent;//stores the expense
            LivingMonthlyExpense = Math.Round(rent);//used in display
        }

        public static bool DecimalCheck(String value)// Checks if user input is a valid Decimal, Parameter takes a location of an output.
        {
            /*
             * ListOfOutputs
             * Stores a list of potential outputs for any input the user may enter.
             * If a user is meant to enter travel costs, the relevant output is stored in listOfOutputs[4].
             */
            decimal converted;//stores the user input that has been converted to a decimal.
            bool successfullyParsed;//stores either true or false based on whether or not a conversion of user input was successfull.
            successfullyParsed = decimal.TryParse(value, out converted);//Stores either true or false based on whether or not a conversion of user input was successfull.
            if (!successfullyParsed)//checks if the conversion was unsuccessful or if the user input is empty.
            {
                MessageBox.Show("Incorrect input","Warning", MessageBoxButton.OK, MessageBoxImage.Warning);//warn user.
                MessageBox.Show("Enter numerical values only (example 20,5 or 20)","Warning", MessageBoxButton.OK, MessageBoxImage.Warning);
            }//alert user.

            return successfullyParsed;// return whether the input is 
        }
        public static string DisplayExpenses(Boolean car, Boolean savings)//displays the expenses
        {
            TotalExpenses = 0;

            IDictionary<string, decimal> expensesDictionary = new Dictionary<string, decimal>();
            List<decimal> expenseValues = new List<decimal>();// retrieves the users expenses array

            //populating 
            if (car)//vehicle stuff
            {
                TotalExpenses += vehicleInsurance + VehicleExpense;
                expensesDictionary.Add("Vehicle Monthly Repayment:\t  R", Convert.ToDecimal(VehicleExpense));//add the monthly vehicle monthly repayment and its value
            }
            if (savings)//savings stuff
            {
                TotalExpenses += monthlySavings;
                expensesDictionary.Add("Savings Monthly Repayment:\t  R", Convert.ToDecimal(monthlySavings));//add the monthly vehicle monthly repayment and its value
            }

            if (livingType.Equals("Home Loan"))
            {
                expensesDictionary.Add(livingType + "\t\t\t  R", Convert.ToDecimal(Math.Round(LivingMonthlyExpense)));//add the monthly repayment and its value
            }
            else
                expensesDictionary.Add(livingType + "\t\t\t\t  R", Convert.ToDecimal(Math.Round(LivingMonthlyExpense)));//add the monthly repayment and its value

            TotalExpenses += LivingMonthlyExpense;
            expensesDictionary.Add("Tax:  \t\t\t\t  R", Convert.ToDecimal(userTax));
            for (int i = 0; i < 5; i++)//populating grocerries, water lights, travel costs, phone bill, other expenses
            {
                switch (i)
                {
                    case 4:
                        expensesDictionary.Add(ArrayOfOutputs[i + 2] + ": \t\t  R", ListOfExpenses[i]);//adding other expenses
                        break;
                    case 3:
                    case 2:
                        expensesDictionary.Add(ArrayOfOutputs[i + 2] + ": \t  R", ListOfExpenses[i]);//adding phone bill and travel costs
                        break;
                    case 0:
                        expensesDictionary.Add(ArrayOfOutputs[i + 2] + ": \t\t\t  R", ListOfExpenses[i]);//adding grocerries
                        break;
                    default:
                        expensesDictionary.Add(ArrayOfOutputs[i + 2] + ": \t\t  R", ListOfExpenses[i]);//adding grocerriies, water lights
                        break;
                }
                TotalExpenses += Convert.ToDouble(ListOfExpenses[i]);
            }

            //Sorting Section
            List<string> expenseKeys = new List<string>();// to store the expenseDictionary keys
            expenseValues.Clear();//clearing expenseValues list so it can be used to store expenseDictionary Values

            //used as parralel lists to store decending alues and their equivalent keys
            expenseKeys.AddRange(expensesDictionary.Keys);
            expenseValues.AddRange(expensesDictionary.Values);

            int t, k;
            bool swapped;
            for (t = 0; t < expensesDictionary.Count - 1; t++)//bubble sorting in decending order
            {
                swapped = false;
                for (k = 0; k < expensesDictionary.Count - t - 1; k++)
                {
                    if (expenseValues[k] < expenseValues[k + 1])
                    {
                        //Sorting Keys
                        String primKey = expenseKeys[k];
                        expenseKeys[k] = expenseKeys[k + 1];
                        expenseKeys[k + 1] = primKey;

                        //Sorting values
                        decimal val = expenseValues[k];
                        expenseValues[k] = expenseValues[k + 1];
                        expenseValues[k + 1] = val;
                        swapped = true;
                    }
                }
                if (swapped == false)
                    break;
            }

            //Displaying Section
            String output = "";
            output = "Expense Name \t\t\t Expense Cost \n";
            for (int i = 0; i < expenseValues.Count; i++)
            {
                output = output + expenseKeys[i] + expenseValues[i] + "\n";
            }

            return output;
        }

        public static void checkDel(double total, double gmi)
        {
            ExpenseWarning expensesExceeded = Vehicle.Exceeded;//delegate 
            if (total > (gmi * 0.75))//checking if expenses exceed 75%
            {//invoking delegate
                expensesExceeded.Invoke("WARNING!!! This is greater than 75% of your income");
            }
        }


    }
}