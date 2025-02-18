﻿using ILoveNotes.Common;
using ILoveNotes.Controls;
using ILoveNotes.Data;
using ILoveNotes.DataModel;
using ILoveNotes.Pages;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Windows.ApplicationModel;
using Windows.ApplicationModel.Activation;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Grid App template is documented at http://go.microsoft.com/fwlink/?LinkId=234226

namespace ILoveNotes
{
    /// <summary>
    /// Provides application-specific behavior to supplement the default Application class.
    /// </summary>
    sealed partial class App : Application
    {
        //Lab 06 : Exercise 1 ,Task 2.1 : Add a variable to store the suspension time. 
        private DateTime m_lastSuspensionTime;

        /// <summary>
        /// Initializes the singleton Application object.  This is the first line of authored code
        /// executed, and as such is the logical equivalent of main() or WinMain().
        /// </summary>
        public App()
        {
            this.InitializeComponent();
            this.Suspending += OnSuspending;
            
            //Lab 06 : Exercise 1 ,Task 3.1 : register to the Resuming event.
            this.Resuming += OnResuming;
            this.UnhandledException += App_UnhandledException;
        }

        //Lab 06 : Exercise 1 ,Task 3.2 : implement the OnResuming method. 
        private void OnResuming(object sender, object e)
        {
            TimeSpan timeSinceLastSuspension = DateTime.UtcNow - m_lastSuspensionTime;
        }


        void App_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            DataManager.Save();
        }
        /// <summary>
        /// Invoked when the application is launched normally by the end user.  Other entry points
        /// will be used when the application is launched to open a specific file, to display
        /// search results, and so forth.
        /// </summary>
        /// <param name="args">Details about the launch request and process.</param>
        protected async override void OnLaunched(LaunchActivatedEventArgs args)
        {
            //Lab 06 : Exercise 1 ,Task 4.1 : implement the OnResuming method.
            if (args.Kind == ActivationKind.Launch)
            {
                if (args.PreviousExecutionState != ApplicationExecutionState.Terminated)
                {
                    // The application is starting regulary
                }
                else
                {
                    // The application has been terminated
                }
            }
            // Do not repeat app initialization when already running, just ensure that
            // the window is active
            if (args.PreviousExecutionState == ApplicationExecutionState.Running)
            {
// LAB #9 TILES
                Window.Current.Activate();
                return;
            }

            if (Window.Current.Content == null)
            {
                SplashScreen splashScreen = args.SplashScreen;
                Splash eSplash = new Splash(splashScreen, args);
                Window.Current.Content = eSplash;
                Window.Current.Activate();
                await eSplash.Init();
            }
        }

        /// <summary>
        /// Invoked when application execution is being suspended.  Application state is saved
        /// without knowing whether the application will be terminated or resumed with the contents
        /// of memory still intact.
        /// </summary>
        /// <param name="sender">The source of the suspend request.</param>
        /// <param name="e">Details about the suspend request.</param>
        private async void OnSuspending(object sender, SuspendingEventArgs e)
        {
            //Lab 06 : Exercise 1 ,Task 2.1 : Store the time upon suspension and debug the app.
            m_lastSuspensionTime = DateTime.UtcNow;

            var deferral = e.SuspendingOperation.GetDeferral();
            DataManager.Save();
            
            //Lab 06 : Exercise 2 ,Task 1.1 : save the navigation state on suspension
            await SuspensionManager.SaveAsync();
            deferral.Complete();
        }
        // LAB #8 - CONTRACTS

        protected override void OnFileOpenPickerActivated(Windows.ApplicationModel.Activation.FileOpenPickerActivatedEventArgs args)
        {
            var fileOpenPickerPage = new FileOpenPickerPage();
            fileOpenPickerPage.Activate(args);
        }

        protected override void OnFileSavePickerActivated(Windows.ApplicationModel.Activation.FileSavePickerActivatedEventArgs args)
        {
            var fileSavePickerPage = new FileSavePickerPage();
            fileSavePickerPage.Activate(args);
        }
    }
}
