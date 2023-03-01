namespace RemoveElementArr;
public class Class1
{
    public int RemoveElement(int[] nums, int val)
    {
        int i = 0;
        foreach (int num in nums)
        {
            if (num != val)
            {
                nums[i++] = num;
            }
        }
        return i;
    }
}
