using System;
using Xamarin.Forms;
using Plugin.Media;
using Microsoft.ProjectOxford.Emotion.Contract;
using System.Linq;
using System.Diagnostics;
using System.Threading.Tasks;
using Plugin.Media.Abstractions;

namespace Workshop
{
    public partial class WorkshopPage : ContentPage
    {
        private Emotion[] currentEmotions;
        private MediaFile picture;

        public WorkshopPage()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
            //Additional
            GetDetailEmotion.IsEnabled = false;
        }


        //3.Take Photo
        private async Task TakePhoto()
        {

        }

        //5.Analyzse the Emotions by Service
        private async Task<Emotion[]> GetEmotions()
        {
            return null;
        }

        //6.Process the Emotion 
        private void ProcessEmotions(Emotion[] emotionArray)
        {

        }

        // 6.1 Get Smilye based on the Happiness value
        private string GetSmiley(double happiness)
        {
            if (happiness >= 0.75)
            {
                return "\ud83d\ude00"; //smiley with teeth
            }
            else if (happiness < 0.75 && happiness >= 0.5)
            {
                return "\ud83d\ude42"; //normal smiley
            }
            else if (happiness < 0.5 && happiness >= 0.25)
            {
                return "☹️"; // sad face
            }
            else
            {
                return "\ud83d\ude2d"; //crying face
            }
        }
    }
}