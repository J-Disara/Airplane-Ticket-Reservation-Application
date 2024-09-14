using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Airplane_Reservation_System
{
    internal class Appteams
    {
        public static void changetheam( Uri theamuri)
        {
            ResourceDictionary theams = new ResourceDictionary() { Source = theamuri};

            App.Current.Resources.Clear();
            App.Current.Resources.MergedDictionaries.Add(theams);
        }
    }
}
