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
        public int[,] OriginalGridValues { get; set; }
        public LibrarySudokuResolver.Grid mygrid { get; set; }

        public MainWindow()
        {
            InitializeComponent();
            EnableAll(false);
        }

        private void btnSolve_Click(object sender, RoutedEventArgs e)
        {
            GridValues = getValuesInGrid();
            mygrid = new LibrarySudokuResolver.Grid(GridValues);
            if (mygrid.AutoSolve())
            {
                setNewValues();
                MessageBox.Show("Grid completed", "Success");
            }
            else
                MessageBox.Show("There are one or several error(s) in the original grid !", "Error");
        }

        private void resetValues(int[,] grid = null)
        {
            if (grid == null)
            {
                txtCase00.Text = "";
                txtCase01.Text = "";
                txtCase02.Text = "";
                txtCase03.Text = "";
                txtCase04.Text = "";
                txtCase05.Text = "";
                txtCase06.Text = "";
                txtCase07.Text = "";
                txtCase08.Text = "";
                txtCase10.Text = "";
                txtCase11.Text = "";
                txtCase12.Text = "";
                txtCase13.Text = "";
                txtCase14.Text = "";
                txtCase15.Text = "";
                txtCase16.Text = "";
                txtCase17.Text = "";
                txtCase18.Text = "";
                txtCase20.Text = "";
                txtCase21.Text = "";
                txtCase22.Text = "";
                txtCase23.Text = "";
                txtCase24.Text = "";
                txtCase25.Text = "";
                txtCase26.Text = "";
                txtCase27.Text = "";
                txtCase28.Text = "";
                txtCase30.Text = "";
                txtCase31.Text = "";
                txtCase32.Text = "";
                txtCase33.Text = "";
                txtCase34.Text = "";
                txtCase35.Text = "";
                txtCase36.Text = "";
                txtCase37.Text = "";
                txtCase38.Text = "";
                txtCase40.Text = "";
                txtCase41.Text = "";
                txtCase42.Text = "";
                txtCase43.Text = "";
                txtCase44.Text = "";
                txtCase45.Text = "";
                txtCase46.Text = "";
                txtCase47.Text = "";
                txtCase48.Text = "";
                txtCase50.Text = "";
                txtCase51.Text = "";
                txtCase52.Text = "";
                txtCase53.Text = "";
                txtCase54.Text = "";
                txtCase55.Text = "";
                txtCase56.Text = "";
                txtCase57.Text = "";
                txtCase58.Text = "";
                txtCase60.Text = "";
                txtCase61.Text = "";
                txtCase62.Text = "";
                txtCase63.Text = "";
                txtCase64.Text = "";
                txtCase65.Text = "";
                txtCase66.Text = "";
                txtCase67.Text = "";
                txtCase68.Text = "";
                txtCase70.Text = "";
                txtCase71.Text = "";
                txtCase72.Text = "";
                txtCase73.Text = "";
                txtCase74.Text = "";
                txtCase75.Text = "";
                txtCase76.Text = "";
                txtCase77.Text = "";
                txtCase78.Text = "";
                txtCase80.Text = "";
                txtCase81.Text = "";
                txtCase82.Text = "";
                txtCase83.Text = "";
                txtCase84.Text = "";
                txtCase85.Text = "";
                txtCase86.Text = "";
                txtCase87.Text = "";
                txtCase88.Text = "";
            }
            else
            {
                txtCase00.Text = grid[0, 0] > 0 ? grid[0, 0].ToString() : "";
                txtCase01.Text = grid[0, 1] > 0 ? grid[0, 1].ToString() : "";
                txtCase02.Text = grid[0, 2] > 0 ? grid[0, 2].ToString() : "";
                txtCase03.Text = grid[0, 3] > 0 ? grid[0, 3].ToString() : "";
                txtCase04.Text = grid[0, 4] > 0 ? grid[0, 4].ToString() : "";
                txtCase05.Text = grid[0, 5] > 0 ? grid[0, 5].ToString() : "";
                txtCase06.Text = grid[0, 6] > 0 ? grid[0, 6].ToString() : "";
                txtCase07.Text = grid[0, 7] > 0 ? grid[0, 7].ToString() : "";
                txtCase08.Text = grid[0, 8] > 0 ? grid[0, 8].ToString() : "";
                txtCase10.Text = grid[1, 0] > 0 ? grid[1, 0].ToString() : "";
                txtCase11.Text = grid[1, 1] > 0 ? grid[1, 1].ToString() : "";
                txtCase12.Text = grid[1, 2] > 0 ? grid[1, 2].ToString() : "";
                txtCase13.Text = grid[1, 3] > 0 ? grid[1, 3].ToString() : "";
                txtCase14.Text = grid[1, 4] > 0 ? grid[1, 4].ToString() : "";
                txtCase15.Text = grid[1, 5] > 0 ? grid[1, 5].ToString() : "";
                txtCase16.Text = grid[1, 6] > 0 ? grid[1, 6].ToString() : "";
                txtCase17.Text = grid[1, 7] > 0 ? grid[1, 7].ToString() : "";
                txtCase18.Text = grid[1, 8] > 0 ? grid[1, 8].ToString() : "";
                txtCase20.Text = grid[2, 0] > 0 ? grid[2, 0].ToString() : "";
                txtCase21.Text = grid[2, 1] > 0 ? grid[2, 1].ToString() : "";
                txtCase22.Text = grid[2, 2] > 0 ? grid[2, 2].ToString() : "";
                txtCase23.Text = grid[2, 3] > 0 ? grid[2, 3].ToString() : "";
                txtCase24.Text = grid[2, 4] > 0 ? grid[2, 4].ToString() : "";
                txtCase25.Text = grid[2, 5] > 0 ? grid[2, 5].ToString() : "";
                txtCase26.Text = grid[2, 6] > 0 ? grid[2, 6].ToString() : "";
                txtCase27.Text = grid[2, 7] > 0 ? grid[2, 7].ToString() : "";
                txtCase28.Text = grid[2, 8] > 0 ? grid[2, 8].ToString() : "";
                txtCase30.Text = grid[3, 0] > 0 ? grid[3, 0].ToString() : "";
                txtCase31.Text = grid[3, 1] > 0 ? grid[3, 1].ToString() : "";
                txtCase32.Text = grid[3, 2] > 0 ? grid[3, 2].ToString() : "";
                txtCase33.Text = grid[3, 3] > 0 ? grid[3, 3].ToString() : "";
                txtCase34.Text = grid[3, 4] > 0 ? grid[3, 4].ToString() : "";
                txtCase35.Text = grid[3, 5] > 0 ? grid[3, 5].ToString() : "";
                txtCase36.Text = grid[3, 6] > 0 ? grid[3, 6].ToString() : "";
                txtCase37.Text = grid[3, 7] > 0 ? grid[3, 7].ToString() : "";
                txtCase38.Text = grid[3, 8] > 0 ? grid[3, 8].ToString() : "";
                txtCase40.Text = grid[4, 0] > 0 ? grid[4, 0].ToString() : "";
                txtCase41.Text = grid[4, 1] > 0 ? grid[4, 1].ToString() : "";
                txtCase42.Text = grid[4, 2] > 0 ? grid[4, 2].ToString() : "";
                txtCase43.Text = grid[4, 3] > 0 ? grid[4, 3].ToString() : "";
                txtCase44.Text = grid[4, 4] > 0 ? grid[4, 4].ToString() : "";
                txtCase45.Text = grid[4, 5] > 0 ? grid[4, 5].ToString() : "";
                txtCase46.Text = grid[4, 6] > 0 ? grid[4, 6].ToString() : "";
                txtCase47.Text = grid[4, 7] > 0 ? grid[4, 7].ToString() : "";
                txtCase48.Text = grid[4, 8] > 0 ? grid[4, 8].ToString() : "";
                txtCase50.Text = grid[5, 0] > 0 ? grid[5, 0].ToString() : "";
                txtCase51.Text = grid[5, 1] > 0 ? grid[5, 1].ToString() : "";
                txtCase52.Text = grid[5, 2] > 0 ? grid[5, 2].ToString() : "";
                txtCase53.Text = grid[5, 3] > 0 ? grid[5, 3].ToString() : "";
                txtCase54.Text = grid[5, 4] > 0 ? grid[5, 4].ToString() : "";
                txtCase55.Text = grid[5, 5] > 0 ? grid[5, 5].ToString() : "";
                txtCase56.Text = grid[5, 6] > 0 ? grid[5, 6].ToString() : "";
                txtCase57.Text = grid[5, 7] > 0 ? grid[5, 7].ToString() : "";
                txtCase58.Text = grid[5, 8] > 0 ? grid[5, 8].ToString() : "";
                txtCase60.Text = grid[6, 0] > 0 ? grid[6, 0].ToString() : "";
                txtCase61.Text = grid[6, 1] > 0 ? grid[6, 1].ToString() : "";
                txtCase62.Text = grid[6, 2] > 0 ? grid[6, 2].ToString() : "";
                txtCase63.Text = grid[6, 3] > 0 ? grid[6, 3].ToString() : "";
                txtCase64.Text = grid[6, 4] > 0 ? grid[6, 4].ToString() : "";
                txtCase65.Text = grid[6, 5] > 0 ? grid[6, 5].ToString() : "";
                txtCase66.Text = grid[6, 6] > 0 ? grid[6, 6].ToString() : "";
                txtCase67.Text = grid[6, 7] > 0 ? grid[6, 7].ToString() : "";
                txtCase68.Text = grid[6, 8] > 0 ? grid[6, 8].ToString() : "";
                txtCase70.Text = grid[7, 0] > 0 ? grid[7, 0].ToString() : "";
                txtCase71.Text = grid[7, 1] > 0 ? grid[7, 1].ToString() : "";
                txtCase72.Text = grid[7, 2] > 0 ? grid[7, 2].ToString() : "";
                txtCase73.Text = grid[7, 3] > 0 ? grid[7, 3].ToString() : "";
                txtCase74.Text = grid[7, 4] > 0 ? grid[7, 4].ToString() : "";
                txtCase75.Text = grid[7, 5] > 0 ? grid[7, 5].ToString() : "";
                txtCase76.Text = grid[7, 6] > 0 ? grid[7, 6].ToString() : "";
                txtCase77.Text = grid[7, 7] > 0 ? grid[7, 7].ToString() : "";
                txtCase78.Text = grid[7, 8] > 0 ? grid[7, 8].ToString() : "";
                txtCase80.Text = grid[8, 0] > 0 ? grid[8, 0].ToString() : "";
                txtCase81.Text = grid[8, 1] > 0 ? grid[8, 1].ToString() : "";
                txtCase82.Text = grid[8, 2] > 0 ? grid[8, 2].ToString() : "";
                txtCase83.Text = grid[8, 3] > 0 ? grid[8, 3].ToString() : "";
                txtCase84.Text = grid[8, 4] > 0 ? grid[8, 4].ToString() : "";
                txtCase85.Text = grid[8, 5] > 0 ? grid[8, 5].ToString() : "";
                txtCase86.Text = grid[8, 6] > 0 ? grid[8, 6].ToString() : "";
                txtCase87.Text = grid[8, 7] > 0 ? grid[8, 7].ToString() : "";
                txtCase88.Text = grid[8, 8] > 0 ? grid[8, 8].ToString() : "";
            }

            //txtCase00.Text = "0";
            //txtCase01.Text = "1";
            //txtCase02.Text = "0";
            //txtCase03.Text = "0";
            //txtCase04.Text = "2";
            //txtCase05.Text = "5";
            //txtCase06.Text = "0";
            //txtCase07.Text = "7";
            //txtCase08.Text = "0";
            //txtCase10.Text = "0";
            //txtCase11.Text = "0";
            //txtCase12.Text = "5";
            //txtCase13.Text = "0";
            //txtCase14.Text = "1";
            //txtCase15.Text = "7";
            //txtCase16.Text = "0";
            //txtCase17.Text = "6";
            //txtCase18.Text = "9";
            //txtCase20.Text = "7";
            //txtCase21.Text = "8";
            //txtCase22.Text = "9";
            //txtCase23.Text = "0";
            //txtCase24.Text = "3";
            //txtCase25.Text = "0";
            //txtCase26.Text = "0";
            //txtCase27.Text = "0";
            //txtCase28.Text = "0";
            //txtCase30.Text = "0";
            //txtCase31.Text = "5";
            //txtCase32.Text = "0";
            //txtCase33.Text = "0";
            //txtCase34.Text = "0";
            //txtCase35.Text = "0";
            //txtCase36.Text = "0";
            //txtCase37.Text = "0";
            //txtCase38.Text = "0";
            //txtCase40.Text = "0";
            //txtCase41.Text = "6";
            //txtCase42.Text = "3";
            //txtCase43.Text = "1";
            //txtCase44.Text = "9";
            //txtCase45.Text = "2";
            //txtCase46.Text = "7";
            //txtCase47.Text = "4";
            //txtCase48.Text = "5";
            //txtCase50.Text = "0";
            //txtCase51.Text = "0";
            //txtCase52.Text = "0";
            //txtCase53.Text = "0";
            //txtCase54.Text = "0";
            //txtCase55.Text = "6";
            //txtCase56.Text = "1";
            //txtCase57.Text = "3";
            //txtCase58.Text = "2";
            //txtCase60.Text = "0";
            //txtCase61.Text = "0";
            //txtCase62.Text = "1";
            //txtCase63.Text = "0";
            //txtCase64.Text = "7";
            //txtCase65.Text = "0";
            //txtCase66.Text = "0";
            //txtCase67.Text = "5";
            //txtCase68.Text = "0";
            //txtCase70.Text = "2";
            //txtCase71.Text = "0";
            //txtCase72.Text = "0";
            //txtCase73.Text = "0";
            //txtCase74.Text = "5";
            //txtCase75.Text = "1";
            //txtCase76.Text = "9";
            //txtCase77.Text = "8";
            //txtCase78.Text = "7";
            //txtCase80.Text = "5";
            //txtCase81.Text = "0";
            //txtCase82.Text = "8";
            //txtCase83.Text = "3";
            //txtCase84.Text = "0";
            //txtCase85.Text = "0";
            //txtCase86.Text = "2";
            //txtCase87.Text = "1";
            //txtCase88.Text = "0";
        }

        private int[,] getValuesInGrid()
        {
            int[,] values = {
                                {
                                    int.Parse(txtCase00.Text != "" ? txtCase00.Text : "0"),
                                    int.Parse(txtCase01.Text != "" ? txtCase01.Text : "0"),
                                    int.Parse(txtCase02.Text != "" ? txtCase02.Text : "0"),
                                    int.Parse(txtCase03.Text != "" ? txtCase03.Text : "0"),
                                    int.Parse(txtCase04.Text != "" ? txtCase04.Text : "0"),
                                    int.Parse(txtCase05.Text != "" ? txtCase05.Text : "0"),
                                    int.Parse(txtCase06.Text != "" ? txtCase06.Text : "0"),
                                    int.Parse(txtCase07.Text != "" ? txtCase07.Text : "0"),
                                    int.Parse(txtCase08.Text != "" ? txtCase08.Text : "0")
                                },
                                {
                                    int.Parse(txtCase10.Text != "" ? txtCase10.Text : "0"),
                                    int.Parse(txtCase11.Text != "" ? txtCase11.Text : "0"),
                                    int.Parse(txtCase12.Text != "" ? txtCase12.Text : "0"),
                                    int.Parse(txtCase13.Text != "" ? txtCase13.Text : "0"),
                                    int.Parse(txtCase14.Text != "" ? txtCase14.Text : "0"),
                                    int.Parse(txtCase15.Text != "" ? txtCase15.Text : "0"),
                                    int.Parse(txtCase16.Text != "" ? txtCase16.Text : "0"),
                                    int.Parse(txtCase17.Text != "" ? txtCase17.Text : "0"),
                                    int.Parse(txtCase18.Text != "" ? txtCase18.Text : "0")
                                },
                                {
                                    int.Parse(txtCase20.Text != "" ? txtCase20.Text : "0"),
                                    int.Parse(txtCase21.Text != "" ? txtCase21.Text : "0"),
                                    int.Parse(txtCase22.Text != "" ? txtCase22.Text : "0"),
                                    int.Parse(txtCase23.Text != "" ? txtCase23.Text : "0"),
                                    int.Parse(txtCase24.Text != "" ? txtCase24.Text : "0"),
                                    int.Parse(txtCase25.Text != "" ? txtCase25.Text : "0"),
                                    int.Parse(txtCase26.Text != "" ? txtCase26.Text : "0"),
                                    int.Parse(txtCase27.Text != "" ? txtCase27.Text : "0"),
                                    int.Parse(txtCase28.Text != "" ? txtCase28.Text : "0")
                                },
                                {
                                    int.Parse(txtCase30.Text != "" ? txtCase30.Text : "0"),
                                    int.Parse(txtCase31.Text != "" ? txtCase31.Text : "0"),
                                    int.Parse(txtCase32.Text != "" ? txtCase32.Text : "0"),
                                    int.Parse(txtCase33.Text != "" ? txtCase33.Text : "0"),
                                    int.Parse(txtCase34.Text != "" ? txtCase34.Text : "0"),
                                    int.Parse(txtCase35.Text != "" ? txtCase35.Text : "0"),
                                    int.Parse(txtCase36.Text != "" ? txtCase36.Text : "0"),
                                    int.Parse(txtCase37.Text != "" ? txtCase37.Text : "0"),
                                    int.Parse(txtCase38.Text != "" ? txtCase38.Text : "0")
                                },
                                {
                                    int.Parse(txtCase40.Text != "" ? txtCase40.Text : "0"),
                                    int.Parse(txtCase41.Text != "" ? txtCase41.Text : "0"),
                                    int.Parse(txtCase42.Text != "" ? txtCase42.Text : "0"),
                                    int.Parse(txtCase43.Text != "" ? txtCase43.Text : "0"),
                                    int.Parse(txtCase44.Text != "" ? txtCase44.Text : "0"),
                                    int.Parse(txtCase45.Text != "" ? txtCase45.Text : "0"),
                                    int.Parse(txtCase46.Text != "" ? txtCase46.Text : "0"),
                                    int.Parse(txtCase47.Text != "" ? txtCase47.Text : "0"),
                                    int.Parse(txtCase48.Text != "" ? txtCase48.Text : "0")
                                },
                                {
                                    int.Parse(txtCase50.Text != "" ? txtCase50.Text : "0"),
                                    int.Parse(txtCase51.Text != "" ? txtCase51.Text : "0"),
                                    int.Parse(txtCase52.Text != "" ? txtCase52.Text : "0"),
                                    int.Parse(txtCase53.Text != "" ? txtCase53.Text : "0"),
                                    int.Parse(txtCase54.Text != "" ? txtCase54.Text : "0"),
                                    int.Parse(txtCase55.Text != "" ? txtCase55.Text : "0"),
                                    int.Parse(txtCase56.Text != "" ? txtCase56.Text : "0"),
                                    int.Parse(txtCase57.Text != "" ? txtCase57.Text : "0"),
                                    int.Parse(txtCase58.Text != "" ? txtCase58.Text : "0")
                                },
                                {
                                    int.Parse(txtCase60.Text != "" ? txtCase60.Text : "0"),
                                    int.Parse(txtCase61.Text != "" ? txtCase61.Text : "0"),
                                    int.Parse(txtCase62.Text != "" ? txtCase62.Text : "0"),
                                    int.Parse(txtCase63.Text != "" ? txtCase63.Text : "0"),
                                    int.Parse(txtCase64.Text != "" ? txtCase64.Text : "0"),
                                    int.Parse(txtCase65.Text != "" ? txtCase65.Text : "0"),
                                    int.Parse(txtCase66.Text != "" ? txtCase66.Text : "0"),
                                    int.Parse(txtCase67.Text != "" ? txtCase67.Text : "0"),
                                    int.Parse(txtCase68.Text != "" ? txtCase68.Text : "0")
                                },
                                {
                                    int.Parse(txtCase70.Text != "" ? txtCase70.Text : "0"),
                                    int.Parse(txtCase71.Text != "" ? txtCase71.Text : "0"),
                                    int.Parse(txtCase72.Text != "" ? txtCase72.Text : "0"),
                                    int.Parse(txtCase73.Text != "" ? txtCase73.Text : "0"),
                                    int.Parse(txtCase74.Text != "" ? txtCase74.Text : "0"),
                                    int.Parse(txtCase75.Text != "" ? txtCase75.Text : "0"),
                                    int.Parse(txtCase76.Text != "" ? txtCase76.Text : "0"),
                                    int.Parse(txtCase77.Text != "" ? txtCase77.Text : "0"),
                                    int.Parse(txtCase78.Text != "" ? txtCase78.Text : "0")
                                },
                                {
                                    int.Parse(txtCase80.Text != "" ? txtCase80.Text : "0"),
                                    int.Parse(txtCase81.Text != "" ? txtCase81.Text : "0"),
                                    int.Parse(txtCase82.Text != "" ? txtCase82.Text : "0"),
                                    int.Parse(txtCase83.Text != "" ? txtCase83.Text : "0"),
                                    int.Parse(txtCase84.Text != "" ? txtCase84.Text : "0"),
                                    int.Parse(txtCase85.Text != "" ? txtCase85.Text : "0"),
                                    int.Parse(txtCase86.Text != "" ? txtCase86.Text : "0"),
                                    int.Parse(txtCase87.Text != "" ? txtCase87.Text : "0"),
                                    int.Parse(txtCase88.Text != "" ? txtCase88.Text : "0")
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

        private void btnInsertValues_Click(object sender, RoutedEventArgs e)
        {
            EnableAll(true);
        }

        private void btnResetValues_Click(object sender, RoutedEventArgs e)
        {
            resetValues();
        }

        private void btnValidValues_Click(object sender, RoutedEventArgs e)
        {
            EnableContainingValues();
            GridValues = getValuesInGrid();
            OriginalGridValues = getValuesInGrid();
            mygrid = new LibrarySudokuResolver.Grid(GridValues);
        }

        public void EnableContainingValues()
        {
            txtCase00.IsEnabled = !(txtCase00.Text != "" && txtCase00.Text != "0");
            txtCase01.IsEnabled = !(txtCase01.Text != "" && txtCase01.Text != "0");
            txtCase02.IsEnabled = !(txtCase02.Text != "" && txtCase02.Text != "0");
            txtCase03.IsEnabled = !(txtCase03.Text != "" && txtCase03.Text != "0");
            txtCase04.IsEnabled = !(txtCase04.Text != "" && txtCase04.Text != "0");
            txtCase05.IsEnabled = !(txtCase05.Text != "" && txtCase05.Text != "0");
            txtCase06.IsEnabled = !(txtCase06.Text != "" && txtCase06.Text != "0");
            txtCase07.IsEnabled = !(txtCase07.Text != "" && txtCase07.Text != "0");
            txtCase08.IsEnabled = !(txtCase08.Text != "" && txtCase08.Text != "0");

            txtCase10.IsEnabled = !(txtCase10.Text != "" && txtCase10.Text != "0");
            txtCase11.IsEnabled = !(txtCase11.Text != "" && txtCase11.Text != "0");
            txtCase12.IsEnabled = !(txtCase12.Text != "" && txtCase12.Text != "0");
            txtCase13.IsEnabled = !(txtCase13.Text != "" && txtCase13.Text != "0");
            txtCase14.IsEnabled = !(txtCase14.Text != "" && txtCase14.Text != "0");
            txtCase15.IsEnabled = !(txtCase15.Text != "" && txtCase15.Text != "0");
            txtCase16.IsEnabled = !(txtCase16.Text != "" && txtCase16.Text != "0");
            txtCase17.IsEnabled = !(txtCase17.Text != "" && txtCase17.Text != "0");
            txtCase18.IsEnabled = !(txtCase18.Text != "" && txtCase18.Text != "0");

            txtCase20.IsEnabled = !(txtCase20.Text != "" && txtCase20.Text != "0");
            txtCase21.IsEnabled = !(txtCase21.Text != "" && txtCase21.Text != "0");
            txtCase22.IsEnabled = !(txtCase22.Text != "" && txtCase22.Text != "0");
            txtCase23.IsEnabled = !(txtCase23.Text != "" && txtCase23.Text != "0");
            txtCase24.IsEnabled = !(txtCase24.Text != "" && txtCase24.Text != "0");
            txtCase25.IsEnabled = !(txtCase25.Text != "" && txtCase25.Text != "0");
            txtCase26.IsEnabled = !(txtCase26.Text != "" && txtCase26.Text != "0");
            txtCase27.IsEnabled = !(txtCase27.Text != "" && txtCase27.Text != "0");
            txtCase28.IsEnabled = !(txtCase28.Text != "" && txtCase28.Text != "0");

            txtCase30.IsEnabled = !(txtCase30.Text != "" && txtCase30.Text != "0");
            txtCase31.IsEnabled = !(txtCase31.Text != "" && txtCase31.Text != "0");
            txtCase32.IsEnabled = !(txtCase32.Text != "" && txtCase32.Text != "0");
            txtCase33.IsEnabled = !(txtCase33.Text != "" && txtCase33.Text != "0");
            txtCase34.IsEnabled = !(txtCase34.Text != "" && txtCase34.Text != "0");
            txtCase35.IsEnabled = !(txtCase35.Text != "" && txtCase35.Text != "0");
            txtCase36.IsEnabled = !(txtCase36.Text != "" && txtCase36.Text != "0");
            txtCase37.IsEnabled = !(txtCase37.Text != "" && txtCase37.Text != "0");
            txtCase38.IsEnabled = !(txtCase38.Text != "" && txtCase38.Text != "0");

            txtCase40.IsEnabled = !(txtCase40.Text != "" && txtCase40.Text != "0");
            txtCase41.IsEnabled = !(txtCase41.Text != "" && txtCase41.Text != "0");
            txtCase42.IsEnabled = !(txtCase42.Text != "" && txtCase42.Text != "0");
            txtCase43.IsEnabled = !(txtCase43.Text != "" && txtCase43.Text != "0");
            txtCase44.IsEnabled = !(txtCase44.Text != "" && txtCase44.Text != "0");
            txtCase45.IsEnabled = !(txtCase45.Text != "" && txtCase45.Text != "0");
            txtCase46.IsEnabled = !(txtCase46.Text != "" && txtCase46.Text != "0");
            txtCase47.IsEnabled = !(txtCase47.Text != "" && txtCase47.Text != "0");
            txtCase48.IsEnabled = !(txtCase48.Text != "" && txtCase48.Text != "0");

            txtCase50.IsEnabled = !(txtCase50.Text != "" && txtCase50.Text != "0");
            txtCase51.IsEnabled = !(txtCase51.Text != "" && txtCase51.Text != "0");
            txtCase52.IsEnabled = !(txtCase52.Text != "" && txtCase52.Text != "0");
            txtCase53.IsEnabled = !(txtCase53.Text != "" && txtCase53.Text != "0");
            txtCase54.IsEnabled = !(txtCase54.Text != "" && txtCase54.Text != "0");
            txtCase55.IsEnabled = !(txtCase55.Text != "" && txtCase55.Text != "0");
            txtCase56.IsEnabled = !(txtCase56.Text != "" && txtCase56.Text != "0");
            txtCase57.IsEnabled = !(txtCase57.Text != "" && txtCase57.Text != "0");
            txtCase58.IsEnabled = !(txtCase58.Text != "" && txtCase58.Text != "0");

            txtCase60.IsEnabled = !(txtCase60.Text != "" && txtCase60.Text != "0");
            txtCase61.IsEnabled = !(txtCase61.Text != "" && txtCase61.Text != "0");
            txtCase62.IsEnabled = !(txtCase62.Text != "" && txtCase62.Text != "0");
            txtCase63.IsEnabled = !(txtCase63.Text != "" && txtCase63.Text != "0");
            txtCase64.IsEnabled = !(txtCase64.Text != "" && txtCase64.Text != "0");
            txtCase65.IsEnabled = !(txtCase65.Text != "" && txtCase65.Text != "0");
            txtCase66.IsEnabled = !(txtCase66.Text != "" && txtCase66.Text != "0");
            txtCase67.IsEnabled = !(txtCase67.Text != "" && txtCase67.Text != "0");
            txtCase68.IsEnabled = !(txtCase68.Text != "" && txtCase68.Text != "0");

            txtCase70.IsEnabled = !(txtCase70.Text != "" && txtCase70.Text != "0");
            txtCase71.IsEnabled = !(txtCase71.Text != "" && txtCase71.Text != "0");
            txtCase72.IsEnabled = !(txtCase72.Text != "" && txtCase72.Text != "0");
            txtCase73.IsEnabled = !(txtCase73.Text != "" && txtCase73.Text != "0");
            txtCase74.IsEnabled = !(txtCase74.Text != "" && txtCase74.Text != "0");
            txtCase75.IsEnabled = !(txtCase75.Text != "" && txtCase75.Text != "0");
            txtCase76.IsEnabled = !(txtCase76.Text != "" && txtCase76.Text != "0");
            txtCase77.IsEnabled = !(txtCase77.Text != "" && txtCase77.Text != "0");
            txtCase78.IsEnabled = !(txtCase78.Text != "" && txtCase78.Text != "0");

            txtCase80.IsEnabled = !(txtCase80.Text != "" && txtCase80.Text != "0");
            txtCase81.IsEnabled = !(txtCase81.Text != "" && txtCase81.Text != "0");
            txtCase82.IsEnabled = !(txtCase82.Text != "" && txtCase82.Text != "0");
            txtCase83.IsEnabled = !(txtCase83.Text != "" && txtCase83.Text != "0");
            txtCase84.IsEnabled = !(txtCase84.Text != "" && txtCase84.Text != "0");
            txtCase85.IsEnabled = !(txtCase85.Text != "" && txtCase85.Text != "0");
            txtCase86.IsEnabled = !(txtCase86.Text != "" && txtCase86.Text != "0");
            txtCase87.IsEnabled = !(txtCase87.Text != "" && txtCase87.Text != "0");
            txtCase88.IsEnabled = !(txtCase88.Text != "" && txtCase88.Text != "0");
        }

        public void EnableAll(bool value = true)
        {
            txtCase00.IsEnabled = value;
            txtCase01.IsEnabled = value;
            txtCase02.IsEnabled = value;
            txtCase03.IsEnabled = value;
            txtCase04.IsEnabled = value;
            txtCase05.IsEnabled = value;
            txtCase06.IsEnabled = value;
            txtCase07.IsEnabled = value;
            txtCase08.IsEnabled = value;

            txtCase10.IsEnabled = value;
            txtCase11.IsEnabled = value;
            txtCase12.IsEnabled = value;
            txtCase13.IsEnabled = value;
            txtCase14.IsEnabled = value;
            txtCase15.IsEnabled = value;
            txtCase16.IsEnabled = value;
            txtCase17.IsEnabled = value;
            txtCase18.IsEnabled = value;

            txtCase20.IsEnabled = value;
            txtCase21.IsEnabled = value;
            txtCase22.IsEnabled = value;
            txtCase23.IsEnabled = value;
            txtCase24.IsEnabled = value;
            txtCase25.IsEnabled = value;
            txtCase26.IsEnabled = value;
            txtCase27.IsEnabled = value;
            txtCase28.IsEnabled = value;

            txtCase30.IsEnabled = value;
            txtCase31.IsEnabled = value;
            txtCase32.IsEnabled = value;
            txtCase33.IsEnabled = value;
            txtCase34.IsEnabled = value;
            txtCase35.IsEnabled = value;
            txtCase36.IsEnabled = value;
            txtCase37.IsEnabled = value;
            txtCase38.IsEnabled = value;

            txtCase40.IsEnabled = value;
            txtCase41.IsEnabled = value;
            txtCase42.IsEnabled = value;
            txtCase43.IsEnabled = value;
            txtCase44.IsEnabled = value;
            txtCase45.IsEnabled = value;
            txtCase46.IsEnabled = value;
            txtCase47.IsEnabled = value;
            txtCase48.IsEnabled = value;

            txtCase50.IsEnabled = value;
            txtCase51.IsEnabled = value;
            txtCase52.IsEnabled = value;
            txtCase53.IsEnabled = value;
            txtCase54.IsEnabled = value;
            txtCase55.IsEnabled = value;
            txtCase56.IsEnabled = value;
            txtCase57.IsEnabled = value;
            txtCase58.IsEnabled = value;

            txtCase60.IsEnabled = value;
            txtCase61.IsEnabled = value;
            txtCase62.IsEnabled = value;
            txtCase63.IsEnabled = value;
            txtCase64.IsEnabled = value;
            txtCase65.IsEnabled = value;
            txtCase66.IsEnabled = value;
            txtCase67.IsEnabled = value;
            txtCase68.IsEnabled = value;

            txtCase70.IsEnabled = value;
            txtCase71.IsEnabled = value;
            txtCase72.IsEnabled = value;
            txtCase73.IsEnabled = value;
            txtCase74.IsEnabled = value;
            txtCase75.IsEnabled = value;
            txtCase76.IsEnabled = value;
            txtCase77.IsEnabled = value;
            txtCase78.IsEnabled = value;

            txtCase80.IsEnabled = value;
            txtCase81.IsEnabled = value;
            txtCase82.IsEnabled = value;
            txtCase83.IsEnabled = value;
            txtCase84.IsEnabled = value;
            txtCase85.IsEnabled = value;
            txtCase86.IsEnabled = value;
            txtCase87.IsEnabled = value;
            txtCase88.IsEnabled = value;
        }
    }
}
