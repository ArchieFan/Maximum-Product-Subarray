namespace Maximum_Product_Subarray.Test
{
    public class UnitTest1
    {

        [Theory]
        [InlineData(new int[] { 2, 3, -2, 4 }, 6)]
        [InlineData(new int[] { -2, 0, -1 }, 0)]
        [InlineData(new int[] { -2 }, -2)]
        [InlineData(new int[] { 2, -5, -2, -4, 3 }, 24)]
        [InlineData(new int[] { -1, -3, 10, 0, 60 }, 60)]
        [InlineData(new int[] { 1, -2, -3, 0, 7, -8, -2 }, 112)]
        public void Test(int[] nums, int expected)
        {
            Solution solution = new Solution();
            int res = solution.MaxProduct(nums);
            Assert.Equal(expected, res);

        }

        [Theory]
        [InlineData(new int[] { 2, 3, -2, 4 }, 6)]
        [InlineData(new int[] { -2, 0, -1 }, 0)]
        [InlineData(new int[] { -2 }, -2)]
        [InlineData(new int[] { 2, -5, -2, -4, 3 }, 24)]
        [InlineData(new int[] { -1, -3, 10, 0, 60 }, 60)]
        [InlineData(new int[] {1, -2, -3, 0, 7, -8, -2 }, 112)]
        public void Test3(int[] nums, int expected)
        {
            Solution solution = new Solution();
            int res = solution.MaxProduct3(nums);
            Assert.Equal(expected, res);

        }

        [Theory]
        [InlineData(new int[] { 2, 3, -2, 4 }, 6)]
        [InlineData(new int[] { -2, 0, -1 }, 0)]
        [InlineData(new int[] { -2 }, -2)]
        [InlineData(new int[] { 2, -5, -2, -4, 3 }, 24)]
        [InlineData(new int[] { -1, -3, 10, 0, 60 }, 60)]
        [InlineData(new int[] { 1, -2, -3, 0, 7, -8, -2 }, 112)]
        public void Test4(int[] nums, int expected)
        {
            Solution solution = new Solution();
            int res = solution.MaxProduct4(nums);
            Assert.Equal(expected, res);

        }

        [Theory]
        [InlineData(new int[] { 2, 3, -2, 4 }, 6)]
        [InlineData(new int[] { -2, 0, -1 }, 0)]
        [InlineData(new int[] { -2 }, -2)]
        [InlineData(new int[] { 2, -5, -2, -4, 3 }, 24)]
        [InlineData(new int[] { -1, -3, 10, 0, 60 }, 60)]
        [InlineData(new int[] { 1, -2, -3, 0, 7, -8, -2 }, 112)]
        public void Test5(int[] nums, int expected)
        {
            Solution solution = new Solution();
            int res = solution.MaxProduct5(nums);
            Assert.Equal(expected, res);

        }


    }
}