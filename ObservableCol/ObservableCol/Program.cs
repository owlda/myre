using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.ObjectModel;

namespace ObservableCol
{
    class Program
    {
        static void Main(string[] args)
        {
            ObservableCollection<BasicEmployee> obspack = new ObservableCollection<BasicEmployee>
            {
                new BasicEmployee {Name="John",Surname="Bo",Age=23},
                new BasicEmployee {Name="Elsa",Surname="No",Age=33}
            };
            obspack.CollectionChanged += people_ObserveCollection;
            obspack.Add(new BasicEmployee {Name="Od",Surname="Holi",Age=33 });
        }
        static void people_ObserveCollection(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs arg)
        { throw new NotImplementedException(); }
    }
}
