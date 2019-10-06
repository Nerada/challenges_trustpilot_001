﻿using Challenge1.Resources;
using System.Windows;

namespace Challenge1.Support.Dialogs
{
    /// <summary>
    /// Interaction logic for Dialog.xaml
    /// </summary>
    public partial class LanguageDialog : Window
    {
        public LanguageDialog()
        {
            InitializeComponent();
        }

        private void EnglishButton_Click(object sender, RoutedEventArgs e)
        {
            ResourceHandler.SetLanguage(ResourceHandler.Language.English);
            DialogResult = true;
            Close();
        }

        private void DutchButton_Click(object sender, RoutedEventArgs e)
        {
            ResourceHandler.SetLanguage(ResourceHandler.Language.Dutch);
            DialogResult = true;
            Close();
        }

        private void ChineseButton_Click(object sender, RoutedEventArgs e)
        {
            ResourceHandler.SetLanguage(ResourceHandler.Language.Chinese);
            DialogResult = true;
            Close();
        }
    }
}