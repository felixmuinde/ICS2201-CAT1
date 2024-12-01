/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */

/**
 *
 * @author Administrator
 */
public class Rectangle extends Shape{
    private double length;
    private double width;
    
    public Rectangle(String color, double lenghth, double width){
        super(color);
        this.length = length;
        this.width = width;
    }
    @Override
    public double calculateArea(){
        return length * width;
    }
}
