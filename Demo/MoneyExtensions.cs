namespace Demo
{
    /// <summary>
    /// 金额扩展类
    /// </summary>
    public static class MoneyExtensions
    {
        /// <summary>
        /// 获取万元值
        /// </summary>
        /// <param name="amount">金额</param>
        ///  <param name="round">是否四舍五入</param>
        /// <param name="places">保留小数点位数</param>
        /// <returns></returns>
        public static decimal GetTenThousandsYuan(this decimal amount, bool round = true, int places = 2)
        {
            return round ? decimal.Round(amount / 10000, places) : decimal.Round(Math.Truncate(amount / 10000 * 100) / 100, places);
        }

    }
}
