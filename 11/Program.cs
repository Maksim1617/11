using System;
using System.Collections;
using System.Globalization;
using System.Text;

namespace Test
{
    class Program
    {


        static void Main(string[] args)
        {
            Console.WriteLine("Введите цифру 1 для того чтоби закодировать число \nВведите цифру 2 чтобы декодировать число \nВведите 3 чтобы выйти");
            int a = Convert.ToInt32(Console.ReadLine());
            int[] row = new int[7];
            BitArray result = new BitArray(8); //{ 0, 0, 0, 0, 0, 0, 0, 0 };
            BitArray result1 = new BitArray(8); //{ 0, 0, 0, 0, 0, 0, 0, 0 };
            int counter = 0;
            BitArray row0 = new BitArray(8);// { 1, 1, 1, 0, 1, 0, 0, 0 };
            row0[0] = true; row0[1] = true; row0[2] = true; row0[3] = false; row0[4] = true; row0[5] = false; row0[6] = false; row0[7] = false; // { 1, 1, 1, 0, 1, 0, 0, 0 };
            BitArray row1 = new BitArray(8); //{ 0, 1, 1, 1, 0, 1, 0, 0 };
            row1[0] = false; row1[1] = true; row1[2] = true; row1[3] = true; row1[4] = false; row1[5] = true; row1[6] = false; row1[7] = false; //{ 0, 1, 1, 1, 0, 1, 0, 0 };
            BitArray row2 = new BitArray(8); //{ 0, 0, 1, 1, 1, 0, 1, 0 };
            row2[0] = false; row2[1] = false; row2[2] = true; row2[3] = true; row2[4] = true; row2[5] = false; row2[6] = true; row2[7] = false; //{ 0, 0, 1, 1, 1, 0, 1, 0 };
            BitArray row3 = new BitArray(8); //{ 0, 0, 0, 1, 1, 1, 0, 1 };
            row3[0] = false; row3[1] = false; row3[2] = false; row3[3] = true; row3[4] = true; row3[5] = true; row3[6] = false; row3[7] = true; //{ 0, 0, 0, 1, 1, 1, 0, 1 };
            BitArray row4 = new BitArray(8); //{ 1, 1, 1, 0, 0, 1, 1, 0 };
            row4[0] = true; row4[1] = true; row4[2] = true; row4[3] = false; row4[4] = false; row4[5] = true; row4[6] = true; row4[7] = false; //{ 1, 1, 1, 0, 0, 1, 1, 0 };
            BitArray row5 = new BitArray(8); //{ 0, 1, 1, 1, 0, 0, 1, 1 };
            row5[0] = false; row5[1] = true; row5[2] = true; row5[3] = true; row5[4] = false; row5[5] = false; row5[6] = true; row5[7] = true; //{ 0, 1, 1, 1, 0, 0, 1, 1 };
            BitArray row6 = new BitArray(8); //{ 1, 1, 0, 1, 0, 0, 0, 1 };
            row6[0] = true; row6[1] = true; row6[2] = false; row6[3] = true; row6[4] = false; row6[5] = false; row6[6] = false; row6[7] = true;
            BitArray res = new BitArray(15);
            BitArray pol = new BitArray(7); //{ 1, 0, 1, 1, 0, 1, 1 };
            pol[0] = true; pol[1] = false; pol[2] = true; pol[3] = true; pol[4] = false; pol[5] = true; pol[6] = true;

            for (int n = 0; n < 7; n++)
            {
                if (pol[n] == true)
                {
                    row[n] = 1;
                    counter++;
                }
                if (pol[n] == false)
                {
                    row[n] = 0;
                }
            }

            for (int c = 0; c < counter; c++)
            {
                if (row[0] == 1)
                {
                    for (int i = 0; i < 8; i++)
                    {
                        result[i] ^= row0[i];
                    }
                }
                if (row[1] == 1)
                {
                    for (int i = 0; i < 8; i++)
                    {
                        result[i] ^= row1[i];
                    }
                }
                if (row[2] == 1)
                {
                    for (int i = 0; i < 8; i++)
                    {
                        result[i] ^= row2[i];
                    }
                }
                if (row[3] == 1)
                {
                    for (int i = 0; i < 8; i++)
                    {
                        result[i] ^= row3[i];
                    }
                }
                if (row[4] == 1)
                {
                    for (int i = 0; i < 8; i++)
                    {
                        result[i] ^= row4[i];
                    }
                }
                if (row[5] == 1)
                {
                    for (int i = 0; i < 8; i++)
                    {
                        result[i] ^= row5[i];
                    }
                }
                if (row[6] == 1)
                {
                    for (int i = 0; i < 8; i++)
                    {
                        result[i] ^= row6[i];
                    }
                }
            }

            for (int i = 0; i <= 6; i++)
            {
                res[i] = pol[i];
            }
            for (int i = 0; i < 8; i++)
            {
                res[i + 7] = result[i];
            }

            switch (a)
            {
                case 1:



                    for (int l = 0; l < 15; l++)
                    {
                        Console.Write(res[l]);
                    }

                    break;

                case 2:

                    for (int i = 0; i < 8; i++)
                    {
                        result1[i] = result[i];
                    }
                    for (int i = 0; i < 8; i++)
                    {
                        if (result1[i] ^ result[i] == false)
                        {
                            result1[i] = false;
                        }
                        else
                        {
                            result1[i] = true;
                        }
                    }
                    for (int l = 0; l < 8; l++)
                    {
                        Console.Write(result1[l]);
                    }

                    break;

                default:
                    break;
            }
        }
    }
}