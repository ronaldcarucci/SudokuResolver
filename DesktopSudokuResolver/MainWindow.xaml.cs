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
using LibrarySudokuResolver;

namespace DesktopSudokuResolver
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public int[,] GridValues { get; set; }
        public LibrarySudokuResolver.Grid mygrid { get; set; }

        public MainWindow()
        {
            InitializeComponent();
            resetValues();
            GridValues = getValuesInGrid();
            mygrid = new LibrarySudokuResolver.Grid(GridValues);
        }

        private void btnSolve_Click(object sender, RoutedEventArgs e)
        {
            GridValues = getValuesInGrid();
            mygrid = new LibrarySudokuResolver.Grid(GridValues);
            mygrid.AutoSolve();
            setNewValues();
        }

        private void resetValues()
        {
            //txtCase00.Text = "0";
            //txtCase01.Text = "0";
            //txtCase02.Text = "0";
            //txtCase03.Text = "0";
            //txtCase04.Text = "0";
            //txtCase05.Text = "0";
            //txtCase06.Text = "0";
            //txtCase07.Text = "0";
            //txtCase08.Text = "0";
            //txtCase10.Text = "0";
            //txtCase11.Text = "0";
            //txtCase12.Text = "0";
            //txtCase13.Text = "0";
            //txtCase14.Text = "0";
            //txtCase15.Text = "0";
            //txtCase16.Text = "0";
            //txtCase17.Text = "0";
            //txtCase18.Text = "0";
            //txtCase20.Text = "0";
            //txtCase21.Text = "0";
            //txtCase22.Text = "0";
            //txtCase23.Text = "0";
            //txtCase24.Text = "0";
            //txtCase25.Text = "0";
            //txtCase26.Text = "0";
            //txtCase27.Text = "0";
            //txtCase28.Text = "0";
            //txtCase30.Text = "0";
            //txtCase31.Text = "0";
            //txtCase32.Text = "0";
            //txtCase33.Text = "0";
            //txtCase34.Text = "0";
            //txtCase35.Text = "0";
            //txtCase36.Text = "0";
            //txtCase37.Text = "0";
            //txtCase38.Text = "0";
            //txtCase40.Text = "0";
            //txtCase41.Text = "0";
            //txtCase42.Text = "0";
            //txtCase43.Text = "0";
            //txtCase44.Text = "0";
            //txtCase45.Text = "0";
            //txtCase46.Text = "0";
            //txtCase47.Text = "0";
            //txtCase48.Text = "0";
            //txtCase50.Text = "0";
            //txtCase51.Text = "0";
            //txtCase52.Text = "0";
            //txtCase53.Text = "0";
            //txtCase54.Text = "0";
            //txtCase55.Text = "0";
            //txtCase56.Text = "0";
            //txtCase57.Text = "0";
            //txtCase58.Text = "0";
            //txtCase60.Text = "0";
            //txtCase61.Text = "0";
            //txtCase62.Text = "0";
            //txtCase63.Text = "0";
            //txtCase64.Text = "0";
            //txtCase65.Text = "0";
            //txtCase66.Text = "0";
            //txtCase67.Text = "0";
            //txtCase68.Text = "0";
            //txtCase70.Text = "0";
            //txtCase71.Text = "0";
            //txtCase72.Text = "0";
            //txtCase73.Text = "0";
            //txtCase74.Text = "0";
            //txtCase75.Text = "0";
            //txtCase76.Text = "0";
            //txtCase77.Text = "0";
            //txtCase78.Text = "0";
            //txtCase80.Text = "0";
            //txtCase81.Text = "0";
            //txtCase82.Text = "0";
            //txtCase83.Text = "0";
            //txtCase84.Text = "0";
            //txtCase85.Text = "0";
            //txtCase86.Text = "0";
            //txtCase87.Text = "0";
            //txtCase88.Text = "0";

            txtCase00.Text = "8";
            txtCase01.Text = "0";
            txtCase02.Text = "4";
            txtCase03.Text = "9";
            txtCase04.Text = "0";
            txtCase05.Text = "3";
            txtCase06.Text = "0";
            txtCase07.Text = "7";
            txtCase08.Text = "1";
            txtCase10.Text = "6";
            txtCase11.Text = "3";
            txtCase12.Text = "5";
            txtCase13.Text = "8";
            txtCase14.Text = "0";
            txtCase15.Text = "7";
            txtCase16.Text = "0";
            txtCase17.Text = "2";
            txtCase18.Text = "4";
            txtCase20.Text = "7";
            txtCase21.Text = "1";
            txtCase22.Text = "9";
            txtCase23.Text = "0";
            txtCase24.Text = "2";
            txtCase25.Text = "4";
            txtCase26.Text = "0";
            txtCase27.Text = "5";
            txtCase28.Text = "0";
            txtCase30.Text = "0";
            txtCase31.Text = "8";
            txtCase32.Text = "7";
            txtCase33.Text = "0";
            txtCase34.Text = "9";
            txtCase35.Text = "1";
            txtCase36.Text = "3";
            txtCase37.Text = "0";
            txtCase38.Text = "6";
            txtCase40.Text = "1";
            txtCase41.Text = "0";
            txtCase42.Text = "0";
            txtCase43.Text = "7";
            txtCase44.Text = "3";
            txtCase45.Text = "6";
            txtCase46.Text = "0";
            txtCase47.Text = "0";
            txtCase48.Text = "9";
            txtCase50.Text = "3";
            txtCase51.Text = "0";
            txtCase52.Text = "6";
            txtCase53.Text = "4";
            txtCase54.Text = "8";
            txtCase55.Text = "0";
            txtCase56.Text = "2";
            txtCase57.Text = "1";
            txtCase58.Text = "0";
            txtCase60.Text = "0";
            txtCase61.Text = "6";
            txtCase62.Text = "1";
            txtCase63.Text = "5";
            txtCase64.Text = "4";
            txtCase65.Text = "0";
            txtCase66.Text = "7";
            txtCase67.Text = "3";
            txtCase68.Text = "8";
            txtCase70.Text = "4";
            txtCase71.Text = "7";
            txtCase72.Text = "0";
            txtCase73.Text = "3";
            txtCase74.Text = "0";
            txtCase75.Text = "2";
            txtCase76.Text = "1";
            txtCase77.Text = "9";
            txtCase78.Text = "5";
            txtCase80.Text = "9";
            txtCase81.Text = "5";
            txtCase82.Text = "0";
            txtCase83.Text = "1";
            txtCase84.Text = "0";
            txtCase85.Text = "8";
            txtCase86.Text = "4";
            txtCase87.Text = "0";
            txtCase88.Text = "2";
        }

        private int[,] getValuesInGrid()
        {
            int[,] values = {
                                {
                                    int.Parse(txtCase00.Text),
                                    int.Parse(txtCase01.Text),
                                    int.Parse(txtCase02.Text),
                                    int.Parse(txtCase03.Text),
                                    int.Parse(txtCase04.Text),
                                    int.Parse(txtCase05.Text),
                                    int.Parse(txtCase06.Text),
                                    int.Parse(txtCase07.Text),
                                    int.Parse(txtCase08.Text)
                                },
                                {
                                    int.Parse(txtCase10.Text),
                                    int.Parse(txtCase11.Text),
                                    int.Parse(txtCase12.Text),
                                    int.Parse(txtCase13.Text),
                                    int.Parse(txtCase14.Text),
                                    int.Parse(txtCase15.Text),
                                    int.Parse(txtCase16.Text),
                                    int.Parse(txtCase17.Text),
                                    int.Parse(txtCase18.Text)
                                },
                                {
                                    int.Parse(txtCase20.Text),
                                    int.Parse(txtCase21.Text),
                                    int.Parse(txtCase22.Text),
                                    int.Parse(txtCase23.Text),
                                    int.Parse(txtCase24.Text),
                                    int.Parse(txtCase25.Text),
                                    int.Parse(txtCase26.Text),
                                    int.Parse(txtCase27.Text),
                                    int.Parse(txtCase28.Text)
                                },
                                {
                                    int.Parse(txtCase30.Text),
                                    int.Parse(txtCase31.Text),
                                    int.Parse(txtCase32.Text),
                                    int.Parse(txtCase33.Text),
                                    int.Parse(txtCase34.Text),
                                    int.Parse(txtCase35.Text),
                                    int.Parse(txtCase36.Text),
                                    int.Parse(txtCase37.Text),
                                    int.Parse(txtCase38.Text)
                                },
                                {
                                    int.Parse(txtCase40.Text),
                                    int.Parse(txtCase41.Text),
                                    int.Parse(txtCase42.Text),
                                    int.Parse(txtCase43.Text),
                                    int.Parse(txtCase44.Text),
                                    int.Parse(txtCase45.Text),
                                    int.Parse(txtCase46.Text),
                                    int.Parse(txtCase47.Text),
                                    int.Parse(txtCase48.Text)
                                },
                                {
                                    int.Parse(txtCase50.Text),
                                    int.Parse(txtCase51.Text),
                                    int.Parse(txtCase52.Text),
                                    int.Parse(txtCase53.Text),
                                    int.Parse(txtCase54.Text),
                                    int.Parse(txtCase55.Text),
                                    int.Parse(txtCase56.Text),
                                    int.Parse(txtCase57.Text),
                                    int.Parse(txtCase58.Text)
                                },
                                {
                                    int.Parse(txtCase60.Text),
                                    int.Parse(txtCase61.Text),
                                    int.Parse(txtCase62.Text),
                                    int.Parse(txtCase63.Text),
                                    int.Parse(txtCase64.Text),
                                    int.Parse(txtCase65.Text),
                                    int.Parse(txtCase66.Text),
                                    int.Parse(txtCase67.Text),
                                    int.Parse(txtCase68.Text)
                                },
                                {
                                    int.Parse(txtCase70.Text),
                                    int.Parse(txtCase71.Text),
                                    int.Parse(txtCase72.Text),
                                    int.Parse(txtCase73.Text),
                                    int.Parse(txtCase74.Text),
                                    int.Parse(txtCase75.Text),
                                    int.Parse(txtCase76.Text),
                                    int.Parse(txtCase77.Text),
                                    int.Parse(txtCase78.Text)
                                },
                                {
                                    int.Parse(txtCase80.Text),
                                    int.Parse(txtCase81.Text),
                                    int.Parse(txtCase82.Text),
                                    int.Parse(txtCase83.Text),
                                    int.Parse(txtCase84.Text),
                                    int.Parse(txtCase85.Text),
                                    int.Parse(txtCase86.Text),
                                    int.Parse(txtCase87.Text),
                                    int.Parse(txtCase88.Text)
                                }
                            };
            return values;

        }

        private void setNewValues()
        {
            txtCase00.Text = mygrid.Values[0, 0].ToString();
            txtCase01.Text = mygrid.Values[0, 1].ToString();
            txtCase02.Text = mygrid.Values[0, 2].ToString();
            txtCase03.Text = mygrid.Values[0, 3].ToString();
            txtCase04.Text = mygrid.Values[0, 4].ToString();
            txtCase05.Text = mygrid.Values[0, 5].ToString();
            txtCase06.Text = mygrid.Values[0, 6].ToString();
            txtCase07.Text = mygrid.Values[0, 7].ToString();
            txtCase08.Text = mygrid.Values[0, 8].ToString();
            txtCase10.Text = mygrid.Values[1, 0].ToString();
            txtCase11.Text = mygrid.Values[1, 1].ToString();
            txtCase12.Text = mygrid.Values[1, 2].ToString();
            txtCase13.Text = mygrid.Values[1, 3].ToString();
            txtCase14.Text = mygrid.Values[1, 4].ToString();
            txtCase15.Text = mygrid.Values[1, 5].ToString();
            txtCase16.Text = mygrid.Values[1, 6].ToString();
            txtCase17.Text = mygrid.Values[1, 7].ToString();
            txtCase18.Text = mygrid.Values[1, 8].ToString();
            txtCase20.Text = mygrid.Values[2, 0].ToString();
            txtCase21.Text = mygrid.Values[2, 1].ToString();
            txtCase22.Text = mygrid.Values[2, 2].ToString();
            txtCase23.Text = mygrid.Values[2, 3].ToString();
            txtCase24.Text = mygrid.Values[2, 4].ToString();
            txtCase25.Text = mygrid.Values[2, 5].ToString();
            txtCase26.Text = mygrid.Values[2, 6].ToString();
            txtCase27.Text = mygrid.Values[2, 7].ToString();
            txtCase28.Text = mygrid.Values[2, 8].ToString();
            txtCase30.Text = mygrid.Values[3, 0].ToString();
            txtCase31.Text = mygrid.Values[3, 1].ToString();
            txtCase32.Text = mygrid.Values[3, 2].ToString();
            txtCase33.Text = mygrid.Values[3, 3].ToString();
            txtCase34.Text = mygrid.Values[3, 4].ToString();
            txtCase35.Text = mygrid.Values[3, 5].ToString();
            txtCase36.Text = mygrid.Values[3, 6].ToString();
            txtCase37.Text = mygrid.Values[3, 7].ToString();
            txtCase38.Text = mygrid.Values[3, 8].ToString();
            txtCase40.Text = mygrid.Values[4, 0].ToString();
            txtCase41.Text = mygrid.Values[4, 1].ToString();
            txtCase42.Text = mygrid.Values[4, 2].ToString();
            txtCase43.Text = mygrid.Values[4, 3].ToString();
            txtCase44.Text = mygrid.Values[4, 4].ToString();
            txtCase45.Text = mygrid.Values[4, 5].ToString();
            txtCase46.Text = mygrid.Values[4, 6].ToString();
            txtCase47.Text = mygrid.Values[4, 7].ToString();
            txtCase48.Text = mygrid.Values[4, 8].ToString();
            txtCase50.Text = mygrid.Values[5, 0].ToString();
            txtCase51.Text = mygrid.Values[5, 1].ToString();
            txtCase52.Text = mygrid.Values[5, 2].ToString();
            txtCase53.Text = mygrid.Values[5, 3].ToString();
            txtCase54.Text = mygrid.Values[5, 4].ToString();
            txtCase55.Text = mygrid.Values[5, 5].ToString();
            txtCase56.Text = mygrid.Values[5, 6].ToString();
            txtCase57.Text = mygrid.Values[5, 7].ToString();
            txtCase58.Text = mygrid.Values[5, 8].ToString();
            txtCase60.Text = mygrid.Values[6, 0].ToString();
            txtCase61.Text = mygrid.Values[6, 1].ToString();
            txtCase62.Text = mygrid.Values[6, 2].ToString();
            txtCase63.Text = mygrid.Values[6, 3].ToString();
            txtCase64.Text = mygrid.Values[6, 4].ToString();
            txtCase65.Text = mygrid.Values[6, 5].ToString();
            txtCase66.Text = mygrid.Values[6, 6].ToString();
            txtCase67.Text = mygrid.Values[6, 7].ToString();
            txtCase68.Text = mygrid.Values[6, 8].ToString();
            txtCase70.Text = mygrid.Values[7, 0].ToString();
            txtCase71.Text = mygrid.Values[7, 1].ToString();
            txtCase72.Text = mygrid.Values[7, 2].ToString();
            txtCase73.Text = mygrid.Values[7, 3].ToString();
            txtCase74.Text = mygrid.Values[7, 4].ToString();
            txtCase75.Text = mygrid.Values[7, 5].ToString();
            txtCase76.Text = mygrid.Values[7, 6].ToString();
            txtCase77.Text = mygrid.Values[7, 7].ToString();
            txtCase78.Text = mygrid.Values[7, 8].ToString();
            txtCase80.Text = mygrid.Values[8, 0].ToString();
            txtCase81.Text = mygrid.Values[8, 1].ToString();
            txtCase82.Text = mygrid.Values[8, 2].ToString();
            txtCase83.Text = mygrid.Values[8, 3].ToString();
            txtCase84.Text = mygrid.Values[8, 4].ToString();
            txtCase85.Text = mygrid.Values[8, 5].ToString();
            txtCase86.Text = mygrid.Values[8, 6].ToString();
            txtCase87.Text = mygrid.Values[8, 7].ToString();
            txtCase88.Text = mygrid.Values[8, 8].ToString();
        }
    }
}
