using System;
using System.Linq;
using System.Text;

					
public class Program
{
	public static void Main()
	{
		int result, lo, hi, mid;
		result = lo = hi = mid = 0; 
		long sum = 0;
		
		StringBuilder stringBuilder = new StringBuilder();

		string[] numTarget = Console.ReadLine().Split(); 
		int num = int.Parse(numTarget[0]);		
		int target = int.Parse(numTarget[1]);
		
		string[] treesString = Console.ReadLine().Split();
		int[] trees = new int[treesString.Count()];
		
		for(int i = 0 ; i < treesString.Count() ; i++){
			trees[i] = int.Parse(treesString[i]); 
		}		
		
		hi = trees.Max();
		mid = (hi + lo )/ 2;
		
		while( lo + 1 < hi ){
			sum = 0;

			for( int i = 0 ; i < trees.Count();i++){
				if(trees[i] - mid > 0 ){
					sum += trees[i] - mid;
				}
			}
			
			if( sum == target){
				lo = mid;
				break;
			}else if( sum < target && sum !=0) { 
				hi = mid;				
			}else if( sum >= target){
				lo = mid;
			}
			mid = (int)(hi + lo)/2;

		} 
		
		stringBuilder.Append(lo);
		Console.WriteLine(stringBuilder);
	}
}	