public class Primes{
	public static void main(String[] args) 
	{	
		//part 1
		for (int i = 2; i < 101; i = i + 1 )
			if (isPrime(i) == true)
				System.out.println(i);
	}
	

	public static boolean isPrime(int n)
	{
		for (int i=2; i<n; i = i + 1)
			if (n%i == 0)return false;
		return true;
		
	}
}