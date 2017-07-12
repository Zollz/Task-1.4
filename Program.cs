using System;
using System.Threading;
using SplashKitSDK;

public class Program
{
    public static void Main()
    {
        Window firstWindow;
        firstWindow = new Window("Animation", 1280, 720);

        Bitmap animation10 = new Bitmap("animation1", "breed_picture.png");
        Bitmap animation2 = new Bitmap("animation2", "Shiba.png");
        Bitmap animation3 = new Bitmap("animation3", "Shiba.png");
        Bitmap animation4 = new Bitmap("animation4", "Shiba.png");
        Bitmap animation5 = new Bitmap("animation5", "Shiba.png");
        Bitmap animation6 = new Bitmap("animation6", "Shiba.png");
        Bitmap animation7 = new Bitmap("animation7", "Shiba.png");
        Bitmap animation8 = new Bitmap("animation8", "Shiba.png");
        SoundEffect Bark = new SoundEffect("Bark", "dog_bark_x.wav");
        
        
        
        firstWindow.Clear(Color.White);
        firstWindow.DrawBitmap(animation1, 450, 300);
        firstWindow.Refresh(60);
        
         
        SplashKit.Delay(2000);
        
        firstWindow.Clear(Color.White);
        firstWindow.DrawBitmap(animation2, 300, 300);
        firstWindow.Refresh(60);
        SplashKit.Delay(2000);
        
        firstWindow.Clear(Color.White);
        firstWindow.DrawBitmap(animation3, 300, 300);
        firstWindow.Refresh(60);
        SplashKit.Delay(2000);
        
        firstWindow.Clear(Color.White);
        firstWindow.DrawBitmap(animation4, 300, 300);
        firstWindow.Refresh(60);
        SplashKit.Delay(2000);
        
        firstWindow.Clear(Color.White);
        firstWindow.DrawBitmap(animation5, 300, 300);
        firstWindow.Refresh(60);
        SplashKit.Delay(2000);
        
        firstWindow.Clear(Color.White);
        firstWindow.DrawBitmap(animation6, 300, 300);
        firstWindow.Refresh(60);
        SplashKit.Delay(2000);

    }
}
