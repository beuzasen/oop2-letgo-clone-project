﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LetGoCloneStudentProject
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //MainPage = new LetGoCloneStudentProject.Pages.LoginPage();
            MainPage = new NavigationPage(new LetGoCloneStudentProject.Pages.LoginPage());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
