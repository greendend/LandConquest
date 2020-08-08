﻿using LandConquest.Forces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace LandConquest.Forms
{
    /// <summary>
    /// Логика взаимодействия для WarWindow.xaml
    /// </summary>
    public partial class WarWindow : Window
    {
        System.Windows.Controls.Primitives.UniformGrid localWarMap = new System.Windows.Controls.Primitives.UniformGrid();
        Image imgArmy;
        Boolean f_armySelected = false;
        int INDEX;

        //Canvas localWarArmyLayer = new Canvas();
        public WarWindow()
        {
            InitializeComponent();
            int columnWidth = 40;
            int rowHeight = 40;
            localWarMap.Columns = 30; //50
            localWarMap.Rows = 20;    //40
            gridForArmies.Columns = 30;
            gridForArmies.Rows = 20;

            localWarMap.Width = columnWidth * localWarMap.Columns;
            gridForArmies.Width = columnWidth * localWarMap.Columns;
            localWarMap.Height = rowHeight * localWarMap.Rows;
            gridForArmies.Height = rowHeight * localWarMap.Rows;

            localWarMap.HorizontalAlignment = HorizontalAlignment.Left;
            localWarMap.VerticalAlignment = VerticalAlignment.Center;
            gridForArmies.HorizontalAlignment = HorizontalAlignment.Left;
            gridForArmies.VerticalAlignment = VerticalAlignment.Center;
            Loaded += WarWin_Loaded;
        }

        private void WarWin_Loaded(object sender, RoutedEventArgs e)
        {
            imgArmy = new Image();
            imgArmy.MouseDown += ImgArmy_MouseLeftButtonDown;
            imgArmy.MouseEnter += ImgArmy_MouseEnter;
            imgArmy.MouseLeave += ImgArmy_MouseLeave;
            imgArmy.Width = 40;
            imgArmy.Height = 40;
            imgArmy.Source = new BitmapImage(new Uri("/Pictures/warrior.png", UriKind.Relative));

            for (int x = 0; x < localWarMap.Columns; x++)
            {
                for (int y = 0; y < localWarMap.Rows; y++)
                {
                    Image tile = new Image();
                    tile.Source = new BitmapImage(new Uri("/Pictures/test-tile.jpg", UriKind.Relative));
                    localWarMap.Children.Add(tile);
                    gridForArmies.Children.Add(new Image());
                }
            }
            mainWarWinGrid.Children.Add(localWarMap);
            //test 
            //tileSelected.Source = "/Pictures/tile-test-red.jpg";

            int index = ReturnNumberOfCell(20, 30);
            gridForArmies.Children.RemoveAt(index);
            gridForArmies.Children.Insert(index, imgArmy);
        }

        public int ReturnNumberOfCell(int row, int column)
        {
            int index = (row - 1) * localWarMap.Columns + column - 1;
            return index;
        }

        private void ImgArmy_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            int index = gridForArmies.Children.IndexOf(imgArmy);
            localWarMap.Children.RemoveAt(index);
            localWarMap.Children.Insert(index, new Image { Source = new BitmapImage(new Uri("/Pictures/tile-test-red.jpg", UriKind.Relative)) });

            f_armySelected = true;
            INDEX = index;
            ShowAvailableTilesToMove(index);
        }

        private void tile_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (f_armySelected)
            {
                f_armySelected = false;
                int index = localWarMap.Children.IndexOf((Image)sender);
                gridForArmies.Children.RemoveAt(INDEX);
                gridForArmies.Children.Insert(index, imgArmy);
                HideAvailableTilesToMove(INDEX);
                ShowAvailableTilesToMove(index);
            }
        }

        private void ImgArmy_MouseEnter(object sender, MouseEventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void ImgArmy_MouseLeave(object sender, MouseEventArgs e)
        {
            Cursor = Cursors.Arrow;
        }

        public void ShowAvailableTilesToMove(int index) //+ int forces movement speed;
        {
            // army type
            //gridForArmies.ro
            Console.WriteLine("INDEX = " + index);

            int row = index / localWarMap.Columns + 1;
            int col = index - localWarMap.Columns * (row - 1) + 1;

            Console.WriteLine("ROW = " + row + " COL = " + col);



            int movement = (int)ForcesEnum.Archers.Movement;
            //????????????????????????????????????????????????????????
            for (int i = row - movement; i <= row + movement; i++)
            {
                for (int j = col - movement; j <= col + movement; j++)
                {
                    if ((i < 1) || (j < 1) || (j > localWarMap.Columns) || (i > localWarMap.Rows)) continue;  //
                    int ind = ReturnNumberOfCell(i, j);
                    localWarMap.Children.RemoveAt(ind);
                    Image availableTileForMoving = new Image { Source = new BitmapImage(new Uri("/Pictures/tile-test-red.jpg", UriKind.Relative)) };
                    availableTileForMoving.MouseRightButtonDown += tile_MouseRightButtonDown;
                    localWarMap.Children.Insert(ind, availableTileForMoving);
                }
            }
        }

        public void HideAvailableTilesToMove(int index) //+ int forces movement speed;
        {
            // АНАЛОГ ФУНКЦИИ ВЫШЕ, (не супер оптимизирован, но лучше чем перекрашивать вообще все клетки)
            Console.WriteLine("INDEX = " + index);

            int row = index / localWarMap.Columns + 1;
            int col = index - localWarMap.Columns * (row - 1) + 1;

            Console.WriteLine("ROW = " + row + " COL = " + col);



            int movement = (int)ForcesEnum.Archers.Movement;
            //????????????????????????????????????????????????????????
            for (int i = row - movement; i <= row + movement; i++)
            {
                for (int j = col - movement; j <= col + movement; j++)
                {
                    if ((i < 1) || (j < 1) || (j > localWarMap.Columns) || (i > localWarMap.Rows)) continue;  //
                    int ind = ReturnNumberOfCell(i, j);
                    localWarMap.Children.RemoveAt(ind);
                    Image availableTileForMoving = new Image { Source = new BitmapImage(new Uri("/Pictures/test-tile.jpg", UriKind.Relative)) };
                    //availableTileForMoving.MouseRightButtonDown += tile_MouseRightButtonDown;
                    localWarMap.Children.Insert(ind, availableTileForMoving);
                }
            }
        }
    }
}
