using KetQuaSoBong.Helper;

namespace KetQuaSoBong.Website.Client.Components.Lottery
{
    public partial class SouthOrCentralLotteryComponent
    {
        public string _dateTimeNow = "";
        protected override async Task OnInitializedAsync()
        {
            DateTime now = DateTime.Now;
            _dateTimeNow = DateTimeHelper.StandardDayMonths(now.Day) + "/" + DateTimeHelper.StandardDayMonths(now.Month) + "/" + now.Year ;
        }
    }
}
