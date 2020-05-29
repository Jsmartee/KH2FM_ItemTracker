using System;
using System.Collections.Generic;
using System.Diagnostics;
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

namespace tracker
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void MenuReset_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start(Application.ResourceAssembly.Location);
            Application.Current.Shutdown();

        }

        private void MenuExit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void MenuAbout_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Author: Jsmartee" + "\n" + "Images from khwiki.com and khinsider.com", "KH2FM Item Tracker v1.0");
        }

        //Highlight item when left click
        private void CheckItem(object sender, MouseButtonEventArgs e)
        {
            Image pic = (Image)sender;
            String[] reference = pic.Source.ToString().Split('_');
            BitmapImage image = new BitmapImage(new Uri(reference[0] + "_1.png", UriKind.Absolute));
            pic.Source = image;



        }

        //Unhighlight item when right click
        private void UncheckItem(object sender, MouseButtonEventArgs e)
        {
            Image pic = (Image)sender;
            String[] reference = pic.Source.ToString().Split('_');
            BitmapImage image = new BitmapImage(new Uri(reference[0] + "_0.png", UriKind.Absolute));
            pic.Source = image;
        }

        int crown = 0;
        //Cycle through progressive crowns on left click
        private void CrownLeftClick(object sender, MouseButtonEventArgs e)
        {
            Image pic = (Image)sender;
            int index = crown;

            if(index == 3)
            {
                return;
            }

            index++;
            String[] reference = pic.Source.ToString().Split('_');
            BitmapImage image = new BitmapImage(new Uri(reference[0] + "_" + index + ".png", UriKind.Absolute));
            pic.Source = image;
            crown++;

        }

        //Cycle backwards through progressive crowns on right click
        private void CrownRightClick(object sender, MouseButtonEventArgs e)
        {
            Image pic = (Image)sender;
            int index = crown;

            if (index == 0)
            {
                return;
            }

            index--;
            String[] reference = pic.Source.ToString().Split('_');
            BitmapImage image = new BitmapImage(new Uri(reference[0] + "_" + index + ".png", UriKind.Absolute));
            pic.Source = image;
            crown--;
        }

        int fireIndex = 0;
        int blizzardIndex = 0;
        int thunderIndex = 0;
        int cureIndex = 0;
        int reflectIndex = 0;
        int magnetIndex = 0;
        //Cycle through magic upgrades on left click
        private void CycleMagicLeftClick(object sender, MouseButtonEventArgs e)
        {
            Image pic = (Image)sender;
            int index = 0;

            switch(pic.Tag.ToString())
            {
                case "Fire":
                    index = fireIndex;
                    switch(index)
                    {
                        case 0:
                            CheckItem(pic, e);
                            fireIndex++;
                            break;

                        case 1:
                            Fire.Text = "Fira";
                            fireIndex++;
                            break;

                        case 2:
                            Fire.Text = "Firaga";
                            fireIndex++;
                            Fire.Foreground = new SolidColorBrush(Color.FromRgb(0, 204, 0));
                            break;
                    }

                    break;

                case "Blizzard":
                    index = blizzardIndex;
                    switch (index)
                    {
                        case 0:
                            CheckItem(pic, e);
                            blizzardIndex++;
                            break;

                        case 1:
                            Blizzard.Text = "Blizzara";
                            blizzardIndex++;
                            break;

                        case 2:
                            Blizzard.Text = "Blizzaga";
                            blizzardIndex++;
                            Blizzard.Foreground = new SolidColorBrush(Color.FromRgb(0, 204, 0));
                            break;
                    }
                    break;

                case "Thunder":
                    index = thunderIndex;
                    switch (index)
                    {
                        case 0:
                            CheckItem(pic, e);
                            thunderIndex++;
                            break;

                        case 1:
                            Thunder.Text = "Thundara";
                            thunderIndex++;
                            break;

                        case 2:
                            Thunder.Text = "Thundaga";
                            thunderIndex++;
                            Thunder.Foreground = new SolidColorBrush(Color.FromRgb(0, 204, 0));
                            break;
                    }
                    break;

                case "Cure":
                    index = cureIndex;
                    switch (index)
                    {
                        case 0:
                            CheckItem(pic, e);
                            cureIndex++;
                            break;

                        case 1:
                            Cure.Text = "Cura";
                            cureIndex++;
                            break;

                        case 2:
                            Cure.Text = "Curaga";
                            cureIndex++;
                            Cure.Foreground = new SolidColorBrush(Color.FromRgb(0, 204, 0));
                            break;
                    }
                    break;

                case "Reflect":
                    index = reflectIndex;
                    switch (index)
                    {
                        case 0:
                            CheckItem(pic, e);
                            reflectIndex++;
                            break;

                        case 1:
                            Reflect.Text = "Reflera";
                            reflectIndex++;
                            break;

                        case 2:
                            Reflect.Text = "Reflega";
                            reflectIndex++;
                            Reflect.Foreground = new SolidColorBrush(Color.FromRgb(0, 204, 0));
                            break;
                    }
                    break;

                case "Magnet":
                    index = magnetIndex;
                    switch (index)
                    {
                        case 0:
                            CheckItem(pic, e);
                            magnetIndex++;
                            break;

                        case 1:
                            Magnet.Text = "Magnera";
                            magnetIndex++;
                            break;

                        case 2:
                            Magnet.Text = "Magnega";
                            magnetIndex++;
                            Magnet.Foreground = new SolidColorBrush(Color.FromRgb(0, 204, 0));
                            break;
                    }
                    break;
            }



        }

        //Cycle backwards through magic upgrades on right click
        private void CycleMagicRightClick(object sender, MouseButtonEventArgs e)
        {
            Image pic = (Image)sender;
            int index = 0;

            switch (pic.Tag.ToString())
            {
                case "Fire":
                    index = fireIndex;
                    switch (index)
                    {
                        case 1:
                            UncheckItem(pic, e);
                            fireIndex--;
                            break;

                        case 2:
                            Fire.Text = "Fire";
                            fireIndex--;
                            break;

                        case 3:
                            Fire.Text = "Fira";
                            fireIndex--;
                            Fire.Foreground = new SolidColorBrush(Colors.White);
                            break;
                    }

                    break;

                case "Blizzard":
                    index = blizzardIndex;
                    switch (index)
                    {
                        case 1:
                            UncheckItem(pic, e);
                            blizzardIndex--;
                            break;

                        case 2:
                            Blizzard.Text = "Blizzard";
                            blizzardIndex--;
                            break;

                        case 3:
                            Blizzard.Text = "Blizzara";
                            blizzardIndex--;
                            Blizzard.Foreground = new SolidColorBrush(Colors.White);
                            break;
                    }
                    break;

                case "Thunder":
                    index = thunderIndex;
                    switch (index)
                    {
                        case 1:
                            UncheckItem(pic, e);
                            thunderIndex--;
                            break;

                        case 2:
                            Thunder.Text = "Thunder";
                            thunderIndex--;
                            break;

                        case 3:
                            Thunder.Text = "Thundara";
                            thunderIndex--;
                            Thunder.Foreground = new SolidColorBrush(Colors.White);
                            break;
                    }
                    break;

                case "Cure":
                    index = cureIndex;
                    switch (index)
                    {
                        case 1:
                            UncheckItem(pic, e);
                            cureIndex--;
                            break;

                        case 2:
                            Cure.Text = "Cure";
                            cureIndex--;
                            break;

                        case 3:
                            Cure.Text = "Cura";
                            cureIndex--;
                            Cure.Foreground = new SolidColorBrush(Colors.White);
                            break;
                    }
                    break;

                case "Reflect":
                    index = reflectIndex;
                    switch (index)
                    {
                        case 1:
                            UncheckItem(pic, e);
                            reflectIndex--;
                            break;

                        case 2:
                            Reflect.Text = "Reflect";
                            reflectIndex--;
                            break;

                        case 3:
                            Reflect.Text = "Reflera";
                            reflectIndex--;
                            Reflect.Foreground = new SolidColorBrush(Colors.White);
                            break;
                    }
                    break;

                case "Magnet":
                    index = magnetIndex;
                    switch (index)
                    {
                        case 1:
                            UncheckItem(pic, e);
                            magnetIndex--;
                            break;

                        case 2:
                            Magnet.Text = "Magnet";
                            magnetIndex--;
                            break;

                        case 3:
                            Magnet.Text = "Magnera";
                            magnetIndex--;
                            Magnet.Foreground = new SolidColorBrush(Colors.White);
                            break;
                    }
                    break;
            }
        }

        int pages = 0;
        int atlantica = 0;
        int wood = 0;
        int twilight = 0;
        int garden = 0;
        //Method to add to counters
        private void CountUp(object sender, MouseButtonEventArgs e)
        {
            Image pic = (Image)sender;
            TextBlock text = new TextBlock();
            int index = 0;
            int max = 0;

            switch (pic.Tag.ToString())
            {
                case "TornPages":
                    index = pages;
                    text = tornpages;
                    max = 5;
                    break;

                case "Atlantica":
                    index = atlantica;
                    text = AT;
                    max = 5;
                    break;

                case "100AcreWood":
                    index = wood;
                    text = AcreWood;
                    max = 5;
                    break;

                case "TwilightTown":
                    index = twilight;
                    text = TT;
                    max = 3;
                    break;

                case "HollowBastion":
                    index = garden;
                    text = HB;
                    max = 3;
                    break;

            }

            if (index == 0 && pic.Tag.ToString().Contains("TornPages"))
            {
                CheckItem(pic, e);
            }

            if(index == max)
            {
                return;
            }

            switch(max)
            {
                case 5:
                    if(index == 4)
                    {
                        index++;
                        text.Text = index.ToString();
                        text.Foreground = new SolidColorBrush(Color.FromRgb(0, 204, 0));
                    }
                    else
                    {
                        index++;
                        text.Text = index.ToString();
                    }
                    break;

                case 3:
                    if (index == 2)
                    {
                        index++;
                        text.Text = index.ToString();
                        text.Foreground = new SolidColorBrush(Color.FromRgb(0, 204, 0));
                    }
                    else
                    {
                        index++;
                        text.Text = index.ToString();
                    }
                    break;
            }

            switch(pic.Tag.ToString())
            {
                case "TornPages":
                    pages++;
                    break;

                case "Atlantica":
                    atlantica++;
                    break;

                case "100AcreWood":
                    wood++;
                    break;

                case "TwilightTown":
                    twilight++;
                    break;

                case "HollowBastion":
                    garden++;
                    break;
            }





        }

        //Method to subtract from counters
        private void CountDown(object sender, MouseButtonEventArgs e)
        {
            Image pic = (Image)sender;
            TextBlock text = new TextBlock();
            int index = 0;
            int max = 0;

            switch (pic.Tag.ToString())
            {
                case "TornPages":
                    index = pages;
                    text = tornpages;
                    max = 5;
                    break;

                case "Atlantica":
                    index = atlantica;
                    text = AT;
                    max = 5;
                    break;

                case "100AcreWood":
                    index = wood;
                    text = AcreWood;
                    max = 5;
                    break;

                case "TwilightTown":
                    index = twilight;
                    text = TT;
                    max = 3;
                    break;

                case "HollowBastion":
                    index = garden;
                    text = HB;
                    max = 3;
                    break;

            }

            if (index == 1 && pic.Tag.ToString().Contains("TornPages"))
            {
                UncheckItem(pic, e);
            }

            if (index == 0)
            {
                return;
            }

            if(index == max)
            {
                text.Foreground = new SolidColorBrush(Colors.White);
            }

            index--;
            text.Text = index.ToString();

            switch (pic.Tag.ToString())
            {
                case "TornPages":
                    pages--;
                    break;

                case "Atlantica":
                    atlantica--;
                    break;

                case "100AcreWood":
                    wood--;
                    break;

                case "TwilightTown":
                    twilight--;
                    break;

                case "HollowBastion":
                    garden--;
                    break;
            }

        }


        int valor = 0;
        int wisdom = 0;
        int limit = 0;
        int master = 0;
        int final = 0;
        //Level up drive forms on left click
        private void DriveLevelUp(object sender, MouseButtonEventArgs e)
        {
            Image pic = (Image)sender;
            TextBlock text = new TextBlock();
            int index = 0;

            switch(pic.Tag.ToString())
            {
                case "formValor":
                    text = LevelValor;
                    index = valor;
                    break;

                case "formWisdom":
                    text = LevelWisdom;
                    index = wisdom;
                    break;

                case "formLimit":
                    text = LevelLimit;
                    index = limit;
                    break;

                case "formMaster":
                    text = LevelMaster;
                    index = master;
                    break;

                case "formFinal":
                    text = LevelFinal;
                    index = final;
                    break;
            }

            switch(index)
            {
                case 6:
                    return;

                case 5:
                    index++;
                    text.Text = "Level " + index.ToString();
                    text.Foreground = new SolidColorBrush(Color.FromRgb(0, 204, 0));
                    break;

                case 0:
                    index++;
                    text.Text = "Level " + index.ToString();
                    CheckItem(pic, e);
                    break;

                default:
                    index++;
                    text.Text = "Level " + index.ToString();
                    break;
            }

            switch (pic.Tag.ToString())
            {
                case "formValor":
                    valor++;
                    break;

                case "formWisdom":
                    wisdom++;
                    break;

                case "formLimit":
                    limit++;
                    break;

                case "formMaster":
                    master++;
                    break;

                case "formFinal":
                    final++;
                    break;
            }


        }

        //De-level drive froms with right click
        private void DriveLevelDown(object sender, MouseButtonEventArgs e)
        {
            Image pic = (Image)sender;
            TextBlock text = new TextBlock();
            int index = 0;

            switch (pic.Tag.ToString())
            {
                case "formValor":
                    text = LevelValor;
                    index = valor;
                    break;

                case "formWisdom":
                    text = LevelWisdom;
                    index = wisdom;
                    break;

                case "formLimit":
                    text = LevelLimit;
                    index = limit;
                    break;

                case "formMaster":
                    text = LevelMaster;
                    index = master;
                    break;

                case "formFinal":
                    text = LevelFinal;
                    index = final;
                    break;
            }

            switch (index)
            {
                case 0:
                    return;

                case 6:
                    index--;
                    text.Text = "Level " + index.ToString();
                    text.Foreground = new SolidColorBrush(Colors.White);
                    break;

                case 1:
                    index--;
                    text.Text = "";
                    UncheckItem(pic, e);
                    break;

                default:
                    index--;
                    text.Text = "Level " + index.ToString();
                    break;
            }

            switch (pic.Tag.ToString())
            {
                case "formValor":
                    valor--;
                    break;

                case "formWisdom":
                    wisdom--;
                    break;

                case "formLimit":
                    limit--;
                    break;

                case "formMaster":
                    master--;
                    break;

                case "formFinal":
                    final--;
                    break;
            }


        }

        
    }
}
