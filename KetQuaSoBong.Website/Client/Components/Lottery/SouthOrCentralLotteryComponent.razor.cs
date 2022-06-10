using KetQuaSoBong.Helper;

namespace KetQuaSoBong.Website.Client.Components.Lottery
{
    public partial class NothernLotteryComponent
    {
        private string _dateTimeNow = "";
        protected override async Task OnInitializedAsync()
        {
            DateTime now = DateTime.Now;
            _dateTimeNow = DateTimeHelper.StandardWeekDays(now.DayOfWeek.ToString()) + ", NGÀY " + DateTimeHelper.StandardDayMonths(now.Day) + " THÁNG " + DateTimeHelper.StandardDayMonths(now.Month);
        }
    }
}
