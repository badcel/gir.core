﻿using System;
using System.Reflection;
using GObject;
using Gtk;
using Type = GObject.Type;

namespace GtkDemo
{
    public class CompositeWidget : Bin
    {
        private static void ClassInit(Type gClass, System.Type type, IntPtr classData)
        {
            SetTemplate(
                gtype: gClass, 
                template: Assembly.GetExecutingAssembly().ReadResource("CompositeWidget.glade")
            );
            BindTemplateChild(gClass, nameof(Button));
            ConnectTemplateSignals(gClass, type);
        }

        protected override void Initialize()
        {
            InitTemplate();
            BindTemplateChild(nameof(Button), ref Button);
        }

        private Button Button = default!;

        private void button_clicked(Button sender, System.EventArgs args)
        {
            sender.Label = "Clicked!";
        }
    }
}