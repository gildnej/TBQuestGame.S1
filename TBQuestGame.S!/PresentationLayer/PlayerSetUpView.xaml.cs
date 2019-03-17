using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using TBQuestGame.S_.Models;
namespace TBQuestGame.PresentationLayer
{
    /// <summary>
    /// Interaction logic for PlayerSetUpView.xaml
    /// </summary>
    public partial class PlayerSetUpView : Window
    {
        private Player _player;

        public PlayerSetUpView(Player player)
        {
            _player = player;

            InitializeComponent();

            SetupWindow();
        }

        private void SetupWindow()
        {
            List<string> races = Enum.GetNames(typeof(Player.RaceType)).ToList();
            List<string> JobTitles = Enum.GetNames(typeof(Player.Professtion)).ToList();
            JobTitleComboBox.ItemsSource = JobTitles;
            RaceComboBox.ItemsSource = races;

            ErrorMessageTextBlock.Visibility = Visibility.Hidden;
        }

        private bool IsValidInput(out string errorMessage)
        {
            errorMessage = "";

            if (NameTextBox.Text == "")
            {
                errorMessage += "Player Name is required.\n";
                errorMessage += "Name can not contain special characters";
            }
            else
            {
                _player.Name = NameTextBox.Text;
            }
            if (!int.TryParse(AgeTextBox.Text, out int age))
            {
                errorMessage += "player age is required and must be an integer.\n";
            }
            else
            {
                _player.Age = age;
            }

            return errorMessage == "" ? true : false;
        }

        private void OkButton_Click(object sender, RoutedEventArgs e)
        {
            string errorMessage;

            if (IsValidInput(out errorMessage))
            {
                Enum.TryParse(JobTitleComboBox.SelectionBoxItem.ToString(), out Player.Professtion professtion);
                Enum.TryParse(RaceComboBox.SelectionBoxItem.ToString(), out Player.RaceType race);

                _player.JobTitle = professtion;
                _player.Race = race;

                Visibility = Visibility.Hidden;
            }
            else
            {
                ErrorMessageTextBlock.Visibility = Visibility.Visible;
                ErrorMessageTextBlock.Text = errorMessage;
            }
        }
    }
}
