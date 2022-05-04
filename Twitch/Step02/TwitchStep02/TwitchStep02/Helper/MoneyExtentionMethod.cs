namespace TwitchStep02.Helper
{
    public static class MoneyExtentionMethod
    {
        public static string ToMoneyString(this decimal money)
        {
            return string.Format("{0:C}", money);
        }
    }
}
