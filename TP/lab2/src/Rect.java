import java.util.Scanner;

public class Rect 
{
	public static void main(String[] args) 
	{
		/*test rofls 
		Point3d myPoint = new Point3d ();//создает точку (0,0.0)
		Point3d myOtherPoint1 = new Point3d (5,3,1);//создает точку (5,3,1)
		Point3d myOtherPoint2 = new Point3d (6,4,2);//создает точку (6,4,2)
		Point3d myOtherPoint3 = new Point3d (6,4,2);//создает точку (6,4,2)
		Point3d aThirdPoint = new Point3d ();
		
		System.out.println(myOtherPoint1.getX());
		System.out.println(myOtherPoint2.getY());
		System.out.println(myOtherPoint3.getZ());
		
		System.out.println(myOtherPoint1.isEqulTo(myOtherPoint3));
		System.out.println(myOtherPoint2.isEqulTo(myOtherPoint3));
		
		System.out.println(myOtherPoint1.distanceTo(myOtherPoint3));
		//boolean gq = Point3d.equl
		//System.out.println(egq);
		*/
		Scanner in = new Scanner(System.in);

		//fisrt point
		Point3d FPoint = new Point3d ();
		System.out.println("Enter X,Y and Z for first point");
		FPoint.setX(in.nextInt());
		FPoint.setY(in.nextInt());
		FPoint.setZ(in.nextInt());
		System.out.println("First point is ["+ FPoint.getX()+" , "+ FPoint.getY()+" , "+FPoint.getZ()+"]");
		
		//second point
		Point3d SPoint = new Point3d ();
		System.out.println("Enter X,Y and Z for second point");
		SPoint.setX(in.nextInt());
		SPoint.setY(in.nextInt());
		SPoint.setZ(in.nextInt());
		System.out.println("First point is ["+ SPoint.getX()+" , "+ SPoint.getY()+" , "+SPoint.getZ()+"]");
		
		//third point
		Point3d TPoint = new Point3d ();
		System.out.println("Enter X,Y and Z for third point");
		TPoint.setX(in.nextInt());
		TPoint.setY(in.nextInt());
		TPoint.setZ(in.nextInt());
		System.out.println("First point is ["+ TPoint.getX()+" , "+ TPoint.getY()+" , "+TPoint.getZ()+"]");
		
		//compute area of triangle
		if (FPoint.isEqulTo(SPoint) || FPoint.isEqulTo(TPoint) || SPoint.isEqulTo(TPoint))
			System.out.println("One of the points repeats the other");
			else
			System.out.println("Area of a triangle: "+Point3d.computeArea(FPoint, SPoint, TPoint));

	}
}