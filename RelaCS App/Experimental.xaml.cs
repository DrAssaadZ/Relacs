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

namespace RelaCS_App
{
    /// <summary>
    /// Interaction logic for Experimental.xaml
    /// </summary>
    public partial class Experimental : UserControl
    {
        MediaPlayer ambient = new MediaPlayer();
        string ambientAudio = "Ambient 1";
        MediaPlayer drone = new MediaPlayer();
        string droneAudio = "Drone 1";
        MediaPlayer lou = new MediaPlayer();
        string louAudio = "Lounge 1";
        MediaPlayer beta = new MediaPlayer();
        string betaAudio = "Waves 1";

        public Experimental()
        {
            InitializeComponent();
        }

        #region ambient
        private void AmbientCombo_DropDownClosed(object sender, EventArgs e)
        {
            if (ambientIcon.Opacity == 0.4)
            {
                ambientAudio = AmbientCombo.Text;
            }
            else
            {
                ambient.Stop();
                ambientAudio = AmbientCombo.Text;
                ambient.Open(new Uri("Resources/" + ambientAudio + ".mp3", UriKind.Relative));
                ambient.Play();
            }
        }

        private void ambientIcon_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (ambientIcon.Opacity == 0.4)
            {
                ambientIcon.Opacity = 1;
                ambientSlider.IsEnabled = true;

                ambient.Open(new Uri("Resources/" + ambientAudio + ".mp3", UriKind.Relative));
                ambient.MediaEnded += new EventHandler(ambient_ended);
                ambient.Volume = 0.5;
                ambientSlider.Value = 0.5;
                ambient.Play();
            }
            else
            {
                ambientIcon.Opacity = 0.4;
                ambientSlider.IsEnabled = false;
                ambient.Stop();
            }
        }

        private void ambient_ended(object sender, EventArgs e)
        {
            ambient.Open(new Uri("Resources/" + ambientAudio + ".mp3", UriKind.Relative));
            ambient.Play();
        }

        private void ambientSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            ambient.Volume = ambientSlider.Value;
        }
        #endregion

        #region drone
        private void droneIcon_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (droneIcon.Opacity == 0.4)
            {
                droneIcon.Opacity = 1;
                droneSlider.IsEnabled = true;

                drone.Open(new Uri("Resources/" + droneAudio + ".mp3", UriKind.Relative));
                drone.MediaEnded += new EventHandler(drone_ended);
                drone.Volume = 0.5;
                droneSlider.Value = 0.5;
                drone.Play();
            }
            else
            {
                droneIcon.Opacity = 0.4;
                droneSlider.IsEnabled = false;
                drone.Stop();
            }
        }

        private void drone_ended(object sender, EventArgs e)
        {
            drone.Open(new Uri("Resources/" + droneAudio + ".mp3", UriKind.Relative));
            drone.Play();
        }

        private void droneSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            drone.Volume = droneSlider.Value;
        }

        private void droneCombo_DropDownClosed(object sender, EventArgs e)
        {
            if (droneIcon.Opacity == 0.4)
            {
                droneAudio = droneCombo.Text;
            }
            else
            {
                drone.Stop();
                droneAudio = droneCombo.Text;
                drone.Open(new Uri("Resources/" + droneAudio + ".mp3", UriKind.Relative));
                drone.Play();
            }
        }
        #endregion

        #region lounge
        private void louIcon_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (louIcon.Opacity == 0.4)
            {
                louIcon.Opacity = 1;
                louSlider.IsEnabled = true;

                lou.Open(new Uri("Resources/" + louAudio + ".mp3", UriKind.Relative));
                lou.MediaEnded += new EventHandler(lou_ended);
                lou.Volume = 0.5;
                louSlider.Value = 0.5;
                lou.Play();
            }
            else
            {
                louIcon.Opacity = 0.4;
                louSlider.IsEnabled = false;
                lou.Stop();
            }
        }

        private void lou_ended(object sender, EventArgs e)
        {
            lou.Open(new Uri("Resources/" + louAudio + ".mp3", UriKind.Relative));
            lou.Play();
        }

        private void louCombo_DropDownClosed(object sender, EventArgs e)
        {
            if (louIcon.Opacity == 0.4)
            {
                louAudio = louCombo.Text;
            }
            else
            {
                lou.Stop();
                louAudio = louCombo.Text;
                lou.Open(new Uri("Resources/" + louAudio + ".mp3", UriKind.Relative));
                lou.Play();
            }
        }

        private void louSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            lou.Volume = louSlider.Value;
        }
        #endregion

        #region alphabetawaves
        private void betaIcon_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (betaIcon.Opacity == 0.4)
            {
                betaIcon.Opacity = 1;
                betaSlider.IsEnabled = true;

                beta.Open(new Uri("Resources/" + betaAudio + ".mp3", UriKind.Relative));
                beta.MediaEnded += new EventHandler(beta_ended);
                beta.Volume = 0.5;
                betaSlider.Value = 0.5;
                beta.Play();
            }
            else
            {
                betaIcon.Opacity = 0.4;
                betaSlider.IsEnabled = false;
                beta.Stop();
            }
        }

        private void beta_ended(object sender, EventArgs e)
        {
            beta.Open(new Uri("Resources/" + betaAudio + ".mp3", UriKind.Relative));
            beta.Play();
        }

        private void betaSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            beta.Volume = betaSlider.Value;
        }

        private void betaCombo_DropDownClosed(object sender, EventArgs e)
        {
            if (betaIcon.Opacity == 0.4)
            {
                betaAudio = betaCombo.Text;
            }
            else
            {
                beta.Stop();
                betaAudio = betaCombo.Text;
                beta.Open(new Uri("Resources/" + betaAudio + ".mp3", UriKind.Relative));
                beta.Play();
            }
        } 
        #endregion
    }
}
