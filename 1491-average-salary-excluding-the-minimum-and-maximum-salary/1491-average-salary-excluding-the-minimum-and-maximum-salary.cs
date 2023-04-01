public class Solution {
    public double Average(int[] salary) {
        
        Array.Sort(salary);
        int len = salary.Length, sum = 0;
        
        for(int i=1; i<len-1; i++)
        {
            sum += salary[i];
        }
        
        return (double)sum/(double)(len-2);
        
    }
}