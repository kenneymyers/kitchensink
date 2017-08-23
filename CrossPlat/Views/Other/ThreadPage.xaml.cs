using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Xamarin.Forms;
using System.Diagnostics;

namespace CrossPlat.Views.Other
{
    public partial class ThreadPage : ContentPage
    {

		public static CancellationTokenSource CancellationToken { get; set; }
		private Label _label = new Label();

		public ThreadPage()
        {
            InitializeComponent();
            _label = lblTimer;
        }

        public void ThreadOnStart(object sender, EventArgs e)
		{
			// Handle when your app starts
			Task.Run(async () => timer());
		}

		private int _counter = 0;
		private async Task timer()
		{

			CancellationToken = new CancellationTokenSource();
			while (!CancellationToken.IsCancellationRequested)
			{
				try
				{
					//await Task.Delay(60000 - (int)(watch.ElapsedMilliseconds%1000), token);
					CancellationToken.Token.ThrowIfCancellationRequested();
					await Task.Delay(1000, CancellationToken.Token).ContinueWith(async (arg) => {

						if (!CancellationToken.Token.IsCancellationRequested)
						{
							CancellationToken.Token.ThrowIfCancellationRequested();
							/*
							 * HERE YOU CAN DO YOUR ACTION
							 */

							Device.BeginInvokeOnMainThread(() => _label.Text = (++_counter).ToString());
							Debug.WriteLine("TimerRunning " + _counter.ToString());// + watch.Elapsed.ToString ());
						}
					});
					//Debug.WriteLine (DateTime.Now.ToLocalTime ().ToString () + " DELAY: " + delay);

				}
				catch (Exception ex)
				{
			        Debug.WriteLine("EX 1: " + ex.Message);
				}
			}
		}

		public void ThreadOnSleep(object sender, EventArgs e)
		{
			// Handle when your app sleeps
			if (CancellationToken != null)
			{
				CancellationToken.Cancel();
				//App.CancellationToken = null;
			}
		}

		public void ThreadOnResume(object sender, EventArgs e)
		{
			// Handle when your app resumes
			Task.Run(async () => timer());
		}

    }
}
