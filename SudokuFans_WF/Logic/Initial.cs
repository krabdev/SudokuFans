using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SudokuFans_WF.Logic
{
    class Initial
    {
        private int[,] _array = new int[9, 9];

        public Initial()
        {
            Random random = new Random();
            for (int i = 0; i < 9; i++)
            {
                for (int y = 0; y < 9; y++)
                {

                    int[] array = new int[9];
                    for (int x = 0; x < 9; x++)
                    {
                        int flag;
                        do
                        {

                            flag = 1;

                            int temp = random.Next(1, 10);

                            array[x] = temp;
                            for (int k = 0; k < x; k++)
                            {
                                
                                if (temp == array[k])
                                {
                                    flag = 0;
                                    break;
                                }
                            }
                        } while (flag == 0);
                    }

                    int[] arrayx = new int[9]; arrayx = array;
                    int[] arrayy = new int[9]; arrayy = array;
                    int[] arrayz = new int[9]; arrayz = array;

                    //xtest

                    for (int k = 0; k < 9; k++)
                        for (int p = 0; p < y; p++)
                            if (arrayx[k] == _array[i, p])
                                arrayx[k] = 0;

                    //ytest

                    for (int k = 0; k < 9; k++)
                        for (int p = 0; p < i; p++)
                            if (arrayy[k] == _array[p, y])
                                arrayy[k] = 0;

                    //btest

                    {
                        int ii = i;
                        int yy = y;
                        ii = ii - (ii % 3);
                        yy = yy - (yy % 3);

                        for (int k = 0; k < 9; k++)
                            for (int p = ii; p < (ii + 3 - (i % 3)); p++)
                            {
                                for (int z = yy; z < (yy + 3 - (y % 3)); z++)
                                {
                                    if ((z >= y) && (p >= i)) break;

                                    if (arrayz[k] == _array[p, z])
                                        arrayz[k] = 0;
                                   
                                }
                                
                            }
                    }
                    for (int k = 0; k < 9; k++)
                        if ((arrayz[k] == arrayx[k]) && (arrayz[k] == arrayy[k]) && (arrayx[k] == arrayy[k]) && (arrayx[k] != 0))
                        {
                            _array[i, y] = array[k];
                            break;
                        }
                }
            }
            print(_array);
        }

        private int[] test1(int[] array)
        {
            return array;
        }

        private int[] test2(int[] array)
        {
            return array;
        }

        private int[] test3(int[] array)
        {
            return array;
        }

        public void print(int[,] a)
        {
            for (int i = 0; i < 9; i++)
            {
                for (int x = 0; x < 9; x++)
                {
                    Console.Write(" "); Console.Write(a[i,x].ToString());
                }
                Console.WriteLine();
            }
        }
    }
}
