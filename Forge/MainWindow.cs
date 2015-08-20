using System;
using System.Collections.Generic;
using gbforge.Forge.Tiles;
using Xwt;

namespace gbforge.Forge
{
    public class MainWindow : Window
    {
        private Dictionary<string, Widget> _toolsets = new Dictionary<string, Widget>();
        private VBox _contentBox;
        private Widget _currentToolset;

        public MainWindow() : base()
        {
            Title = "GB Forge";
            Width = 1024;
            Height = 768;
            InitialLocation = WindowLocation.CenterScreen;
            Closed += HandleClosed;
            var selector = new ToolSelector(this);
            _contentBox = new VBox();
            _contentBox.PackStart(selector);
            Content = _contentBox;
            CreateToolsets();
            ShowToolset("T");
        }

        void CreateToolsets()
        {
            var tiles = new MainView();
            _toolsets["T"] = tiles;
        }

        void HandleClosed(object sender, EventArgs args)
        {
            Application.Exit();
        }

        public void ShowToolset(string key)
        {
            Console.WriteLine("Show {0}", key);
            if (_toolsets.ContainsKey(key))
            {
                if (_currentToolset != null)
                {
                    _contentBox.Remove(_currentToolset);
                }
                _currentToolset = _toolsets[key];
                _contentBox.PackStart(_currentToolset);
            }
        }
    }
}