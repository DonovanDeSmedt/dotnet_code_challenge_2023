using System;
namespace CodeChallenge2023
{
    public static class PersonInformationService
    {
        public static async Task<int> GetLength()
        {
            await Task.Delay(1000);
            return 170;
        }

        public static async Task<int> GetWeight()
        {
            await Task.Delay(1000);
            return 56;
        }
    }
}

