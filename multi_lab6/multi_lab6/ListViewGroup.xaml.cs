using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ListViewExample
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListViewGroup : ContentPage
    {
        public ObservableCollection<Group> Groups { get; set; }
        public ListViewGroup()
        {
            InitializeComponent();
            Groups = new ObservableCollection<Group>
        {
            new Group("A")
            {
                new Item { Nombre = "Alfredo", Dni = "Pika" },
                new Item { Nombre = "Angel", Dni = "Trebol" },
                new Item { Nombre = "Alonso", Dni = "Corazon" },
            },
            new Group("B")
            {
                new Item { Nombre = "Bruno", Dni = "Play" },
                new Item { Nombre = "Bernardo", Dni = "Xbox" },
                new Item { Nombre = "Beatriz", Dni = "Nintendo" },

            },
            new Group("C")
            {
                new Item { Nombre = "Carol", Dni = "Java" },
                new Item { Nombre = "Camila", Dni = "Swift" },
                new Item { Nombre = "Carmen", Dni = "c#" },

            },
        };
            GroupedView.ItemsSource = Groups;
        }
    }
}