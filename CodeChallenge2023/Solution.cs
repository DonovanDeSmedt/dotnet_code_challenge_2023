using System;
namespace CodeChallenge2023
{
    public class Solution
    {
        public async Task<double> GetBmi()
        {
            // TODO: Replace the following 2 line's with a more performant solution.w
            var length = await PersonInformationService.GetLength();
            var weight = await PersonInformationService.GetWeight();

            return await CalculateBmi(length, weight);
        }

        private Task<double> CalculateBmi(int length, int weight)
        {
            return Task.FromResult(weight / ((length / 100.0) * (length / 100.0)));
        }
    }
}

