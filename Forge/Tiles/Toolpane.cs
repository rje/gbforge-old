using System;
using System.Collections.Generic;
using Xwt;

namespace gbforge.Forge.Tiles
{
    public class Toolpane : VBox
    {
        private List<Button> _buttons;

        public Toolpane() : base()
        {
            _buttons = new List<Button>();
            CreateButton("Br", false);
            CreateButton("Bu");
            CreateButton("Ey");
            CreateButton("Hf");
            CreateButton("Vf");
            CreateButton("Re");
            CreateButton("Cu");
            CreateButton("Co");
            CreateButton("Pa");
            this.HorizontalPlacement = WidgetPlacement.Start;
        }

        Button CreateButton(string title, bool sensitive = true)
        {
            var button = new Button(title)
            {
                MinWidth = 40,
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
        }

    }
}