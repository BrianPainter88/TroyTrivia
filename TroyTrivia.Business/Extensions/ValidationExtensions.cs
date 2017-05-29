namespace TroyTrivia.Business.Extensions
{
    public static class ValidationExtensions
    {
        public static bool IsDivisibleBy(this int numberToCheck, int divisibleBy)
        {
            return numberToCheck % divisibleBy == 0;
        }
    }
}
