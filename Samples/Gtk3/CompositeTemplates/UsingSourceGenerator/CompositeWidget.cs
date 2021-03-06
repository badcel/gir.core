﻿using Gtk;

namespace GtkDemo
{
    [Template("CompositeWidget.ui")]
    public partial class CompositeWidget : Bin
    {
        [Connect]
        private Button Button = default!;

        private void button_clicked(Button sender, System.EventArgs args)
        {
            sender.Label = "Clicked!";
        }
    }
}
