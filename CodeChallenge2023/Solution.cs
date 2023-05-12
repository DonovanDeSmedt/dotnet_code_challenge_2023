using System;
namespace CodeChallenge2023
{
    public class Solution
    {
        public async Task<double> GetBmi()
        {
            var result = await Task.WhenAll(PersonInformationService.GetLength(), PersonInformationService.GetWeight());
            return await CalculateBmi(result[0], result[1]);
        }

        private Task<double> CalculateBmi(int length, int weight)
        {
            return Task.FromResult(weight / ((length / 100.0) * (length / 100.0)));
        }
    }
}

