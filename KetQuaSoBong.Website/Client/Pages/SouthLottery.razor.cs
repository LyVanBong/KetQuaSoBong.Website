using KetQuaSoBong.Helper;

namespace KetQuaSoBong.Website.Client.Pages
{
    public partial class SouthLottery
    {
        public DateTime? DateValue { get; set; } = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 10);
        public DateTime MinDate { get; set; } = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 05);
        public DateTime MaxDate { get; set; } = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 27);
        public DateTime? SelectedDate { get; set; } = DateTime.Now;
        private string _dateTimeNow = "";
        protected override async Task OnInitializedAsync()
        {
            DateTime now = DateTime.Now;
            _dateTimeNow = DateTimeHelper.StandardDayMonths(now.Day) + "/" + DateTimeHelper.StandardDayMonths(now.Month) + "/" + now.Year;
        }
    }
}
