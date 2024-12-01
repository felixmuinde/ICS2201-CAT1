/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */

/**
 *
 * @author Administrator
 */
public class Circle extends Shape{
    private double radius;
    
    public Circle(String color, double radius){
        super(color);
        this.radius = radius;
}
    
    @Override
    public double calculateArea(){
        return Math.PI * radius * radius;
    }
}