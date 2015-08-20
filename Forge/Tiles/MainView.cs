using Xwt;

namespace gbforge.Forge.Tiles
{
    public class MainView : HPaned
    {
        public MainView() : base()
        {
            Panel1.Content = CreateEditPane();
            Panel2.Content = new Button("b");
        }

        Widget CreateEditPane()
        {
            var hbox = new HBox();
            hbox.PackStart(new Toolpane());
            hbox.PackStart(new TileEditor());
            hbox.PackStart(new PreviewPane());
            return hbox;
        }

        protected override void OnBoundsChanged()
        {
            base.OnBoundsChanged();
            PositionFraction = 0.9;
        }
    }
}