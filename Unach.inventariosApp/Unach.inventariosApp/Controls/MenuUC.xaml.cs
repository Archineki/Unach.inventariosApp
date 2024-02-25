using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Unach.inventariosApp.Controls
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MenuUC : ContentView
    {
        public MenuUC()
        {
            InitializeComponent();
        }


        public string Titulo
        {
            get { return (string)GetValue(TituloProperty); }
            set
            {
                SetValue(TituloProperty, value);
            }
        }
        public static readonly BindableProperty TituloProperty = BindableProperty.Create(nameof(Titulo), typeof(string), typeof(MenuUC), default(string),
        propertyChanged: (bindable, oldValue, newValue) =>
        {
            var me = (MenuUC)bindable;
            me.Titulo = (string)newValue;
            me.TituloLabel.Text = me.Titulo;
        });


        public string SubTitulo
        {
            get { return (string)GetValue(SubTituloProperty); }
            set
            {
                SetValue(SubTituloProperty, value);
            }
        }
        public static readonly BindableProperty SubTituloProperty = BindableProperty.Create(nameof(SubTitulo), typeof(string), typeof(MenuUC), default(string),
        propertyChanged: (bindable, oldValue, newValue) =>
        {
            var me = (MenuUC)bindable;
            me.SubTitulo = (string)newValue;
            me.SubTituloLabel.Text=me.SubTitulo;
        });

        public ImageSource ImagenIcon
        {
            get { return (ImageSource)GetValue(ImageIconProperty); }
            set
            {
                SetValue(ImageIconProperty, value);
            }   
        }
        public static readonly BindableProperty ImageIconProperty = BindableProperty.Create(nameof(ImagenIcon), typeof(ImageSource), typeof(MenuUC), default(ImageSource),
        propertyChanged: (bindable, oldValue, newValue) =>
        {
            var me = (MenuUC)bindable;
            me.ImagenIcon = (ImageSource)newValue;
            me.IconoImage.Source = me.ImagenIcon;
        });
    }
} 