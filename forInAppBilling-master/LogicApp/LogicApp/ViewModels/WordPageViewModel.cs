using System;
using System.ComponentModel;
using Xamarin.Forms;
using System.Windows.Input;
using System.Threading.Tasks;
using System.Threading;
using System.Diagnostics;
using Xamarin.Essentials;
using System.IO;

namespace LogicApp.ViewModels
{
    class WordPageViewModel : INotifyPropertyChanged
    {
        double progression;
        int groupeNumber = -1;
        int subGroupNumber = -1;
        int currentImageNumber = -1;
        int lastImage = -1;
        int timeBeforeRecord = 500;
        string imageSourceName;
        string playImageSource;
        string playbackSourceName;
        string progressionString = "Progression...";
        string NextButtonText = Resources.AppResources.Next;
        string PreviousButtonText = Resources.AppResources.Previous;
        bool IsPlaying = false;
        // List of the number of words per group
        //protected int[] numberWordsList = { 10, 20, 25, 35, 54 };
        CancellationTokenSource _Cts;
        ICommand tapCommand;
        ICommand automatedPlay;

        public event PropertyChangedEventHandler PropertyChanged;

        // Constructor
        public WordPageViewModel()
        {
            _Cts = new System.Threading.CancellationTokenSource();
            // Handle buttons pressed
            PreviousWord = new Command(() =>
            {
                // Display previous image
                // Change number
                UpdateCurrent -= 1;
            },
            () =>
            {
                // Return true if there is a previous picture to be displayed.
                return (currentImageNumber > 0) && !IsPlaying;
            });

            NextWord = new Command(() =>
            {
                // Display next image
                // Change number
                UpdateCurrent += 1;
            },
            () =>
            {
                // Return true if there is a next picture to be displayed.
                return (currentImageNumber < (lastImage - 1)) && !IsPlaying;
            });

            // configure the TapCommand with a method
            tapCommand = new Command(OnTapped);

            // Configure the AutomatedPlay with a method
            automatedPlay = new Command(OnPlayPressed);

            /* InitializeGroup = new Command<int>((group) =>
             {
                 UpdateGroupNumber = group;
                 lastImage = numberWordsList[groupeNumber - 1];
             });

             InitializeCurrent = new Command<int>((current) =>
             {
                 // Set current and update everything
                 UpdateCurrent = current;
                 UpdateValues();

                 // Make sure the buttons can still be clicked
                 ((Command)PreviousWord).ChangeCanExecute();
                 ((Command)NextWord).ChangeCanExecute();
             });*/
        }

        /*public void Prepare(MyParameterModel parameter)
        {

        }*/

        public void UpdateValues()
        {
            // Update image source and progression
            UpdateSourceName = Helpers.Data.GroupImages[groupeNumber][subGroupNumber][currentImageNumber];// + ".png";
            UpdateProgressionString = Resources.AppResources.Progression + (currentImageNumber + 1) + "/" + lastImage;
            UpdateProgressionBar = (double)(currentImageNumber + 1) / lastImage;
            LaunchPlayer(timeBeforeRecord);
        }

        public async void LaunchPlayer(int time)
        {
            // Send a warning if volume is 0 /!\ device-dependent!
            // TODO: make this happen!
            //AudioManager am = (AudioManager)this.GetSystemService (Context.AudioService); // from using Android.Media
            //int musicVolume = audio.getStreamVolume(AudioManager.STREAM_MUSIC);
            //
            //if (musicVolume == 0)
            //{
            //    Toast.makeText(this, "Voume is muted.", Toast.LENGTH_SHORT).show();
            //}
            await WaitAndExecute(time, () =>
            {
                //var current = currentImageNumber;
                var player = Plugin.SimpleAudioPlayer.CrossSimpleAudioPlayer.Current;
                playbackSourceName = Helpers.Data.GroupImages[groupeNumber][subGroupNumber][currentImageNumber] + ".mp3";

                player.Load(playbackSourceName);
                player.Play();
            });
        }

        public void LaunchAutomatedPlay(int delay)
        {
            bool shallContinue = true;
            Debug.WriteLine("Entering");
            Device.StartTimer(TimeSpan.FromMilliseconds(delay), () =>
            {
                if (currentImageNumber < (lastImage - 1))
                {
                    shallContinue = IsPlaying;
                    if (IsPlaying)
                    {
                        UpdateCurrent += 1;
                    }
                }
                else
                {
                    // Simulate button pressed if last image reached
                    OnPlayPressed(null);
                    shallContinue = false;
                }

                return shallContinue;
            });
        }

