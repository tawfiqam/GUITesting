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

        public MainPage()
        {
            this.InitializeComponent();

            this.media.Source = new System.Uri("ms-appx:///Assets/fishes.wmv");
            

            //if after fullscreen user moves over media again, tune on commandBar once more.
            //using lambda notation, creating a handler for the mouse over the MediaElement, media 
            media.PointerEntered += (s, e) =>                               
            {
                BottomCommand.Visibility = Visibility.Visible;
            };
        }

        public void Stop_Click(object sender, RoutedEventArgs e)
        {
            media.Stop();
        }

        public void Back_Click(object sender, RoutedEventArgs e)
        {
            media.Pause();
            this.Frame.Navigate(typeof(MovieTitles), null);
        }

        public void Like_Click(object sender, RoutedEventArgs e)
        {

        }

        public void Dislike_Click(object sender, RoutedEventArgs e)
        {

        }

        public void Play_Click(object sender, RoutedEventArgs e)
        {
            media.Play();
            PlayPause.Icon = new SymbolIcon(Symbol.Pause); //toggle button to pause
        }
        
        public void Pause_Click(object sender, RoutedEventArgs e)
        {
            media.Pause();
            PlayPause.Icon = new SymbolIcon(Symbol.Play); //toggle button to play
        }

        public void Full_Click(object sender, RoutedEventArgs e)
        {
            media.IsFullWindow = true;
            BottomCommand.Visibility = Visibility.Collapsed;
            //could not find appropriate icon for minimizing screen
        }

        public void Small_Click(object sender, RoutedEventArgs e)
        {
            media.IsFullWindow = false;
        }


        public void Add_Stack_Image()
        {
            StackPanel Sp = new StackPanel();
            Sp.Orientation = Orientation.Horizontal;

            Image Img = new Image();
            Img.Source = new BitmapImage(new Uri("ms - appx:///Assets/StoreLogo.png"));

            Sp.Children.Add(Img);
        }

        //public async void SaveImageVid() //attempting to take a screenshot of each of the video files
        //{
            //SnapShot.CapturePhotoToStreamAsync.media;
            //var previewProperties = SnapShot.VideoDeviceController.GetMediaStreamProperties(MediaStreamType.VideoPreview) as VideoEncodingProperties;
            //VideoFrame videoFrame = new VideoFrame(BitmapPixelFormat.Bgra8, (int)previewProperties.Width, (int)previewProperties.Height);
            //VideoFrame previewFrame = await SnapShot.GetPreviewFrameAsync(videoFrame);
            //SoftwareBitmap previewBitmap = previewFrame.SoftwareBitmap;
            //StorageFolder localFolder = Windows.Storage.ApplicationData.Current.LocalFolder;
            //StorageFile newFile = await localFolder.CreateFileAsync("sample"+".jpg", CreationCollisionOption.ReplaceExisting);
            //Size dpi = new Size(96, 96);
            //RenderTargetBitmap bmp = new RenderTargetBitmap(300, 200,dpi.Width, dpi.Height, PixelFormats.Pbgra32);
            //bmp.Render(media);

            //JpegBitmapEncoder encoder = new JpegBitmapEncoder();
            //encoder.Frames.Add(BitmapFrame.Create(bmp));

            //string filename = Guid.NewGuid().ToString() + ".jpg";
            //FileStream fs = new FileStream(filename, FileMode.Create);
            //encoder.Save(fs);


            //Process.Start(filename);

        //public async Task<IInputStream> GetThumbnailAsync(StorageFile file)
        //{   
        //    var mediaClip = await MediaClip.CreateFromFileAsync(file);

        //    var mediaComposition = new MediaComposition();
        //    mediaComposition.Clips.Add(mediaClip);

        //    return await mediaComposition.GetThumbnailAsync(
        //        TimeSpan.Zero, 0, 0, VideoFramePrecision.NearestFrame);
        //}

    }

    
}
