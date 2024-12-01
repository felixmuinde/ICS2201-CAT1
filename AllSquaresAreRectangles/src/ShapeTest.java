/**
 *
 * @author Felix Muinde
 */
import static java.lang.System.out;

public class ShapeTest {
    public static void main(String[] args){
        Shape[] shapes = new Shape[2];
        
        shapes[0] = new Circle("Burgundy", 4.2);
        shapes[1] = new Rectangle("Pink", 4.1, 2.1);
        
        for(Shape shape : shapes) {
            out.println("Color: " + shape.getColor());
            out.println("Area: " + shape.calculateArea());
        }
    }
}
