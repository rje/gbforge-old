using Xwt;

namespace gbforge.Forge.Tiles
{
    public class MainView : HPaned
    {
        public MainView() : base()
        {
            Panel1.Content = new Button("a");
            Panel2.Content = new Button("b");
        }

        protected override void OnBoundsChanged()
        {
            base.OnBoundsChanged();
            PositionFraction = 0.9;
        }
    }
}