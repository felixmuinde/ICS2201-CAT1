/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package com.mycompany.mavenproject1;

/**
 *
 * @author Administrator
 */
public class Loan {
    
    //Class Members
    private double annualInterestRate;
    private double loanAmount;
    private int numberOfYears;
    
    private Date loanDate;
    
    //Class functions
    public Loan(){};
    public Loan(double annualInterestRate, int numberOfYears, double loanAmount){};
    
    //Getters
    public double getAnnualInterestRate(){return annualInterestRate;}
    public int getNumberOfYears(){return numberOfYears;}
    public double getLoanAmount(){return loanAmount;}
    
        
    
}
