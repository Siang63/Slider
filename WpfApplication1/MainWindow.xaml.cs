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

namespace WpfApplication1
{
    /// <summary>
    /// MainWindow.xaml 的互動邏輯
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

      

        private void HeightCleanBox_Click(object sender, RoutedEventArgs e)
        {
            HeightBox.Text = "";
            HeightBox.Background = Brushes.Blue;
        }


        private void WeightBtn_Click(object sender, RoutedEventArgs e)
        {
            HeightBox.Text = "";
            HeightBox.Background = Brushes.Blue;
        }

       private void CountBtn_Click(object sender, RoutedEventArgs e)
        {
            double w = double.Parse(WeightBox.Text);
            double h = double.Parse(HeightBox.Text) / 100;
            double bmi = w / (h *h);

            Answer.Text = bmi.ToString();
        }

        private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (IsInitialized)
            {
                HeightBox.Text = Slider.Value.ToString();
                double w = double.Parse(WeightBox.Text);
                double h = double.Parse(HeightBox.Text) / 100;
                double bmi = w / (h * h);

                Answer.Text = bmi.ToString();
            }
        }

        private void Slider1_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (IsInitialized)
            {
                WeightBox.Text = Slider1.Value.ToString();
                double w = double.Parse(WeightBox.Text);
                double h = double.Parse(HeightBox.Text) / 100;
                double bmi = w / (h * h);

                Answer.Text = bmi.ToString();
            }
        }
    }
}
     //   <UniformGrid Columns = "3" Rows="1" Margin="1">
     //       <TextBlock Text = "{Binding ElementName=slider,Path=Minimum}"
     //             TextAlignment="Left"/>
     //       <TextBlock Text = "{Binding ElementName=slider,Path=Value}"
     //             TextAlignment="Center"/>
     //       <TextBlock Text = "{Binding ElementName=slider,Path=Maximum}"
     //              TextAlignment="Right"/>
     //   </UniformGrid>
        
     //   <Slider Name = "slider"
     //      IsSnapToTickEnabled="True" 
     //      TickPlacement="TopLeft"
     //       Minimum="0" Maximum="200" TickFrequency="1" />


