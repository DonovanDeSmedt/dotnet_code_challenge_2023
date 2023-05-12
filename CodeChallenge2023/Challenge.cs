using System;
namespace CodeChallenge2023
{
    public class Challenge
    {
        public async Task<double> GetBmi()
        {
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

