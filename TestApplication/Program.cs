
public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        int[] nums = { 0, 1, 0, 3, 12 };
        MoveZeroes(nums);
        Console.WriteLine(string.Join(", ", nums));
    }

    public static void MoveZeroes(int[] nums)
    {
        int n = nums.Length;
        int start = 0;
        int end = n - 1;

        if (n > 1)
        {
            while (start < end)
            {
                if (nums[start] == 0)
                {
                    // Find the next non-zero from the end
                    while (nums[end] == 0 && end > start)
                    {
                        end--;
                    }
                    if (start < end)
                    {
                        // Swap the zero with the non-zero value
                        int temp = nums[start];
                        nums[start] = nums[end];
                        nums[end] = temp;
                        end--; // move the 'end' pointer to the left
                    }
                }
                start++; // move the 'start' pointer to the right
            }
        }
    }

}