using System;
using System.Threading;
using SplashKitSDK;

public class Program
{
    public static void Main()
    {
        Window firstWindow;
        firstWindow = new Window("Goku Animation", 400, 400);

        Bitmap sprite1 = new Bitmap("sprite1", "resources/sprite1.png");
        Bitmap sprite2 = new Bitmap("sprite2", "resources/sprite2.png");
        Bitmap sprite3 = new Bitmap("sprite3", "resources/sprite3.png");
        Bitmap sprite4 = new Bitmap("sprite4", "resources/sprite4.png");
        Bitmap sprite5 = new Bitmap("sprite5", "resources/sprite5.png");
        Bitmap sprite6 = new Bitmap("sprite6", "resources/sprite6.png");
        Bitmap sprite7 = new Bitmap("sprite7", "resources/sprite7.png");
        Bitmap sprite8 = new Bitmap("sprite8", "resources/sprite14.png");
        Bitmap sprite9 = new Bitmap("sprite9", "resources/sprite15.png");
        Bitmap sprite10 = new Bitmap("sprite10", "resources/sprite16.png");
        Bitmap sprite11 = new Bitmap("sprite11", "resources/sprite17.png");
        Bitmap sprite12 = new Bitmap("sprite12", "resources/sprite18.png");
        Bitmap sprite13 = new Bitmap("sprite13", "resources/sprite19.png");
        Bitmap sprite14 = new Bitmap("sprite14", "resources/sprite20.png");
        Bitmap sprite15 = new Bitmap("sprite15", "resources/sprite21.png");
        Bitmap sprite16 = new Bitmap("sprite16", "resources/sprite12.png");
        Bitmap sprite17 = new Bitmap("sprite17", "resources/sprite11.png");
        Bitmap sprite18 = new Bitmap("sprite18", "resources/sprite9.png");
        Bitmap sprite19 = new Bitmap("sprite19", "resources/sprite22.png");
        Bitmap sprite20 = new Bitmap("sprite20", "resources/sprite23.png");

        SoundEffect aura = new SoundEffect("aura", "resources/aura.wav");
        SoundEffect lightning = new SoundEffect("lightning", "resources/soundeffect1.wav");
        SoundEffect lightning2 = new SoundEffect("lightning2", "resources/soundeffect2.wav");
        
        firstWindow.Clear(Color.White);
        firstWindow.DrawBitmap(sprite1, 150, 150);
        firstWindow.Refresh(60);
        
         
        SplashKit.Delay(2000);
        
        firstWindow.Clear(Color.White);
        firstWindow.DrawBitmap(sprite2, 150, 150);
        firstWindow.Refresh(60);
        SplashKit.Delay(500);
        
        firstWindow.Clear(Color.White);
        firstWindow.DrawBitmap(sprite3, 150, 150);
        firstWindow.Refresh(60);
        SplashKit.Delay(500);
        
        firstWindow.Clear(Color.White);
        firstWindow.DrawBitmap(sprite4, 150, 150);
        firstWindow.Refresh(60);
        SplashKit.Delay(500);

        aura.Play();
        
        firstWindow.Clear(Color.White);
        firstWindow.DrawBitmap(sprite5, 150, 150);
        firstWindow.Refresh(60);
        SplashKit.Delay(500);

        lightning.Play();
        
        firstWindow.Clear(Color.White);
        firstWindow.DrawBitmap(sprite6, 150, 150);
        firstWindow.Refresh(60);
        SplashKit.Delay(500);
        
        firstWindow.Clear(Color.White);
        firstWindow.DrawBitmap(sprite7, 150, 150);
        firstWindow.Refresh(60);
        SplashKit.Delay(5000);

        firstWindow.Clear(Color.White);
        firstWindow.DrawBitmap(sprite8, 150, 150);
        firstWindow.Refresh(60);
        SplashKit.Delay(500);

        firstWindow.Clear(Color.White);
        firstWindow.DrawBitmap(sprite9, 150, 150);
        firstWindow.Refresh(60);
        SplashKit.Delay(500);

        firstWindow.Clear(Color.White);
        firstWindow.DrawBitmap(sprite10, 150, 150);
        firstWindow.Refresh(60);
        SplashKit.Delay(1000);

        aura.Play();

        firstWindow.Clear(Color.White);
        firstWindow.DrawBitmap(sprite11, 150, 150);
        firstWindow.Refresh(60);
        SplashKit.Delay(1000);

        firstWindow.Clear(Color.White);
        firstWindow.DrawBitmap(sprite12, 150, 150);
        firstWindow.Refresh(60);
        SplashKit.Delay(1000);

        firstWindow.Clear(Color.White);
        firstWindow.DrawBitmap(sprite13, 150, 150);
        firstWindow.Refresh(60);
        SplashKit.Delay(1000);

        lightning2.Play();

        firstWindow.Clear(Color.White);
        firstWindow.DrawBitmap(sprite14, 150, 150);
        firstWindow.Refresh(60);
        SplashKit.Delay(6000);
        
        firstWindow.Clear(Color.White);
        firstWindow.DrawBitmap(sprite15, 150, 150);
        firstWindow.Refresh(60);
        SplashKit.Delay(500);

        firstWindow.Clear(Color.White);
        firstWindow.DrawBitmap(sprite16, 150, 150);
        firstWindow.Refresh(60);
        SplashKit.Delay(500);

        firstWindow.Clear(Color.White);
        firstWindow.DrawBitmap(sprite17, 150, 150);
        firstWindow.Refresh(60);
        SplashKit.Delay(500);

        firstWindow.Clear(Color.White);
        firstWindow.DrawBitmap(sprite18, 150, 150);
        firstWindow.Refresh(60);
        SplashKit.Delay(500);

        firstWindow.Clear(Color.White);
        firstWindow.DrawBitmap(sprite19, 150, 150);
        firstWindow.Refresh(60);
        SplashKit.Delay(500);

        firstWindow.Clear(Color.White);
        firstWindow.DrawBitmap(sprite20, 150, 150);
        firstWindow.Refresh(60);
        SplashKit.Delay(5000);

    }
}
