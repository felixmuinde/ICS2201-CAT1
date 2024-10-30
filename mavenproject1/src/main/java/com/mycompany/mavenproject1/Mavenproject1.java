package com.mycompany.mavenproject1;
import static java.lang.System.out;

/**
 *
 * @author Felix Muinde
 */
public class Mavenproject1 {

    static Loan myFirstLoan = new Loan();
    public static void main(String[] args) {
        System.out.println("Hello World!");
        out.println("Loan Amount: "+ myFirstLoan.getLoanAmount());
        out.println("Loan Period in Years: "+myFirstLoan.getNumberOfYears());
        out.println("Loan Rate%: "+myFirstLoan.getAnnualInterestRate());
    }
}
