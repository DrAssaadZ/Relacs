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
    /// Interaction logic for Instruments.xaml
    /// </summary>
    public partial class Instruments : UserControl
    {
        //media players
        MediaPlayer piano = new MediaPlayer();
        MediaPlayer guitar = new MediaPlayer();
        MediaPlayer violin = new MediaPlayer();
        MediaPlayer cello = new MediaPlayer();
        MediaPlayer harp = new MediaPlayer();
        MediaPlayer flute = new MediaPlayer();

        public Instruments()
        {
            InitializeComponent();
        }

        #region guitar
        //guitar icon click event
        private void guitarInstrumentIcon_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (guitarInstrumentIcon.Opacity == 0.4)
            {
                guitarInstrumentIcon.Opacity = 1;
                guitarSoundSlider.IsEnabled = true;

                guitar.Open(new Uri("Resources/Thunder.mp3", UriKind.Relative));
                guitar.MediaEnded += new EventHandler(guitar_ended);
                guitar.Volume = 0.5;
                guitar.Play();
            }
            else
            {
                guitarInstrumentIcon.Opacity = 0.4;
                guitarSoundSlider.IsEnabled = false;
                guitar.Stop();
            }
        }

        //guitar sound volume slider
        private void guitarSoundSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            guitar.Volume = guitarSoundSlider.Value;
        }

        //looping the guitar sound 
        private void guitar_ended(object sender, EventArgs e)
        {
            guitar.Open(new Uri("Resources/Thunder.mp3", UriKind.Relative));
            guitar.Play();
        }
        #endregion

        #region guitar
        //piano icon click event
        private void pianoInstrumentIcon_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (pianoInstrumentIcon.Opacity == 0.4)
            {
                pianoInstrumentIcon.Opacity = 1;
                pianoSoundSlider.IsEnabled = true;

                piano.Open(new Uri("Resources/Thunder.mp3", UriKind.Relative));
                piano.MediaEnded += new EventHandler(piano_ended);
                guitar.Volume = 0.5;
                piano.Play();
            }
            else
            {
                pianoInstrumentIcon.Opacity = 0.4;
                pianoSoundSlider.IsEnabled = false;
                piano.Stop();
            }
        }

        //piano volume slider
        private void pianoSoundSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            piano.Volume = pianoSoundSlider.Value;
        }

        //looping piano sound
        private void piano_ended(object sender, EventArgs e)
        {
            piano.Open(new Uri("Resources/Thunder.mp3", UriKind.Relative));
            piano.Play();
        }
        #endregion

        #region violin
        //violin icon click event
        private void violinInstrumentIcon_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (violinInstrumentIcon.Opacity == 0.4)
            {
                violinInstrumentIcon.Opacity = 1;
                violinSoundSlider.IsEnabled = true;

                violin.Open(new Uri("Resources/Thunder.mp3", UriKind.Relative));
                violin.MediaEnded += new EventHandler(violin_ended);
                violin.Volume = 0.5;
                violin.Play();
            }
            else
            {
                violinInstrumentIcon.Opacity = 0.4;
                violinSoundSlider.IsEnabled = false;
                violin.Stop();

            }
        }

        //looping the violin sound
        private void violin_ended(object sender, EventArgs e)
        {
            violin.Open(new Uri("Resources/Thunder.mp3", UriKind.Relative));
            violin.Play();

        }

        //violin volume slider
        private void violinSoundSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            violin.Volume = violinSoundSlider.Value;
        }
        #endregion

        #region cello
        //cello icon click event
        private void celloInstrumentIcon_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (celloInstrumentIcon.Opacity == 0.4)
            {
                celloInstrumentIcon.Opacity = 1;
                celloSoundSlider.IsEnabled = true;

                cello.Open(new Uri("Resources/Thunder.mp3", UriKind.Relative));
                cello.MediaEnded += new EventHandler(cello_ended);
                cello.Volume = 0.5;
                cello.Play();
            }
            else
            {
                celloInstrumentIcon.Opacity = 0.4;
                celloSoundSlider.IsEnabled = false;
                cello.Stop();
            }
        }

        //looping the cello sound
        private void cello_ended(object sender, EventArgs e)
        {
            cello.Open(new Uri("Resources/Thunder.mp3", UriKind.Relative));
            cello.Play();
        }

        //cello volume slider
        private void celloSoundSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            cello.Volume = celloSoundSlider.Value;
        }
        #endregion

        #region flute
        //flute icon click event
        private void fluteInstrumentIcon_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (fluteInstrumentIcon.Opacity == 0.4)
            {
                fluteInstrumentIcon.Opacity = 1;
                fluteSoundSlider.IsEnabled = true;

                flute.Open(new Uri("Resources/Thunder.mp3", UriKind.Relative));
                flute.MediaEnded += new EventHandler(flute_ended);
                flute.Volume = 0.5;
                flute.Play();
            }
            else
            {
                fluteInstrumentIcon.Opacity = 0.4;
                fluteSoundSlider.IsEnabled = false;
                flute.Stop();
            }
        }

        //looping flute sound
        private void flute_ended(object sender, EventArgs e)
        {
            flute.Open(new Uri("Resources/Thunder.mp3", UriKind.Relative));
            flute.Play();
        }

        //flute volume slider
        private void fluteSoundSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            flute.Volume = fluteSoundSlider.Value;
        }
        #endregion

        #region harp
        //harp icon click event
        private void harpInstrumentIcon_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (harpInstrumentIcon.Opacity == 0.4)
            {
                harpInstrumentIcon.Opacity = 1;
                harpSoundSlider.IsEnabled = true;

                harp.Open(new Uri("Resources/Thunder.mp3", UriKind.Relative));
                harp.MediaEnded += new EventHandler(harp_ended);
                harp.Volume = 0.5;
                harp.Play();
            }
            else
            {
                harpInstrumentIcon.Opacity = 0.4;
                harpSoundSlider.IsEnabled = false;
                harp.Stop();
            }
        }

        //looping harp sound
        private void harp_ended(object sender, EventArgs e)
        {
            harp.Open(new Uri("Resources/Thunder.mp3", UriKind.Relative));
            harp.Play();
        }

        //flute volume slider
        private void harpSoundSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            harp.Volume = harpSoundSlider.Value;
        }
        #endregion
    }
}
