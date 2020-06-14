using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MarathonChinaApp.Pages.CompetitorPage
{
    /// <summary>
    /// Interaction logic for PageMyProfile.xaml
    /// </summary>
    public partial class PageMyProfile : Page
    {
        public PageMyProfile()
        {
            InitializeComponent();
            TBName.Text = AppData.AuthorizedUser.FirstName;
            TBGender.Text = AppData.AuthorizedUser.Gender.Name;
            TBDateOfBirth.Text = AppData.AuthorizedUser.DateOfBirth.ToString();
            TBNumber.Text = AppData.AuthorizedUser.IdNumber.ToString();
            TBProvince.Text = AppData.AuthorizedUser.City.Name + " (" + AppData.AuthorizedUser.City.ZipCode + ")";
            TBPhone.Text = AppData.AuthorizedUser.Phone;
            TBEmail.Text = AppData.AuthorizedUser.Email;
            if (AppData.AuthorizedUser.Photo != null)
            {
                ImAvatar.Source = (ImageSource)new ImageSourceConverter().ConvertFrom(AppData.AuthorizedUser.Photo);
            }
        }

        private void CBPassword_Click(object sender, RoutedEventArgs e)
        {
            if (CBPassword.IsChecked == true)
            {
                SPPassword.IsEnabled = true;
                SPSaveCancel.IsEnabled = true;
            }
            else
            {
                SPPassword.IsEnabled = false;
                SPSaveCancel.IsEnabled = false;
            }
        }

        private void BtnCancel_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new CompetitorPage.PageMenu());
        }

        private void CBPasShow_Checked(object sender, RoutedEventArgs e)
        {
         
        }

        private void BtnSave_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder error = new StringBuilder();
            if(PBPassword.Password != PBRePassword.Password)
            {
                error.AppendLine("Пароли не совпадают");
            }
            if(PBPassword.Password.Length <= 6 || PBPassword.Password.Length >= 16)
            {
                error.AppendLine("От 6 до 16 символов включительно");
            }
            bool hasDigits = false, hasUpper = false, hasLower = false, hasSpace = false; 
            foreach (var symb in PBPassword.Password)
            {
                if (char.IsDigit(symb))
                {
                    hasDigits = true;
                }
                if (char.IsUpper(symb))
                {
                    hasUpper = true;
                }
                if (char.IsLower(symb))
                {
                    hasLower = true;
                }
                if(symb.ToString() == " ")
                {
                    hasSpace = true;
                }
            }
            if (!hasDigits)
            {
                error.AppendLine("Минимум  1 цифра");
            }
            if (!hasUpper)
            {
                error.AppendLine("Минимум 1 прописная буква");
            }
            if (!hasLower)
            {
                error.AppendLine("Минимум одна строчная буква");
            }
            if (hasSpace)
            {
                error.AppendLine("Пароль не должен содержать пробелов");
            }
            if (error != null)
            {
                MessageBox.Show(error.ToString());
            }
            else
            {
                AppData.AuthorizedUser.Password = PBPassword.Password;
            }
        }
    }
}
