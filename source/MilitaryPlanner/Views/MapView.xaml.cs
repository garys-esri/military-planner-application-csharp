using System.Windows.Controls;

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
            string response = Microsoft.VisualBasic.Interaction.InputBox("Enter the plan name", "Provision: Plan Name", "plan");
            if (null != response && response.Trim().Length > 0)
            {
                Mediator.NotifyColleagues(Constants.ACTION_PROVISION_PLAN, @"C:\Users\gary4620\Box Sync\events\FedGIS\FedGIS2015\plenary Runtime demo\plans\" + response + ".xml");
            }
        }
    
    }

}
