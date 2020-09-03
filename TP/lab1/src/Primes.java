public class Primes{
	public static void main(String[] args) 
	{	
		//part 1
		for (int i = 2; i < 101; i = i + 1 )
		{
			if (isPrime(i) == true)
			{
				System.out.println(i);
			}
		}
		//Part 2
		String s = "DAROV" ;
		System.out.println("Before reverse: "+s);
		System.out.println("After reverse: "+reverseString(s));
		System.out.println("");
		//Part 3
		String[] ss = {"java", "Palindrome", "madam", "racecar", "apple", "kayak", "song", "noon"};
		for (int i = 0; i < ss.length; i=i+1) 
		{
			s = ss[i];
			if (isPalindrome(s) == true) System.out.println(s + " IS palindrome");
			else System.out.println(s + " NOT palindrome");		
		}
	}
	
	public static boolean isPalindrome(String s) 
	{
		String reS = reverseString(s);
		return s.equals(reS);
		
	}
	
	public static String reverseString(String s)
	{
		String reS = "";
		for (int i=s.length();i!=0;i = i - 1)  
		{
			reS=reS + s.charAt(i-1);
		}
		return reS;
	}

	public static boolean isPrime(int n)
	{
		if (n%2==0) 
			return true;
		else return false;
		
	}
}