﻿using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace CrossPlat.Views.Controls
{
    public partial class DateTimePage : ContentPage
    {
        public DateTimePage()
        {
            InitializeComponent();
            dtPicker.MinimumDate = new DateTime(2017, 1, 1);
            dtPicker.MaximumDate = new DateTime(2018, 12, 1);
        }

        protected void dtPickerDateSelected(object sender, DateChangedEventArgs e){
            DisplayAlert("Date Selected",dtPicker.Date.ToString("MM/dd/yyyy"),"OK"); 
        }

        protected void btnSubmitClicked(object sender, EventArgs e){
            DateTime dt = dtPicker.Date + tiPicker.Time;
            String date = dt.ToString("MM/dd/yyyy hh:mm: tt");
            DisplayAlert("Submitted", date, "OK");
        }
    }
}
