using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Navigation;
using Windows.Storage;
using System.Threading.Tasks;
using Windows.Media;
using Windows.Media.Capture;

//using Windows.Media.MediaProperties;
//using Windows.Graphics.Imaging;
//using Windows.Storage.Streams;
//using Windows.Graphics.Display;
// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace CommandBar
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MediaCapture SnapShot;                   //this will be the mediacapture element
        TimeSpan _position;
        DispatcherTimer _timer = new DispatcherTimer();
        TimeSpan TotalTimeToday = new TimeSpan(0, 0, 0, 10, 0);
        public double totalDurationTime {set; get;}
        public double TimeAllowance = 500;
        public double TimeAddedbyParent = 0;
        public double TimeSaved = 0;
        public MainPage()
        {
            this.InitializeComponent();

            DispatcherTimerSetup();

            this.media.Source = new System.Uri("ms-appx:///Assets/fishes.wmv");  //start the media file

            //Get the total time for the media file
            Media_MediaOpened();
            //myRectangle.Width = totalDurationTime;

            //if after fullscreen user moves over media again, tune on commandBar once more.
            //using lambda notation, creating a handler for the mouse over the MediaElement, media 
            media.PointerEntered += (s, e) =>                               
            {
                InFocus();
            };

            //if the user clicks on the slider to change the position, then the position of the 
            //media element will change accordingly. 
            //This only covers the case in which the user clicks on the slider, and does NOT drag.
            sliderSeek.AddHandler(PointerPressedEvent,
                new PointerEventHandler(sliderSeek_Pointer_Change_Position), true);

        }

        DispatcherTimer dispatcherTimer;

        public void DispatcherTimerSetup()
         { 
            dispatcherTimer = new DispatcherTimer(); 
            dispatcherTimer.Tick += dispatcherTimer_Tick; 
            dispatcherTimer.Start(); 
        }

        void dispatcherTimer_Tick(object sender, object e)
        { 
             sliderSeek.Value = media.Position.Seconds;
        }

        private void media_MediaOpened(object sender, RoutedEventArgs e)
        {
            _position = this.media.Position;
            sliderSeek.Minimum = 0;
            sliderSeek.Maximum = this.media.NaturalDuration.TimeSpan.TotalSeconds;
        }

        private void sliderSeek_Pointer_Change_Position(object sender, RoutedEventArgs e)
        {
            int pos = Convert.ToInt32(sliderSeek.Value);
            media.Position = new TimeSpan(0, 0, 0, pos, 0);
        }

        private void sliderSeek_Dragging_Start(object sender, RoutedEventArgs e)
        {
            PauseVideo();
        }

        private void sliderSeek_Dragging_End(object sender, RoutedEventArgs e)
        {
            int pos = Convert.ToInt32(sliderSeek.Value);
            media.Position = new TimeSpan(0, 0, 0, pos, 0);
            PlayVideo();
        }
        public void Stop_Click(object sender, RoutedEventArgs e)
        {
            StopVideo();
        }

        public void Back_Click(object sender, RoutedEventArgs e)
        {
            PauseVideo();
            this.Frame.Navigate(typeof(MovieTitles), null);
        }

        public void Play_Click(object sender, RoutedEventArgs e)
        {
            PlayVideo();
            PlayPause.Icon = new SymbolIcon(Symbol.Pause); //toggle button to pause
        }
        
        public void Pause_Click(object sender, RoutedEventArgs e)
        {
            PauseVideo();
            PlayPause.Icon = new SymbolIcon(Symbol.Play); //toggle button to play
        }

        public void Full_Click(object sender, RoutedEventArgs e)
        {
            maximizeScreen();
            //could not find appropriate icon for minimizing screen
        }

        public void Small_Click(object sender, RoutedEventArgs e)
        {
            minimizeScreen();
        }
        public void Add_Stack_Image()
        {
            StackPanel Sp = new StackPanel();
            Sp.Orientation = Orientation.Horizontal;

            Image Img = new Image();
            Img.Source = new BitmapImage(new Uri("ms - appx:///Assets/StoreLogo.png"));

            Sp.Children.Add(Img);
        }

        public void PauseVideo()
        {
            media.Pause();
            //myStoryboard.Pause();
            //add code here to stop the timer
        }

        public void PlayVideo()
        {
            media.Play();
            //myStoryboard.Resume();
            //add code here to start the timer
        }

        public void StopVideo()
        {
            media.Stop();
            //myStoryboard.Pause();
            //add code here to stop the timer...
            //and restart the mediaelement position
        }

        public double getScreenWidthValue()
        {
            var bounds = Window.Current.Bounds;
            double height = bounds.Height;  //this is the new height of the rectangle.
            double width = bounds.Width;    //this is the new width of the rectangle.
            return width;
        }

        public void Media_MediaOpened()
        {
            OutofFocus();
        }

        public void OutofFocus()
        {
            GreenRect.Visibility = Visibility.Collapsed;
            BlueRect.Width = 10;
        }

        public void InFocus()
        {
            BottomCommand.Visibility = Visibility.Visible;
            GreenRect.Visibility = Visibility.Visible;
            BlueRect.Width = 50;
        }

        public void maximizeScreen()
        {
            media.IsFullWindow = true;
        }

        public void minimizeScreen()
        {
            media.IsFullWindow = false;
        }
    }
}
