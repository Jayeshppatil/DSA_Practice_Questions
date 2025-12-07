
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
        // Create temp array
        int[] temp = new int[nums.Length];

        // Pointer for temp
        int index = 0;

        // Traverse input array
        for (int i = 0; i < nums.Length; i++)
        {
            // If non-zero, copy to temp
            if (nums[i] != 0)
            {
                temp[index] = nums[i];
                index++;
            }
        }

        // Copy temp back to original
        for (int i = 0; i < nums.Length; i++)
        {
            nums[i] = temp[i];
        }
    }

}