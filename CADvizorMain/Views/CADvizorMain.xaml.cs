using System.Windows;
using System.Windows.Input;

namespace CADvizorMain.Views
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class CADvizorMain : Window
    {
        public CADvizorMain()
        {
            InitializeComponent();
        }

        private void BtnLogin_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnRegister_Click(object sender, RoutedEventArgs e)
        {

        }

        private void MainWindow_OnMouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed) DragMove();
        }

        private void BtnMinimize_Click(object sender, RoutedEventArgs e)
        {
            //WindowState = WindowState.Minimized;
        }

        private void BtnClose_Click(object sender, RoutedEventArgs e)
        {
            //Application.Current.Shutdown();
        }

        private void TxtPass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                //아래 조건이 성립하려면 로그인하는 계정에 대해서 정합성 체크해줘야된다.


                //새로운 창 뛰움               

                //기존창 닫음
                //this.Close();
            }


        }


        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed) DragMove();
        }
    }
}
