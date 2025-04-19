/*
using System;
using System.Collections.Generic;
using System.IO;


namespace ConsoleApp6
{
   
    class rgr3
    {
        static void Main(string[] args)
        {

            var reader = new StreamReader("input_s1_01.txt");



            var sizes = reader.ReadLine().Split();


            int w = int.Parse(sizes[0]);
            int h = int.Parse(sizes[1]);
            var imageParts = new Queue<int[]>();

            int[,] image = new int[h,w];
            bool isSimple = true;
            List<string> codeOfImage = new List<string>();

            codeOfImage.Add($"{w} {h}");

            for (int i = 0; i < h; i++)
            {
                var currStr = reader.ReadLine().Split();
                for (int j = 0; j < w; j++)
                {
                    image[i, j] = int.Parse(currStr[j]);

                    if (image[i, j] != image[0, 0])
                    {
                        isSimple = false;
                    }
                }
            }
            if (isSimple)
            {
                codeOfImage.Add("C");
            }
            else
            {
                imageParts.Enqueue(new int[] { 0, 0, w, h });

                while (imageParts.Count != 0)
                {
                    string[] currStr = new string[4];

                    var currPart = imageParts.Dequeue();
                    int x_lt = currPart[0];
                    int y_lt = currPart[1];

                    int w_curr = currPart[2];
                    int h_curr = currPart[3];

                    int w_new = (w_curr + 1) / 2;
                    int h_new = (h_curr + 1) / 2;

                    int[][] currParts = { new int []{x_lt, y_lt, w_new, h_new},
                        new int []{x_lt + w_new, y_lt, w_curr-w_new, h_new },
                        new int []{x_lt, y_lt + h_new, w_new, h_curr - h_new },
                        new int []{x_lt + w_new,y_lt + h_new,w_curr-w_new, h_curr - h_new }
                    };



                    for (int i = 0; i < 4; i++)
                    {
                        
                        isSimple = true;
                        int currX = currParts[i][0];
                        int currY = currParts[i][1];

                        int delta_x = currParts[i][2];
                        int delta_y = currParts[i][3];

                        if (delta_x == 0 || delta_y == 0)
                        {
                            currStr[i] = "-";
                            continue;
                        }
                        for (int j = currY; j < currY + delta_y && isSimple; j++)
                        {
                            for (int k = currX; k < currX + delta_x; k++)
                            {
                                if (image[currY, currX] != image[j, k])
                                {
                                    isSimple = false;
                                    imageParts.Enqueue(currParts[i]);
                                    break;
                                }
                            }
                        }
                        currStr[i] = isSimple ? image[currY, currX].ToString() : "Z";
                    }


                    codeOfImage.Add(string.Join(" ",currStr));
                }
            }

            for (int i = 0; i < codeOfImage.Count; i++)
            {
                Console.WriteLine(codeOfImage[i]);
            }


        }
    }
}
*/