        protected async Task WaitAndExecute(int milisec, Action actionToExecute)
        {
            // Cancel other tasks if needed
            if (_Cts.Token.CanBeCanceled)
            {
                _Cts.Cancel();
                _Cts = new System.Threading.CancellationTokenSource();
            }
            try
            {
                await Task.Delay(milisec, _Cts.Token);
                actionToExecute();
            }
            catch (TaskCanceledException ex)
            {
                // Do nothing
                Debug.WriteLine("Task cancelled: " + ex);
            }
        }

        public void InitializeGroup(int group, int subGroup, int current)
        {
            UpdateGroupNumber = group;
            UpdateSubgroup = subGroup;
            UpdateCurrent = current;
            ((Command)PreviousWord).ChangeCanExecute();
            ((Command)NextWord).ChangeCanExecute();
            playImageSource = "play_button"; // It is always play at first
        }

        // Public properties
        public string UpdateSourceName
        {
            protected set
            {
                if (imageSourceName != value)
                {
                    imageSourceName = value;
                    OnPropertyChanged("UpdateSourceName");
                }
            }

            get { return imageSourceName; }
        }

        public string UpdatePlayImageSource
        {
           protected set
            {
                if (playImageSource != value)
                {
                    playImageSource = value;
                    OnPropertyChanged("UpdatePlayImageSource");
                }
            }

            get { return playImageSource; }
        }

        public string UpdateProgressionString
        {
            protected set
            {
                if (progressionString != value)
                {
                    progressionString = value;
                    OnPropertyChanged("UpdateProgressionString");
                }
            }

            get { return progressionString; }
        }

        public double UpdateProgressionBar
        {
            protected set
            {
                if (progression != value)
                {
                    progression = value;
                    OnPropertyChanged("UpdateProgressionBar");
                }
            }

            get { return progression; }
        }

        public int UpdateGroupNumber
        {
            protected set
            {
                if (groupeNumber != value)
                {
                    groupeNumber = value;
                }
            }

            get { return groupeNumber; }
        }

        public int UpdateSubgroup
        {
            protected set
            {
                if (subGroupNumber != value)
                {
                    // Update value
                    subGroupNumber = value;
                    lastImage = (Helpers.Data.GroupImages[groupeNumber][subGroupNumber]).Length; // Update the value of last word for this subgroup
                }
            }

            get { return subGroupNumber; }
        }

        public int UpdateCurrent
        {
            protected set
            {
                if (currentImageNumber != value)
                {
                    // Update value
                    currentImageNumber = value;

                    // Make sure the buttons can still be clicked
                    ((Command)PreviousWord).ChangeCanExecute();
                    ((Command)NextWord).ChangeCanExecute();

                    //Update images and progression
                    UpdateValues();
                }
            }

            get { return currentImageNumber; }
        }

        public void CancelSound()
        {
            IsPlaying = false;
            if (_Cts.Token.CanBeCanceled)
            {
                _Cts.Cancel();
            }
        }

        // ICommand implementations
        public ICommand NextWord { protected set; get; }
        public ICommand PreviousWord { protected set; get; }
        public ICommand TapCommand
        {
            get { return tapCommand; }
        }
        public ICommand AutomatedPlay {
            get { return automatedPlay; }
        }

        // When image tapped, launch sound again
        protected void OnTapped(object s)
        {
            LaunchPlayer(10);
        }

        // When play button pressed
        protected void OnPlayPressed(object s)
        {
            // Play if not already playing
            if (!IsPlaying)
            {
                // It is now playing
                IsPlaying = true;

                // Update button image
                UpdatePlayImageSource = "pause_button";

                // Disable navigation buttons
                ((Command)PreviousWord).ChangeCanExecute();
                ((Command)NextWord).ChangeCanExecute();

                // Set new time before record
                timeBeforeRecord = 0;

                // Launch image change
                LaunchAutomatedPlay(1500);

                // Immediately launch record of current word
                LaunchPlayer(0);

                // Prevent screen from turning off
                if (!DeviceDisplay.KeepScreenOn)
                    DeviceDisplay.KeepScreenOn = true;
            }
            else
            {
                UpdatePlayImageSource = "play_button";

                // It is not playing any more
                IsPlaying = false;

                // Enable navigation buttons
                ((Command)PreviousWord).ChangeCanExecute();
                ((Command)NextWord).ChangeCanExecute();

                // Stop playing
                CancelSound();

                // Set back time before record
                timeBeforeRecord = 500;

                // Screen can turn off
                DeviceDisplay.KeepScreenOn = false;
            }
        }

        // Update where bound
        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
