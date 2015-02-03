using Microsoft.Win32;
using MilitaryPlanner.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MilitaryPlanner.Views
{
    /// <summary>
    /// Interaction logic for MapView.xaml
    /// </summary>
    public partial class MapView : UserControl
    {
        public MapView()
        {
            InitializeComponent();
        }

        private void Button_Provision_Click(object sender, RoutedEventArgs e)
        {
            // file dialog
            var sfd = new SaveFileDialog();

            sfd.Filter = "xml files (*.xml)|*.xml";
            sfd.RestoreDirectory = true;

            if (sfd.ShowDialog() == true)
            {
                Mediator.NotifyColleagues(Constants.ACTION_PROVISION_PLAN, sfd.FileName);
            }
        }
    
    }

}
