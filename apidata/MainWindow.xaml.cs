using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Configuration;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Policy;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Markup.Localizer;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;
using WpfAnimatedGif;

namespace apidata
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    
    public partial class MainWindow : Window
    {
        static private int dia = 100000;
        public class cookie
        {
            public string Grade { get; set; }
            public string Name { get; set; }
            public double Persent { get; set; }

        }
        public MainWindow()
        {
            InitializeComponent();
            money.Text = dia.ToString("#,###");
            img.Source = new BitmapImage(new Uri("pack://application:,,,/쿠키/count.jpg"));
            
        }
        static private List<string> Commonlist = new List<string>();
        static private List<string> Rarelist = new List<string>();
        static private List<string> Epiclist = new List<string>();
        static private List<string> Super_Epiclist = new List<string>();
        static private List<string> Legendarylist = new List<string>();
        static private List<string> Ancientlist = new List<string>();
        private List<string> resultcook = new List<string>();
        private int[] arr = new int[10];
        private int[] arr2 = new int[10];
        private int dou = 0;
        private int count = 0;
        private int count2 = 0;
        private int dou7 = 0;

        static private void files()
        {
            DirectoryInfo directory = new DirectoryInfo(@"C:\Users\kids6\OneDrive\바탕 화면\쿠키2");
            FileInfo[] fileInfos = directory.GetFiles();

            foreach (FileInfo fileInfo in fileInfos)
            {
                string str1 = fileInfo.Name.Split('_')[0];
                string str2 = fileInfo.Name.Split('_')[1];
                switch (str1)
                {
                    case "COMMON":
                        Commonlist.Add(str2);
                        break;
                    case "RARE":
                        Rarelist.Add(str2);
                        break;
                    case "EPIC":
                        Epiclist.Add(str2);
                        break;
                    case "SUPER EPIC":
                        Super_Epiclist.Add(str2);
                        break;
                    case "LEGENDARY":
                        Legendarylist.Add(str2);
                        break;
                    case "ANCIENT":
                        Ancientlist.Add(str2);
                        break;
                }
            }
        }
        void timeDelay02(int tDelaySecond)
        {
            DateTime dtStart = DateTime.Now;
            TimeSpan firstTime = new TimeSpan(DateTime.Now.Ticks);


            while (firstTime.Ticks + (tDelaySecond * 10000000) >= DateTime.Now.Ticks)
            {
                TimeSpan elapsedSpan = new TimeSpan(DateTime.Now.Ticks - firstTime.Ticks);

                this.Dispatcher.Invoke((ThreadStart)(() => { }), DispatcherPriority.Input);
            }
        }
        private void Mpshow()
        {
            Uri uri = new Uri("C:/Users/kids6/OneDrive/바탕 화면/gif/epicshow1.mp4", UriKind.RelativeOrAbsolute);

            this.gif2.Source = uri;

            this.gif2.Play();
            timeDelay02(6);
            gif2.Visibility = Visibility.Hidden;
            cookieimg.Visibility = Visibility.Visible;
            cookiename.Visibility = Visibility.Visible;
        }
        private void Mpcommon()
        {
            Uri uri = new Uri("C:/Users/kids6/OneDrive/바탕 화면/gif/commonshow1.mp4", UriKind.RelativeOrAbsolute);

            this.gif2.Source = uri;

            this.gif2.Play();
            timeDelay02(3);
            gif2.Visibility = Visibility.Hidden;
            cookieimg.Visibility = Visibility.Visible;
            cookiename.Visibility = Visibility.Visible;
        }
        private void Mprare()
        {
            if (count2 == 0)
            {
                Uri uri = new Uri("C:/Users/kids6/OneDrive/바탕 화면/gif/rareshow1.mp4", UriKind.RelativeOrAbsolute);

                this.gif2.Source = uri;

                this.gif2.Play();
                timeDelay02(3);
                gif2.Visibility = Visibility.Hidden;
                cookieimg.Visibility = Visibility.Visible;
                cookiename.Visibility = Visibility.Visible;
            }
            else
            {
                Uri uri = new Uri("C:/Users/kids6/OneDrive/바탕 화면/gif/rareshow1.mp4", UriKind.RelativeOrAbsolute);

                this.gif2.Source = uri;

                this.gif2.Play();
                visi2();
                resultimg2();
            }
        }
        int numcount = 0;
        int max = 10;
        private void gachar()
        {
            Random r = new Random();
            for (int i = 0; i < 10; i++)
            {
                int rf = r.Next(0, max);
                if (dou <= 78184)
                {
                    while (true)
                    {
                        Random rna5 = new Random();
                        dou7 = rna5.Next(1, 78185);
                        if (dou7 <= 78184)
                        {
                            arr[i] = dou7;
                            break;
                        }
                    }
                }
                else
                {
                    if (numcount == 0)
                    {
                        if (rf == 0)
                        {
                            Random rna5 = new Random();
                            dou7 = rna5.Next(88184, 100001);
                            arr[i] = dou7;
                            numcount += 1;
                        }
                        else
                        {
                            max -= 1;
                            Random rna5 = new Random();
                            dou7 = rna5.Next(1, 100001);
                            arr[i] = dou7;
                        }
                    }
                    else
                    {
                        Random rna5 = new Random();
                        dou7 = rna5.Next(1, 100001);
                        arr[i] = dou7;
                    }
                }
                MessageBox.Show(rf.ToString());
                MessageBox.Show(max.ToString());
                if (arr[i] <= 41252)
                {
                    Random ran3 = new Random();
                    int num2 = ran3.Next(0, Commonlist.Count);
                    arr2[i] = num2;
                }
                else if (arr[i] <= 78184)
                {
                    Random ran3 = new Random();
                    int num2 = ran3.Next(0, Rarelist.Count);
                    arr2[i] = num2;
                }
                else if (arr[i] <= 88184)
                {
                    Random ran3 = new Random();
                    int num2 = ran3.Next(0, Epiclist.Count);
                    arr2[i] = num2;
                }
                else if (arr[i] <= 97464)
                {
                    Random ran3 = new Random();
                    int num2 = ran3.Next(0, Super_Epiclist.Count);
                    arr2[i] = num2;
                }
                else if (arr[i] <= 98732)
                {
                    Random ran3 = new Random();
                    int num2 = ran3.Next(0, Legendarylist.Count);
                    arr2[i] = num2;
                }
                else
                {
                    Random ran3 = new Random();
                    int num2 = ran3.Next(0, Ancientlist.Count);
                    arr2[i] = num2;
                }
                if (arr[i] <= 41252)
                {
                    Mpcommon();
                    cookiename.Text = Commonlist[arr2[i]];
                    resultcook.Add(Commonlist[arr2[i]]);
                    cookieimg.Source = new BitmapImage(new Uri("pack://application:,,,/쿠키/" + cookiename.Text + ".jpg"));
                    count += 1;
                    timeDelay02(2);
                    cookieimg.Visibility = Visibility.Hidden;
                    cookiename.Visibility = Visibility.Hidden;
                    gif2.Visibility = Visibility.Visible;
                }
                else if (arr[i] <= 78184)
                {
                    Mprare();
                    cookiename.Text = Rarelist[arr2[i]];
                    resultcook.Add(Rarelist[arr2[i]]);
                    cookieimg.Source = new BitmapImage(new Uri("pack://application:,,,/쿠키/" + cookiename.Text + ".jpg"));
                    count += 1;
                    timeDelay02(2);
                    cookieimg.Visibility = Visibility.Hidden;
                    cookiename.Visibility = Visibility.Hidden;
                    gif2.Visibility = Visibility.Visible;
                }
                else if (arr[i] <= 88184)
                {
                    Mpshow();
                    cookiename.Text = Epiclist[arr2[i]];
                    resultcook.Add(Epiclist[arr2[i]]);
                    cookieimg.Source = new BitmapImage(new Uri("pack://application:,,,/쿠키/" + cookiename.Text + ".jpg"));
                    count += 1;
                    timeDelay02(2);
                    cookieimg.Visibility = Visibility.Hidden;
                    cookiename.Visibility = Visibility.Hidden;
                    gif2.Visibility = Visibility.Visible;
                }
                else if (arr[i] <= 97464)
                {
                    Mpshow();
                    cookiename.Text = Super_Epiclist[arr2[i]];
                    resultcook.Add(Super_Epiclist[arr2[i]]);
                    cookieimg.Source = new BitmapImage(new Uri("pack://application:,,,/쿠키/" + cookiename.Text + ".jpg"));
                    count += 1;
                    timeDelay02(2);
                    cookieimg.Visibility = Visibility.Hidden;
                    cookiename.Visibility = Visibility.Hidden;
                    gif2.Visibility = Visibility.Visible;
                }
                else if (arr[i] <= 98732)
                {

                    Mpshow();
                    cookiename.Text = Legendarylist[arr2[i]];
                    resultcook.Add(Legendarylist[arr2[i]]);
                    cookieimg.Source = new BitmapImage(new Uri("pack://application:,,,/쿠키/" + cookiename.Text + ".jpg"));
                    count += 1;
                    timeDelay02(2);
                    cookieimg.Visibility = Visibility.Hidden;
                    cookiename.Visibility = Visibility.Hidden;
                    gif2.Visibility = Visibility.Visible;
                }
                else
                {
                    Mpshow();
                    cookiename.Text = Ancientlist[arr2[i]];
                    resultcook.Add(Ancientlist[arr2[i]]);
                    cookieimg.Source = new BitmapImage(new Uri("pack://application:,,,/쿠키/" + cookiename.Text + ".jpg"));
                    count += 1;
                    timeDelay02(2);
                    cookieimg.Visibility = Visibility.Hidden;
                    cookiename.Visibility = Visibility.Hidden;
                    gif2.Visibility = Visibility.Visible;
                }
            }
            gif2.Visibility = Visibility.Hidden;
            timeDelay02(1);
            visi();
            resultimg();
            
        }
        private void onegacha()
        {
            if (arr[0] <= 41252)
            {
                Mpcommon();
                cookiename.Text = Commonlist[arr2[0]];
                resultcook.Add(Commonlist[arr2[0]]);
                cookieimg.Source = new BitmapImage(new Uri("pack://application:,,,/쿠키/" + cookiename.Text + ".jpg"));
                count += 1;
                timeDelay02(2);
                cookieimg.Visibility = Visibility.Hidden;
                cookiename.Visibility = Visibility.Hidden;
            }
            else if (arr[0] <= 78184)
            {
                Mprare();
                cookiename.Text = Rarelist[arr2[0]];
                resultcook.Add(Rarelist[arr2[0]]);
                cookieimg.Source = new BitmapImage(new Uri("pack://application:,,,/쿠키/" + cookiename.Text + ".jpg"));
                count += 1;
                timeDelay02(2);
                cookieimg.Visibility = Visibility.Hidden;
                cookiename.Visibility = Visibility.Hidden;
            }
            else if (arr[0] <= 88184)
            {
                Mpshow();
                cookiename.Text = Epiclist[arr2[0]];
                resultcook.Add(Epiclist[arr2[0]]);
                cookieimg.Source = new BitmapImage(new Uri("pack://application:,,,/쿠키/" + cookiename.Text + ".jpg"));
                count += 1;
                timeDelay02(2);
                cookieimg.Visibility = Visibility.Hidden;
                cookiename.Visibility = Visibility.Hidden;
            }
            else if (arr[0] <= 97464)
            {
                Mpshow();
                cookiename.Text = Super_Epiclist[arr2[0]];
                resultcook.Add(Super_Epiclist[arr2[0]]);
                cookieimg.Source = new BitmapImage(new Uri("pack://application:,,,/쿠키/" + cookiename.Text + ".jpg"));
                count += 1;
                timeDelay02(2);
                cookieimg.Visibility = Visibility.Hidden;
                cookiename.Visibility = Visibility.Hidden;
            }
            else if (arr[0] <= 98732)
            {

                Mpshow();
                cookiename.Text = Legendarylist[arr2[0]];
                resultcook.Add(Legendarylist[arr2[0]]);
                cookieimg.Source = new BitmapImage(new Uri("pack://application:,,,/쿠키/" + cookiename.Text + ".jpg"));
                count += 1;
                timeDelay02(2);
                cookieimg.Visibility = Visibility.Hidden;
                cookiename.Visibility = Visibility.Hidden;
            }
            else
            {
                Mpshow();
                cookiename.Text = Ancientlist[arr2[0]];
                resultcook.Add(Ancientlist[arr2[0]]);
                cookieimg.Source = new BitmapImage(new Uri("pack://application:,,,/쿠키/" + cookiename.Text + ".jpg"));
                count += 1;
                timeDelay02(2);
                cookieimg.Visibility = Visibility.Hidden;
                cookiename.Visibility = Visibility.Hidden;
            }
        gif2.Visibility = Visibility.Hidden;
        timeDelay02(1);
        visi2();
        resultimg2();
        }
        private void resultimg()
        {
            img1.Source = new BitmapImage(new Uri("pack://application:,,,/쿠키/" + resultcook[0] + ".jpg"));
            img2.Source = new BitmapImage(new Uri("pack://application:,,,/쿠키/" + resultcook[1] + ".jpg"));
            img3.Source = new BitmapImage(new Uri("pack://application:,,,/쿠키/" + resultcook[2] + ".jpg"));
            img4.Source = new BitmapImage(new Uri("pack://application:,,,/쿠키/" + resultcook[3] + ".jpg"));
            img5.Source = new BitmapImage(new Uri("pack://application:,,,/쿠키/" + resultcook[4] + ".jpg"));
            img6.Source = new BitmapImage(new Uri("pack://application:,,,/쿠키/" + resultcook[5] + ".jpg"));
            img7.Source = new BitmapImage(new Uri("pack://application:,,,/쿠키/" + resultcook[6] + ".jpg"));
            img8.Source = new BitmapImage(new Uri("pack://application:,,,/쿠키/" + resultcook[7] + ".jpg"));
            img9.Source = new BitmapImage(new Uri("pack://application:,,,/쿠키/" + resultcook[8] + ".jpg"));
            img10.Source = new BitmapImage(new Uri("pack://application:,,,/쿠키/" + resultcook[9] + ".jpg"));
        }
        private void resultimg2()
        {
            resultone.Source = new BitmapImage(new Uri("pack://application:,,,/쿠키/" + resultcook[0] + ".jpg"));
        }
        private void visi2()
        {
            result.Visibility = Visibility.Visible;
            compe.Visibility = Visibility.Visible;
            resultone.Visibility = Visibility.Visible;
        }
        private void visi()
        {
            result.Visibility = Visibility.Visible;
            compelete.Visibility = Visibility.Visible;
            img1.Visibility = Visibility.Visible;
            img2.Visibility = Visibility.Visible;
            img3.Visibility = Visibility.Visible;
            img4.Visibility = Visibility.Visible;
            img5.Visibility = Visibility.Visible;
            img6.Visibility = Visibility.Visible;
            img7.Visibility = Visibility.Visible;
            img8.Visibility = Visibility.Visible;
            img9.Visibility = Visibility.Visible;
            img10.Visibility = Visibility.Visible;

        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            files();
            dia -= 3000;
            
            one.Visibility = Visibility.Hidden;
            ten.Visibility = Visibility.Hidden;
            img.Visibility = Visibility.Hidden;
            money.Visibility = Visibility.Hidden;
            gif.Visibility = Visibility.Visible;
            persent.Visibility = Visibility.Hidden;
            Random ran = new Random();
            dou = ran.Next(1, 100001);
            //int re = 0;
            //if (dou > 78184)
            //{
            //    for (int i = 0; i < 10; i++)
            //    {
            //        if (arr[i] >= 88184)
            //        {
            //            re += 1;
            //        }
            //    }
            //    if (re == 0)
            //    {
            //        Random rna5 = new Random();
            //        int dou18 = rna5.Next(0, 10);
            //        Random rna11 = new Random();
            //        int dou17 = rna11.Next(88184, 100001);
            //        arr[dou18] = dou17;
            //    }
            //}
            if (dou <= 78184)
            {

                Uri uri = new Uri("C:/Users/kids6/OneDrive/바탕 화면/gif/rare.mp4", UriKind.RelativeOrAbsolute);

                this.gif.Source = uri;
                this.gif.Play();
                timeDelay02(15);
                gif.Visibility = Visibility.Hidden;
                gif2.Visibility = Visibility.Visible;
                gachar();
            }
            else
            {
                Uri uri = new Uri("C:/Users/kids6/OneDrive/바탕 화면/gif/epic.mp4", UriKind.RelativeOrAbsolute);

                this.gif.Source = uri;

                this.gif.Play();
                timeDelay02(18);
                gif.Visibility = Visibility.Hidden;
                gif2.Visibility = Visibility.Visible;
                gachar();
            }

        }
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            files();
            dia -= 300;
            one.Visibility = Visibility.Hidden;
            ten.Visibility = Visibility.Hidden;
            img.Visibility = Visibility.Hidden;
            money.Visibility = Visibility.Hidden;
            gif.Visibility = Visibility.Visible;
            persent.Visibility = Visibility.Hidden;
            Random ran = new Random();
            dou = ran.Next(1, 100001);
            if (dou <= 78184)
            {
                while (true)
                {
                    Random rna5 = new Random();
                    dou7 = rna5.Next(1, 78185);
                    if (dou7 <= 78184)
                    {
                        arr[0] = dou7;
                        break;
                    }
                }
            }
            else
            {
                Random rna5 = new Random();
                dou7 = rna5.Next(88184, 100001);
                arr[0] = dou7;
            }
            if (arr[0] <= 41252)
            {
                Random ran3 = new Random();
                int num2 = ran3.Next(0, Commonlist.Count);
                arr2[0] = num2;
            }
            else if (arr[0] <= 78184)
            {
                Random ran3 = new Random();
                int num2 = ran3.Next(0, Rarelist.Count);
                arr2[0] = num2;
            }
            else if (arr[0] <= 88184)
            {
                Random ran3 = new Random();
                int num2 = ran3.Next(0, Epiclist.Count);
                arr2[0] = num2;
            }
            else if (arr[0] <= 97464)
            {
                Random ran3 = new Random();
                int num2 = ran3.Next(0, Super_Epiclist.Count);
                arr2[0] = num2;
            }
            else if (arr[0] <= 98732)
            {
                Random ran3 = new Random();
                int num2 = ran3.Next(0, Legendarylist.Count);
                arr2[0] = num2;
            }
            else
            {
                Random ran3 = new Random();
                int num2 = ran3.Next(0, Ancientlist.Count);
                arr2[0] = num2;
            }
            if (dou <= 78184)
            {

                Uri uri = new Uri("C:/Users/kids6/OneDrive/바탕 화면/gif/rare.mp4", UriKind.RelativeOrAbsolute);

                this.gif.Source = uri;
                this.gif.Play();
                timeDelay02(15);
                gif.Visibility = Visibility.Hidden;
                gif2.Visibility = Visibility.Visible;
                onegacha();
            }
            else
            {
                Uri uri = new Uri("C:/Users/kids6/OneDrive/바탕 화면/gif/epic.mp4", UriKind.RelativeOrAbsolute);

                this.gif.Source = uri;

                this.gif.Play();
                timeDelay02(18);
                gif.Visibility = Visibility.Hidden;
                gif2.Visibility = Visibility.Visible;
                onegacha();
            }
        }
        private void carnum()
        {
            //하위 디렉터리 조회
            DirectoryInfo directory = new DirectoryInfo(@"C:\Users\kids6\OneDrive\바탕 화면\쿠키2");
            //하위 파일 조회
            FileInfo[] fileInfos = directory.GetFiles();
            double dou = 0;
            foreach (FileInfo fileInfo in fileInfos)
            {
                string str1 = fileInfo.Name.Split('_')[0];
                string str2 = fileInfo.Name.Split('_')[1];
                string str3 = fileInfo.Name.Split('_')[2];
                // 파일 확장자명을 뺀 파일명
                string a = System.IO.Path.GetFileNameWithoutExtension(str3);
                dou = Double.Parse(a);

                
                    List<cookie> _list = new List<cookie>
                {
                new cookie { Grade = str1, Name = str2, Persent = dou}
                };
                    cookielist.Items.Add(_list);
                
            }
            //Collection줄, view.Sort 2줄은 persent, grade를 기준으로 오름차순을 함
            CollectionView view = (CollectionView)CollectionViewSource.GetDefaultView(cookielist.Items);
            if (view != null)
            {
                view.SortDescriptions.Add(new SortDescription("Persent", ListSortDirection.Ascending));
                view.SortDescriptions.Add(new SortDescription("Grade", ListSortDirection.Ascending));

            }
        }
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            cookielist.Visibility = Visibility.Visible;
            CANCEL.Visibility = Visibility.Visible;
            Random ran = new Random();
            cookielist.Items.Clear();

            carnum();

        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            cookielist.Visibility = Visibility.Hidden;
            CANCEL.Visibility = Visibility.Hidden;
        }
        private void avisi()
        {
            result.Visibility = Visibility.Hidden;
            compelete.Visibility = Visibility.Hidden;
            img1.Visibility = Visibility.Hidden;
            img2.Visibility = Visibility.Hidden;
            img3.Visibility = Visibility.Hidden;
            img4.Visibility = Visibility.Hidden;
            img5.Visibility = Visibility.Hidden;
            img6.Visibility = Visibility.Hidden;
            img7.Visibility = Visibility.Hidden;
            img8.Visibility = Visibility.Hidden;
            img9.Visibility = Visibility.Hidden;
            img10.Visibility = Visibility.Hidden;
            money.Visibility = Visibility.Visible;
            img.Visibility = Visibility.Visible;
        }
        private void avisi2()
        {
            result.Visibility = Visibility.Hidden;
            compelete.Visibility = Visibility.Hidden;
            resultone.Visibility = Visibility.Hidden;
            money.Visibility = Visibility.Visible;
            img.Visibility = Visibility.Visible;
        }
        private void compelete_Click(object sender, RoutedEventArgs e)
        {
            avisi();
            one.Visibility = Visibility.Visible;
            ten.Visibility = Visibility.Visible;
            persent.Visibility = Visibility.Visible;
            money.Text = dia.ToString();
        }
        private void compe_Click(object sender, RoutedEventArgs e)
        {
            avisi2();
            one.Visibility = Visibility.Visible;
            ten.Visibility = Visibility.Visible;
            persent.Visibility = Visibility.Visible;
            compe.Visibility = Visibility.Hidden;
            money.Text = dia.ToString();
            resultcook.Clear();
            Commonlist.Clear();
            Rarelist.Clear();
            Epiclist.Clear();
            Super_Epiclist.Clear();
            Legendarylist.Clear();
            max = 10;
            Ancientlist.Clear();
            count = 0;
            count2 = 0;
            numcount = 0;
        }
    }
}
