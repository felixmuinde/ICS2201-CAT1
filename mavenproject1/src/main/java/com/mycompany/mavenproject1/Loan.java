package com.mycompany.mavenproject1;
import static java.lang.System.out;

/**
 *
 * @author Felix Muinde
 */
public class Loan {
    
    //Class Members
    private double annualInterestRate = 2.5;
    private double loanAmount = 1000;
    private int numberOfYears = 1;
    
//    private Date loanDate;
    
    //Class functions
    public Loan(){};
    public Loan(double annualInterestRate, int numberOfYears, double loanAmount){
        this.annualInterestRate = annualInterestRate;
        this.numberOfYears = numberOfYears;
        this.loanAmount = loanAmount;
    };
    
    //Getters
    public double getAnnualInterestRate(){return this.annualInterestRate;}
    public int getNumberOfYears(){return this.numberOfYears;}
    public double getLoanAmount(){return this.loanAmount;}
//    pub;ic Date getLoanDate();
    
    //Setters
    public void setAnnualInterestRate(double AIR){
        if(AIR < 2.5){
            out.println("Let's have a reasonnable rate of interest");
        }
        else if(AIR > 20){
            out.println("We are a bank not a crime syndicate");
        }else{
            this.annualInterestRate = AIR;
        }
    }
    
    public void setNumberOfYears(int years){
        if(years < 1){
            out.println("How do you expect payments to be made in less than one year");
        }else{
            this.numberOfYears = years;
        }
    }
    public void setLoanAmount(double amount){
        if(amount < 1000){
            out.println("Amount has to be above $1000");
        } else{
            this.loanAmount = amount;
        }
    }
    
    public double monthlyPayment(){
        double installment,rate,principle;
        principle = this.loanAmount;
        rate = (annualInterestRate/100) / 12;
        int months = numberOfYears * 12;
        double ratePlusOne = rate + 1;
        double expoRatePlusOne = Math.pow(ratePlusOne, months);
        installment = principle * (rate * (expoRatePlusOne)) / ((expoRatePlusOne - 1));
        
        return installment;
    }
    
    public double totalPayment(){
        return monthlyPayment() * numberOfYears * 12;
    }
        
    
}
