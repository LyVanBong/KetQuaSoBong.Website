using Syncfusion.Blazor.Popups;

namespace KetQuaSoBong.Website.Client.Shared
{
    public partial class MainLayout
    {
        string content { get; set; } = "The dialog is configured with an animation effect. It is opened or closed with a 'Zoom In or Out' animation.";
        public bool dialogVisible { get; set; } = false;
        public bool dialogSigninVisible { get; set; } = false;

        DialogEffect animationEffect { get; set; } = DialogEffect.Zoom;
        private void OnBtnCLick()
        {
            this.dialogVisible = false;
        }
        private void OnBtnSignInCLick()
        {
            this.dialogSigninVisible = false;
        }
        private void OnZoomBtnClick(DialogEffect type)
        {
            string text;
            switch (type)
            {
                case DialogEffect.Zoom:
                    text = "Zoom";
                    break;
                case DialogEffect.FlipXDown:
                    text = "FlipX Down";
                    break;
                case DialogEffect.FlipXUp:
                    text = "FlipX Up";
                    break;
                case DialogEffect.FlipYLeft:
                    text = "FlipX Left";
                    break;
                default:
                    text = "FlipX Right";
                    break;
            }
            this.content = "The dialog is configured with an animation effect. It is opened or closed with a '" + text + "' animation.";
            this.animationEffect = type;
            this.dialogVisible = true;
            this.dialogSigninVisible = false;
        }
        private void OnZoomBtnSignInClick(DialogEffect type)
        {
            string text;
            switch (type)
            {
                case DialogEffect.Zoom:
                    text = "Zoom";
                    break;
                case DialogEffect.FlipXDown:
                    text = "FlipX Down";
                    break;
                case DialogEffect.FlipXUp:
                    text = "FlipX Up";
                    break;
                case DialogEffect.FlipYLeft:
                    text = "FlipX Left";
                    break;
                default:
                    text = "FlipX Right";
                    break;
            }
            this.content = "The dialog is configured with an animation effect. It is opened or closed with a '" + text + "' animation.";
            this.animationEffect = type;
            this.dialogSigninVisible = true;
            this.dialogVisible = false;
        }
    }
}
