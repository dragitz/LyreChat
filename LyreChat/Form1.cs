using System;
using System.IO;
using System.Media;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Windows.Forms;

namespace LyreChat
{

    public partial class Window : Form
    {
        public Window()
        {
            InitializeComponent();
        }
        public static class Globals
        {

            
            public static String PHRASE = "";
            public static String PHRASE_OLD = "";

        }

        private async void Say_Click(object sender, EventArgs e)
        {

            Globals.PHRASE = Input.Text;

            //This IF prevents requesting again the same phrase, it's faster
            if (Globals.PHRASE != "")
            {
                if (Globals.PHRASE != Globals.PHRASE_OLD)
                {
                    Globals.PHRASE_OLD = Input.Text;

                    var handler = new HttpClientHandler();

                    // If you are using .NET Core 3.0+ you can replace `~DecompressionMethods.None` to `DecompressionMethods.All`
                    handler.AutomaticDecompression = ~DecompressionMethods.None;
                    using (var httpClient = new HttpClient(handler))
                    {
                        using (var request = new HttpRequestMessage(new HttpMethod("POST"), "https://public.lyrebird.ai/api/public/overdub"))
                        {

                            //Here we take the input
                            request.Content = new StringContent("{\"voice_id\":\"" + narrator.Text + "\",\"text\":\"" + Input.Text + "\"}");
                            request.Content.Headers.ContentType = MediaTypeHeaderValue.Parse("application/json");

                            //send request to site
                            var send = await httpClient.SendAsync(request);

                            //We save it (in the .exe folder)
                            File.WriteAllBytes("output.wav", await send.Content.ReadAsByteArrayAsync());

                            SoundPlayer my_wave_file = new SoundPlayer("output.wav");
                            my_wave_file.PlaySync();


                        }
                    }
                }
                else
                {
                    //We play the audio
                    SoundPlayer my_wave_file = new SoundPlayer("output.wav");
                    my_wave_file.PlaySync();
                }
            }
        }

        private void narrator_SelectedIndexChanged(object sender, EventArgs e)
        {
            Globals.PHRASE_OLD = "";
        }
    }
}
