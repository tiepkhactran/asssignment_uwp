using Baithi_DinhVanHoangAn_UWP.Entity;
using Baithi_DinhVanHoangAn_UWP.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Baithi_DinhVanHoangAn_UWP.Pages
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class ListNote : Page
    {
        static ObservableCollection<Note> ListAllNote;
        private NoteModel noteModel;
        static int Id;

        public ListNote()
        {
            this.InitializeComponent();
            this.noteModel = new NoteModel();
            this.Loaded += LoadNote;
        }

        private void LoadNote(object sender, RoutedEventArgs e)
        {
            var list = this.noteModel.Select();
            ListAllNote = new ObservableCollection<Note>(list);
            ListViewNote.ItemsSource = ListAllNote;
        }

        private void BtnEdit_Click(object sender, RoutedEventArgs e)
        {
            var note = new Note();
            note.Id = Id;
            note.Title = Title.Text;
            note.Content = Content.Text;
            this.noteModel.Update(note);
            this.Frame.Navigate(this.GetType());
        }

        private void BtnDelete_Click(object sender, RoutedEventArgs e)
        {
            this.noteModel.Delete(Id);
            this.Frame.Navigate(GetType());
        }

        private void BtnSubmit_Click(object sender, RoutedEventArgs e)
        {
            Note note = new Note()
            {
                Title = Title.Text,
                Content = Content.Text,
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now
            };
            noteModel.Insert(note);
            this.Frame.Navigate(this.GetType());
        }

        private void BtnOrCreate_Click(object sender, RoutedEventArgs e)
        {
            EnableButtonWhenClickOrCreate();

            Title.Text = "";
            Content.Text = "";
        }

        private void StackOfNote_DoubleTapped(object sender, DoubleTappedRoutedEventArgs e)
        {
            var id = (sender as StackPanel).Tag as int?;
            Id = (int)id;
            EnableButtonWhenTap();
            LoadItemNote(id);
        }

        private void BtnReset_Click(object sender, RoutedEventArgs e)
        {
            Title.Text = "";
            Content.Text = "";
        }

        #region method

        private void LoadItemNote(int? id)
        {
            var note = this.noteModel.SelectOneItem(id);
            Title.Text = note.Title;
            Content.Text = note.Content;
        }

        private void EnableButtonWhenTap()
        {
            btnSubmit.Visibility = Visibility.Collapsed;
            btnReset.Visibility = Visibility.Collapsed;
            btnEdit.Visibility = Visibility.Visible;
            btnDelete.Visibility = Visibility.Visible;
            btnOrCreate.Visibility = Visibility.Visible;
        }

        private void EnableButtonWhenClickOrCreate()
        {
            btnSubmit.Visibility = Visibility.Visible;
            btnReset.Visibility = Visibility.Visible;
            btnEdit.Visibility = Visibility.Collapsed;
            btnDelete.Visibility = Visibility.Collapsed;
            btnOrCreate.Visibility = Visibility.Collapsed;
        }

        #endregion
    }
}
