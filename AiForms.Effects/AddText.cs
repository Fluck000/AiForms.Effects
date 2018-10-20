﻿using System;
using System.Linq;
using Xamarin.Forms;

namespace AiForms.Effects
{
    public static class AddText
    {
        public static readonly BindableProperty OnProperty =
            BindableProperty.CreateAttached(
                    "On",
                    typeof(bool?),
                    typeof(AddText),
                    null,
                    propertyChanged: AiRoutingEffectBase.ToggleEffectHandler<AddTextRoutingEffect>
                );

        public static void SetOn(BindableObject view, bool? value)
        {
            view.SetValue(OnProperty, value);
        }

        public static bool? GetOn(BindableObject view)
        {
            return (bool?)view.GetValue(OnProperty);
        }

        public static readonly BindableProperty TextProperty =
            BindableProperty.CreateAttached(
                "Text",
                typeof(string),
                typeof(AddText),
                default(string),
                propertyChanged: AiRoutingEffectBase.AddEffectHandler<AddTextRoutingEffect>
            );

        public static void SetText(BindableObject view, string value)
        {
            view.SetValue(TextProperty, value);
        }

        public static string GetText(BindableObject view)
        {
            return (string)view.GetValue(TextProperty);
        }

        public static readonly BindableProperty FontSizeProperty =
            BindableProperty.CreateAttached(
                "FontSize",
                typeof(double),
                typeof(AddTextRoutingEffect),
                8.0d
            );


        public static void SetFontSize(BindableObject view, double value)
        {
            view.SetValue(FontSizeProperty, value);
        }

        public static double GetFontSize(BindableObject view)
        {
            return (double)view.GetValue(FontSizeProperty);
        }

        public static readonly BindableProperty TextColorProperty =
            BindableProperty.CreateAttached(
                "TextColor",
                typeof(Color),
                typeof(AddText),
                Color.Red
            );

        public static void SetTextColor(BindableObject view, Color value)
        {
            view.SetValue(TextColorProperty, value);
        }

        public static Color GetTextColor(BindableObject view)
        {
            return (Color)view.GetValue(TextColorProperty);
        }

        public static readonly BindableProperty BackgroundColorProperty =
            BindableProperty.CreateAttached(
                    "BackgroundColor",
                    typeof(Color),
                    typeof(AddText),
                    Color.Transparent
                );

        public static void SetBackgroundColor(BindableObject view, Color value)
        {
            view.SetValue(BackgroundColorProperty, value);
        }

        public static Color GetBackgroundColor(BindableObject view)
        {
            return (Color)view.GetValue(BackgroundColorProperty);
        }

        public static readonly BindableProperty PaddingProperty =
            BindableProperty.CreateAttached(
                    "Padding",
                    typeof(Thickness),
                    typeof(AddText),
                    default(Thickness)
                );

        public static void SetPadding(BindableObject view, Thickness value)
        {
            view.SetValue(PaddingProperty, value);
        }

        public static Thickness GetPadding(BindableObject view)
        {
            return (Thickness)view.GetValue(PaddingProperty);
        }

        public static readonly BindableProperty MarginProperty =
            BindableProperty.CreateAttached(
                "Margin",
                typeof(Thickness),
                typeof(AddText),
                default(Thickness)
            );

        public static void SetMargin(BindableObject view, Thickness value)
        {
            view.SetValue(MarginProperty, value);
        }

        public static Thickness GetMargin(BindableObject view)
        {
            return (Thickness)view.GetValue(MarginProperty);
        }

        public static readonly BindableProperty HorizontalAlignProperty =
            BindableProperty.CreateAttached(
                "HorizontalAlign",
                typeof(TextAlignment),
                typeof(AddText),
                TextAlignment.End
            );

        public static void SetHorizontalAlign(BindableObject view, TextAlignment value)
        {
            view.SetValue(HorizontalAlignProperty, value);
        }

        public static TextAlignment GetHorizontalAlign(BindableObject view)
        {
            return (TextAlignment)view.GetValue(HorizontalAlignProperty);
        }

        public static readonly BindableProperty VerticalAlignProperty =
            BindableProperty.CreateAttached(
                "VerticalAlign",
                typeof(TextAlignment),
                typeof(AddText),
                TextAlignment.Start
            );

        public static void SetVerticalAlign(BindableObject view, TextAlignment value)
        {
            view.SetValue(VerticalAlignProperty, value);
        }

        public static TextAlignment GetVerticalAlign(BindableObject view)
        {
            return (TextAlignment)view.GetValue(VerticalAlignProperty);
        }


        class AddTextRoutingEffect : AiRoutingEffectBase
        {
            public AddTextRoutingEffect() : base("AiForms." + nameof(AddText)) { }
        }
    }
}
