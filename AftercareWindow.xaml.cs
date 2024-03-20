using System;
using System.Threading.Tasks;
using System.Windows;
using MySql.Data.MySqlClient;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.IO;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
//using System.Windows.Controls;
using System.Threading;
using Org.BouncyCastle.Asn1.Crmf;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace AntivirusApp
{
    public partial class AftercareWindow : Window
    {
        public AftercareWindow()
        {
            InitializeComponent();
            caredFiles.Dispatcher.Invoke(() =>
            {
                caredFiles.Text = "삭제한 악성 파일 수: " + ResultWindow.maliciousFiles;
            });
        }

        private void GGoHomeButton_Click(object sender, RoutedEventArgs e)
        {
            // 홈으로 돌아가는 버튼 클릭 시 홈 창 열기
            MainWindow homeWindow = new MainWindow();
            homeWindow.Show();
            this.Close();
        }
    }
}
