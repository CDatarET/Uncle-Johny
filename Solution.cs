using System;

public class Test
{
	public static void Main()
	{
		int cases = int.Parse(Console.ReadLine());
		for(int c = 0; c < cases; c++){
		    int l = int.Parse(Console.ReadLine());
		    string[] inputs = Console.ReadLine().Split();
		    int[] nums = new int[l];
		    
		    for(int i = 0; i < l; i++){
		        nums[i] = int.Parse(inputs[i]);
		    }
		    
		    int k = int.Parse(Console.ReadLine());
		    k = nums[k-1];
		    Array.Sort(nums);
		    
		    for(int i = 0; i < l; i++){
		        if(nums[i] >= k){
		            Console.WriteLine(i+1);
		            break;
		        }
		    }
		}
	}
}
