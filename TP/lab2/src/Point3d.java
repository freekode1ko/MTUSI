import java.text.DecimalFormat;

public class Point3d 
{
	/* ���������� X */
	private   double xCoord;
	/* ���������� Y */
	private   double yCoord;
	/* ���������� Z */
	private   double zCoord;
	/* ����������� ������������� */
	public Point3d ( double x, double y, double z) {
	xCoord = x;
	yCoord = y;
	zCoord = z;
	}
	/* ����������� �� ���������. */
	public Point3d () {
	//�������� ����������� � ����� ����������� � ���������� ��������.
	this(0, 0, 0);
	}
	/* ����������� ���������� X */
	public double getX () {
	return xCoord;
	}
	/* ����������� ���������� Y */
	public double getY () {
	return yCoord;
	}
	/* ����������� ���������� Z */
	public double getZ () {
	return zCoord;
	}
	/* ��������� �������� ���������� X. */
	public   void setX ( double val) {
	xCoord = val;
	}
	/* ��������� �������� ���������� Y. */
	public  void setY ( double val) {
	yCoord = val;
	}
	/* ��������� �������� ���������� Z. */
	public  void setZ ( double val) {
	zCoord = val;
	}
	
	public static double computeArea(Point3d Fpoint, Point3d Spoint, Point3d Tpoint)
	{
		double a = Double.parseDouble(Fpoint.distanceTo(Spoint));
		double b = Double.parseDouble(Spoint.distanceTo(Tpoint));
		double c = Double.parseDouble(Fpoint.distanceTo(Tpoint));
		double p = (a+b+c)/2;
		return Math.sqrt(p*(p-a)*(p-b)*(p-c));
	}
	
	public boolean isEqulTo(Point3d point) 
	{
		if (this.getX() == point.getX() && this.getY() == point.getY() && this.getZ() == point.getZ())
			return true;
		else return false;
	}
	
	public String distanceTo(Point3d point)
	{
		DecimalFormat f = new DecimalFormat("##.00");
		
		return f.format( Math.sqrt(Math.pow(point.getX() - this.getX(),2) + Math.pow(point.getY() - this.getY(),2) + Math.pow(point.getZ() - this.getZ(),2)));
	}
}