public class Solution
{
    public int MaxProduct(int[] nums)
    {
        int n = nums.Length;
        if (n == 0) return 0;
        int[] dp_max = new int[n];
        int[] dp_min = new int[n];

        dp_max[0] = nums[0];
        dp_min[0] = nums[0];

        for (int i = 1; i < n; i++)
        {
            if (nums[i] > 0)
            {
                dp_max[i] = Math.Max(dp_max[i - 1] * nums[i], nums[i]);
                dp_min[i] = Math.Min(dp_min[i - 1] * nums[i], nums[i]);
            }
            else
            {
                dp_max[i] = Math.Max(dp_min[i - 1] * nums[i], nums[i]);
                dp_min[i] = Math.Min(dp_max[i - 1] * nums[i], nums[i]);
            }

        }
        return dp_max.Max();

    }

    public int MaxProduct3(int[] nums)
    {
        // Initializing result
        int result = nums[0];
        for (int i = 0; i < nums.Length; i++)
        {
            int mul = nums[i];

            // Traversing in current subarray
            for (int j = i + 1; j < nums.Length; j++)
            {
                // Updating result every time
                // to keep an eye over the
                // maximum product
                mul *= nums[j];
                result = Math.Max(result, mul);
            }
            // Updating the result for (n-1)th index
            result = Math.Max(result, mul);
        }
        return result;
    }

    public int MaxProduct4(int[] nums)
    {
        int min, max, res;
        min = max = res = nums[0];

        for (int i = 1; i < nums.Length; i++)
        {
            var temp = new int[] { min * nums[i], max * nums[i], nums[i] };
            min = temp.Min();
            max = temp.Max();

            res = Math.Max(res, max);
        }

        return res;
    }

    public int MaxProduct5(int[] nums)
    {

        if (nums == null || nums.Length == 0)
            return 0;

        int min = nums[0], max = nums[0], res = nums[0];
        for (int i = 1; i < nums.Length; i++)
        {
            int product1 = nums[i] * min;
            int product2 = nums[i] * max;
            int product3 = nums[i];

            res = Math.Max(res, Math.Max(Math.Max(product1, product2), product3));

            max = Math.Max(Math.Max(product1, product2), product3);
            min = Math.Min(Math.Min(product1, product2), product3);
        }

        return res;
    }

    static void Main()
    {

        //int[] nums = { 2, 3, -2, 4 };
        //int[] nums = { -2, 0, -1 };
        //int[] nums = { -3, -12, -3, -2, -2, 2, 3, -2, 4, -1 };
        //int[] nums = { -2 };
        //int[] nums = { 2,-5,-2,-4,3 };
        //int[] nums = { -1, -3, 10, 0, 60 };
        int[] nums = { 12, 2, -3, -5, -6, -2 };
        Solution solution = new Solution();


        int res3 = solution.MaxProduct3(nums);
        Console.WriteLine(res3);

        int res4 = solution.MaxProduct4(nums);
        Console.WriteLine(res4);

        int res5 = solution.MaxProduct5(nums);
        Console.WriteLine(res5);
    }
}
