using KetQuaSoBong.Helper;

namespace KetQuaSoBong.Website.Client.Pages
{
    public partial class Football
    {
        private string _dateTimeNow = "";
        protected override async Task OnInitializedAsync()
        {
            DateTime now = DateTime.Now;
            _dateTimeNow = DateTimeHelper.StandardWeekDays(now.DayOfWeek.ToString()) + ", NGÀY " + DateTimeHelper.StandardDayMonths(now.Day) + "/" + DateTimeHelper.StandardDayMonths(now.Month) + "/" + now.Year;
        }
    }
}
