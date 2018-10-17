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
    /// Interaction logic for Nature.xaml
    /// </summary>
    public partial class Nature : UserControl
    {
        MediaPlayer rain = new MediaPlayer();
        MediaPlayer thunder = new MediaPlayer();
        MediaPlayer bird = new MediaPlayer();
        MediaPlayer wave = new MediaPlayer();
        MediaPlayer wind = new MediaPlayer();
        MediaPlayer train = new MediaPlayer();
        MediaPlayer night = new MediaPlayer();
        MediaPlayer fire = new MediaPlayer();
        MediaPlayer fall = new MediaPlayer();
        string rainAudio = "Rain 1";
        

        public Nature()
        {
            InitializeComponent();
        }

        #region rain
        private void rainSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            rain.Volume = rainSlider.Value;
        }

        private void rainIcon_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (rainIcon.Opacity == 0.4)
            {
                rainIcon.Opacity = 1;
                rainSlider.IsEnabled = true;

                //rain.Open(new Uri("Resources/" + rainAudio + ".mp3", UriKind.Relative));
                rain.Open(new Uri(@"C:\Users\Assaad\Desktop\" + rainAudio + ".mp3"));
                rain.MediaEnded += new EventHandler(rain_ended);
                rain.Volume = 0.5;
                rainSlider.Value = 0.5;
                rain.Play();
            }
            else
            {
                rainIcon.Opacity = 0.4;
                rainSlider.IsEnabled = false;
                rain.Stop();
            }
        }

        private void rain_ended(object sender, EventArgs e)
        {
            //rain.Open(new Uri("Resources/" + rainAudio + ".mp3", UriKind.Relative));
            rain.Open(new Uri(@"C:\Users\Assaad\Desktop\" + rainAudio + ".mp3"));
            rain.Play();
        }

        private void rainCombo_DropDownClosed(object sender, EventArgs e)
        {
            if (rainIcon.Opacity == 0.4)
            {
                rainAudio = rainCombo.Text;
            }
            else
            {
                rain.Stop();
                rainAudio = rainCombo.Text;
                //rain.Open(new Uri("Resources/"+rainAudio+".mp3", UriKind.Relative));
                rain.Open(new Uri(@"C:\Users\Assaad\Desktop\" + rainAudio + ".mp3"));
                rain.Play();
            }
        }
        #endregion

        #region thunder
        private void thunderSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            thunder.Volume = thunderSlider.Value;
        }

        private void thunderIcon_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (thunderIcon.Opacity == 0.4)
            {
                thunderIcon.Opacity = 1;
                thunderSlider.IsEnabled = true;

                thunder.Open(new Uri("Resources/Thunder.mp3", UriKind.Relative));
                thunder.MediaEnded += new EventHandler(thunder_ended);
                thunder.Volume = 0.5;
                thunder.Play();
            }
            else
            {
                thunderIcon.Opacity = 0.4;
                thunderSlider.IsEnabled = false;
                thunder.Stop();
            }
        }

        private void thunder_ended(object sender, EventArgs e)
        {
            thunder.Open(new Uri("Resources/Thunder.mp3", UriKind.Relative));
            thunder.Play();
        }
        #endregion

        #region bird
        private void birdSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            bird.Volume = birdSlider.Value;
        }

        private void birdIcon_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (birdIcon.Opacity == 0.4)
            {
                birdIcon.Opacity = 1;
                birdSlider.IsEnabled = true;

                bird.Open(new Uri("Resources/Thunder.mp3", UriKind.Relative));
                bird.MediaEnded += new EventHandler(bird_ended);
                bird.Volume = 0.5;
                bird.Play();
            }
            else
            {
                birdIcon.Opacity = 0.4;
                birdSlider.IsEnabled = false;
                bird.Stop();
            }
        }

        private void bird_ended(object sender, EventArgs e)
        {
            bird.Open(new Uri("Resources/Thunder.mp3", UriKind.Relative));
            bird.Play();
        }
        #endregion

        #region wave
        private void waveSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            wave.Volume = waveSlider.Value;
        }

        private void waveIcon_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (waveIcon.Opacity == 0.4)
            {
                waveIcon.Opacity = 1;
                waveSlider.IsEnabled = true;

                wave.Open(new Uri("Resources/Thunder.mp3", UriKind.Relative));
                wave.MediaEnded += new EventHandler(wave_ended);
                wave.Volume = 0.5;
                wave.Play();
            }
            else
            {
                waveIcon.Opacity = 0.4;
                waveSlider.IsEnabled = false;
                wave.Stop();
            }
        }

        private void wave_ended(object sender, EventArgs e)
        {
            wave.Open(new Uri("Resources/Thunder.mp3", UriKind.Relative));
            wave.Play();
        }
        #endregion

        #region wind
        private void windSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            wind.Volume = windSlider.Value;
        }

        private void windIcon_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (windIcon.Opacity == 0.4)
            {
                windIcon.Opacity = 1;
                windSlider.IsEnabled = true;

                wind.Open(new Uri("Resources/Thunder.mp3", UriKind.Relative));
                wind.MediaEnded += new EventHandler(wind_ended);
                wind.Volume = 0.5;
                wind.Play();
            }
            else
            {
                windIcon.Opacity = 0.4;
                windSlider.IsEnabled = false;
                wind.Stop();
            }
        }

        private void wind_ended(object sender, EventArgs e)
        {
            wind.Open(new Uri("Resources/Thunder.mp3", UriKind.Relative));
            wind.Play();
        }
        #endregion

        #region train
        private void trainSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            train.Volume = trainSlider.Value;
        }

        private void trainIcon_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (trainIcon.Opacity == 0.4)
            {
                trainIcon.Opacity = 1;
                trainSlider.IsEnabled = true;

                train.Open(new Uri("Resources/Thunder.mp3", UriKind.Relative));
                train.MediaEnded += new EventHandler(train_ended);
                train.Volume = 0.5;
                train.Play();
            }
            else
            {
                trainIcon.Opacity = 0.4;
                trainSlider.IsEnabled = false;
                train.Stop();
            }
        }

        private void train_ended(object sender, EventArgs e)
        {
            train.Open(new Uri("Resources/Thunder.mp3", UriKind.Relative));
            train.Play();
        }
        #endregion

        #region night
        private void nightSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            night.Volume = nightSlider.Value;
        }

        private void nightIcon_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (nightIcon.Opacity == 0.4)
            {
                nightIcon.Opacity = 1;
                nightSlider.IsEnabled = true;

                night.Open(new Uri("Resources/Thunder.mp3", UriKind.Relative));
                night.MediaEnded += new EventHandler(night_ended);
                night.Volume = 0.5;
                night.Play();
            }
            else
            {
                nightIcon.Opacity = 0.4;
                nightSlider.IsEnabled = false;
                night.Stop();
            }
        }

        private void night_ended(object sender, EventArgs e)
        {
            night.Open(new Uri("Resources/Thunder.mp3", UriKind.Relative));
            night.Play();
        }
        #endregion

        #region fire
        private void fireSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            fire.Volume = fireSlider.Value;
        }

        private void fireIcon_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (fireIcon.Opacity == 0.4)
            {
                fireIcon.Opacity = 1;
                fireSlider.IsEnabled = true;

                fire.Open(new Uri("Resources/Thunder.mp3", UriKind.Relative));
                fire.MediaEnded += new EventHandler(fire_ended);
                fire.Volume = 0.5;
                fire.Play();
            }
            else
            {
                fireIcon.Opacity = 0.4;
                fireSlider.IsEnabled = false;
                fire.Stop();
            }
        }

        private void fire_ended(object sender, EventArgs e)
        {
            fire.Open(new Uri("Resources/Thunder.mp3", UriKind.Relative));
            fire.Play();
        }
        #endregion

        #region fall
        private void fallSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            fall.Volume = fallSlider.Value;
        }

        private void fallIcon_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (fallIcon.Opacity == 0.4)
            {
                fallIcon.Opacity = 1;
                fallSlider.IsEnabled = true;

                fall.Open(new Uri("Resources/Thunder.mp3", UriKind.Relative));
                fall.MediaEnded += new EventHandler(fall_ended);
                fall.Volume = 0.5;
                fall.Play();
            }
            else
            {
                fallIcon.Opacity = 0.4;
                fallSlider.IsEnabled = false;
                fall.Stop();
            }
        }

        private void fall_ended(object sender, EventArgs e)
        {
            fall.Open(new Uri("Resources/Thunder.mp3", UriKind.Relative));
            fall.Play();
        }

        #endregion
   
    }
}
