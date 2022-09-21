﻿using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;

namespace Xtremly.Core
{
    public delegate void FileSelectionChanged(object sender, string[] fileNames);

    public class FileSelector : ContentControl
    {
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        private readonly System.Windows.Forms.OpenFileDialog openFileDialog = new();

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        private const FrameworkPropertyMetadataOptions defaultOptions = FrameworkPropertyMetadataOptions.BindsTwoWayByDefault | FrameworkPropertyMetadataOptions.Inherits;

        static FileSelector()
        {
            PropertyAssist.DefaultStyle<FileSelector>(DefaultStyleKeyProperty);
        }

        public FileSelector()
        {
            Content = nameof(FileSelector);
            bool canPopup = false;
            Cursor = System.Windows.Input.Cursors.Hand;
            MouseLeftButtonDown += (s, e) => canPopup = true;
            MouseLeave += (s, e) => canPopup = false;
            MouseLeftButtonUp += (s, e) =>
            {
                if (canPopup == false)
                {
                    return;
                }

                if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    string[] fileNames = null;

                    if (Multiselect)
                    {
                        FileNames = fileNames = openFileDialog.FileNames;
                    }
                    else
                    {
                        FileName = openFileDialog.FileName;
                        fileNames = new[] { openFileDialog.FileName };
                    }

                    FileSelectionChanged?.Invoke(this, fileNames);
                    FileSelectionChangedCommand?.Execute(fileNames);
                }
            };
        }


        public static readonly DependencyProperty FileSelectionChangedCommandProperty =
        PropertyAssist.PropertyRegister<FileSelector, ICommand<string[]>>(i => i.FileSelectionChangedCommand, null, FrameworkPropertyMetadataOptions.Inherits, (s, e) => { });

        [Bindable(true), Category("ICommand")]
        [Localizability(LocalizationCategory.None, Readability = Readability.Unreadable)]
        public ICommand<string[]> FileSelectionChangedCommand
        {
            get => (ICommand<string[]>)GetValue(FileSelectionChangedCommandProperty);
            set => SetValue(FileSelectionChangedCommandProperty, value);
        }


        public static readonly DependencyProperty MultiselectProperty = PropertyAssist.PropertyRegister<FileSelector, bool>(i => i.Multiselect, false, defaultOptions, (s, e) =>
        {
            s.openFileDialog.Multiselect = e.NewValue;
            if (e.NewValue)
            {
                s.FileName = null;
                return;
            }
            s.FileNames = null;
        });

        [Bindable(true), Category("Multiselect")]
        [Localizability(LocalizationCategory.None, Readability = Readability.Unreadable)]
        public bool Multiselect
        {
            get => (bool)GetValue(MultiselectProperty);
            set => SetValue(MultiselectProperty, value);
        }


        public static readonly DependencyProperty TitleProperty =
            PropertyAssist.PropertyRegister<FileSelector, string>(i => i.Title, "", defaultOptions, (s, e) =>
        {
            s.openFileDialog.Title = e.NewValue;
        });

        [Bindable(true), Category("Title")]
        [Localizability(LocalizationCategory.None, Readability = Readability.Unreadable)]
        public string Title
        {
            get => (string)GetValue(TitleProperty);
            set => SetValue(TitleProperty, value);
        }


        public static readonly DependencyProperty FileNameProperty =
          PropertyAssist.PropertyRegister<FileSelector, string>(i => i.FileName, "", defaultOptions, (s, e) =>
          {
              s.openFileDialog.FileName = e.NewValue;
          });

        [Bindable(true), Category("FileName")]
        [Localizability(LocalizationCategory.None, Readability = Readability.Unreadable)]
        public string FileName
        {
            get => (string)GetValue(FileNameProperty);
            set => SetValue(FileNameProperty, value);
        }



        public static readonly DependencyProperty FileNamesProperty =
        PropertyAssist.PropertyRegister<FileSelector, string[]>(i => i.FileNames, null, defaultOptions, (s, e) => { });

        [Bindable(true), Category("FileNames")]
        [Localizability(LocalizationCategory.None, Readability = Readability.Unreadable)]
        public string[] FileNames
        {
            get => (string[])GetValue(FileNamesProperty);
            set => SetValue(FileNamesProperty, value);
        }



        public static readonly DependencyProperty DefaultExtProperty =
          PropertyAssist.PropertyRegister<FileSelector, string>(i => i.DefaultExt, "", defaultOptions, (s, e) =>
          {
              s.openFileDialog.DefaultExt = e.NewValue;
          });


        [Bindable(true), Category("DefaultExt")]
        [Localizability(LocalizationCategory.None, Readability = Readability.Unreadable)]
        public string DefaultExt
        {
            get => (string)GetValue(DefaultExtProperty);
            set => SetValue(DefaultExtProperty, value);
        }

        public static readonly DependencyProperty FilterProperty =
          PropertyAssist.PropertyRegister<FileSelector, string>(i => i.Filter, "", defaultOptions, (s, e) =>
          {
              s.openFileDialog.Filter = e.NewValue;
          });

        [Bindable(true), Category("Filter")]
        [Localizability(LocalizationCategory.None, Readability = Readability.Unreadable)]
        public string Filter
        {
            get => (string)GetValue(FilterProperty);
            set => SetValue(FilterProperty, value);
        }


        public static readonly DependencyProperty InitialDirectoryProperty =
          PropertyAssist.PropertyRegister<FileSelector, string>(i => i.InitialDirectory, null, defaultOptions, (s, e) =>
          {
              s.openFileDialog.InitialDirectory = e.NewValue;
          });

        [Bindable(true), Category("InitialDirectory")]
        [Localizability(LocalizationCategory.None, Readability = Readability.Unreadable)]
        public string InitialDirectory
        {
            get => (string)GetValue(InitialDirectoryProperty);
            set => SetValue(InitialDirectoryProperty, value);
        }


        public static readonly DependencyProperty FilterIndexProperty =
          PropertyAssist.PropertyRegister<FileSelector, int>(i => i.FilterIndex, default, defaultOptions, (s, e) =>
          {
              s.openFileDialog.FilterIndex = e.NewValue;
          });

        [Bindable(true), Category("FilterIndex")]
        [Localizability(LocalizationCategory.None, Readability = Readability.Unreadable)]
        public int FilterIndex
        {
            get => (int)GetValue(FilterIndexProperty);
            set => SetValue(FilterIndexProperty, value);
        }

        public event FileSelectionChanged FileSelectionChanged;


        public static readonly DependencyProperty CornerRadiusProperty =
            PropertyAssist.PropertyRegister<FileSelector, CornerRadius>(i => i.CornerRadius, new CornerRadius(0));

        [Bindable(true), Category("CornerRadius")]
        [Localizability(LocalizationCategory.None, Readability = Readability.Unreadable)]
        public CornerRadius CornerRadius
        {
            get => (CornerRadius)GetValue(CornerRadiusProperty);
            set => SetValue(CornerRadiusProperty, value);
        }
    }
}
