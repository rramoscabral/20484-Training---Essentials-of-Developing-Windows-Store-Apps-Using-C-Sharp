﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Xml.Serialization;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Storage;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace UWP_HandlingFilesDemo.Views
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class XMLSerialization : Page
    {
        public XMLSerialization()
        {
            this.InitializeComponent();
        }

        async private void Button_Click(object sender, RoutedEventArgs e)
        {
            var test = "Teste";

            StorageFolder storageFolder = Windows.Storage.ApplicationData.Current.LocalFolder;
            StorageFile storageFile = await storageFolder.CreateFileAsync("XMLSerialization.xml", CreationCollisionOption.ReplaceExisting);
            Stream stream = await storageFile.OpenStreamForWriteAsync();
            XmlSerializer ser = new XmlSerializer(typeof(String));
            if (String.IsNullOrEmpty(this.txtBox1.Text))
            {
                ser.Serialize(stream, test);
            }
            else
            {
                ser.Serialize(stream, this.txtBox1.Text);
            }
            
            stream.Flush();
            stream.Dispose();

            
        }
    }
}
