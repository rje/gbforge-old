using System;
using System.Collections.Generic;
using Xwt;

namespace gbforge.Forge
{
    public class ToolSelector : HBox
    {
        private List<Button> _buttons;
        private MainWindow _parent;
         
        public ToolSelector(MainWindow parent) : base()
        {
            _buttons = new List<Button>();
            _parent = parent;
            CreateButton("T", false);
            CreateButton("S");
            CreateButton("A");
            CreateButton("M");
            CreateButton("O");
            this.VerticalPlacement = WidgetPlacement.Start;
        }

        Button CreateButton(string title, bool sensitive = true)
        {
            var button = new Button(title)
            {
                MinWidth =  40,
                MinHeight = 40
            };
            this.PackStart(button);
            _buttons.Add(button);
            button.Clicked += OnButtonClick;
            button.Sensitive = sensitive;
            return button;
        }

        private void OnButtonClick(object sender, EventArgs e)
        {
            var button = sender as Button;
            button.Sensitive = false;
            foreach (var toEnable in _buttons)
            {
                if (toEnable != button)
                {
                    toEnable.Sensitive = true;
                }
            }
            _parent.ShowToolset(button.Label);
        }
    }
}