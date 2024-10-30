package com.mycompany.mavenproject1;
import static java.lang.System.out;


/**
 *
 * @author Felix Muinde
 */
public class Mavenproject1 {

    //Defaul constructor used.
    static Loan myFirstLoan = new Loan();
    //Parametrized constructor beacon
    static Loan mySecondLoad = new Loan(5.5, 15, 40000);
    public static void main(String[] args) {
        
        //First we test the defaul loan object
        out.println("Loan Amount: "+ myFirstLoan.getLoanAmount());
        out.println("Loan Period in Years: "+myFirstLoan.getNumberOfYears());
        out.println("Loan Rate%: "+myFirstLoan.getAnnualInterestRate());
        
        //Then we test the parametrized one
        out.println("2nd Loan Amount: "+ mySecondLoad.getLoanAmount());
        out.println("2nd Loan Period in Years: "+ mySecondLoad.getNumberOfYears());
        out.println("2nd Loan Rate%: "+ mySecondLoad.getAnnualInterestRate());
        
        //Finding the Estimated Monthly Payments
        out.println("Estimated Monthly Installments: " + mySecondLoad.monthlyPayment());
        
        //Finding the Total Payment Amount
        out.println("Total Payment: " + mySecondLoad.totalPayment());
    }
}
