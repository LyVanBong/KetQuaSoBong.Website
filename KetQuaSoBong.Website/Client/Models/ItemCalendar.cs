using System.Drawing;

namespace KetQuaSoBong.Models
{
    public class ItemCalendar
    {
        public int Number { get; set; }
        private Color _numberColor;
        public double ItemHeight { get => 30; }
        public double ItemWidth { get => 30; }

        public Color NumberColor
        { get => _numberColor; set => _numberColor = value; }

        public Color BgColor { get; set; }
        private bool _isChecked = false;

        public bool IsChecked
        {
            get => _isChecked;
            set => _isChecked = value;
        }

        private bool _isEnable = false;

        public bool IsEnable
        {
            get => _isEnable;
            set => _isEnable = value;
        }
    }
}