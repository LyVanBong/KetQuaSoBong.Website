using KetQuaSoBong.Helper;

namespace KetQuaSoBong.Website.Client.Pages
{
    public partial class Index
    {
        private string _dateTimeNow = "";
        protected override async Task OnInitializedAsync()
        {   
            DateTime now = DateTime.Now;
            _dateTimeNow = DateTimeHelper.StandardWeekDays(now.DayOfWeek.ToString()) + ", NGÀY " + DateTimeHelper.StandardDayMonths(now.Day) + " THÁNG " + DateTimeHelper.StandardDayMonths(now.Month);
        }
    }
}
