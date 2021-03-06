﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace Anglian.Views
{
    public partial class MainMenuPage : ContentPage
    {
        public MainMenuPage()
        {
            InitializeComponent();
            this.Title = "Main Menu Options";
            //this.ToolbarItems.Add(new ToolbarItem() { Icon = "down.png", Command = new Command(() => DisplayAlert("asf", "asdf", "aa")) });
            this.ToolbarItems.Add(new ToolbarItem()
            {
                Text = "Download",
                Icon = String.Format("{0}{1}.png", 
                Device.OnPlatform("Icons/", "", "Assets/Icons/"), "down"),
                Command = new Command(() => DownBtn_Tapped())
            });
            this.ToolbarItems.Add(new ToolbarItem()
            {
                Text = "Sync",
                Icon = String.Format("{0}{1}.png", 
                Device.OnPlatform("Icons/", "", "Assets/Icons/"), "refresh"),
                Command = new Command(() => SyncBtn_Tapped())
            });
            this.ToolbarItems.Add(new ToolbarItem()
            {
                Text = "Settings",
                Icon = String.Format("{0}{1}.png", 
                Device.OnPlatform("Icons/", "", "Assets/Icons/"), "configuration"),
                Command = new Command(() => SettingBtn_Tapped())
            });
        }
        private void SettingBtn_Tapped()
        {
            Device.BeginInvokeOnMainThread(() => Navigation.PushAsync(new UserSettingPage()));
        }
        private void DownBtn_Tapped()
        {
            Device.BeginInvokeOnMainThread(() => Navigation.PushAsync(new ProjectDownloadsSearchPage()));
            //await this.Navigation.PushAsync(new DateSearchResultView(items));
        }
        private void SyncBtn_Tapped()
        {
            Device.BeginInvokeOnMainThread(() => Navigation.PushAsync(new ProjectSyncPage()));
            //await this.Navigation.PushAsync(new DateSearchResultView(items));
        }

        private void GotoDateSearchFilterView(object sender, EventArgs args)
        {
            Device.BeginInvokeOnMainThread(() => Navigation.PushAsync(new DateSearchFilterPage()));
            //await this.Navigation.PushAsync(new DateSearchFilterView());
        }
        private void GotoProcessSurveysPage(object sender, EventArgs args)
        {
            Device.BeginInvokeOnMainThread(() => Navigation.PushAsync(new ProcessSurveysPage()));
            //await this.Navigation.PushAsync(new DateSearchFilterView());
        }
    }
}
