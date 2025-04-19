/*
using System;
using System.Collections.Generic;
using System.IO;


namespace ConsoleApp6
{
    class coding
    {

        static void Print(int[,] image)
        {

            for (int i = 0; i < image.GetLength(0); i++)
            {
                for (int j = 0; j < image.GetLength(1); j++)
                {
                    Console.Write(image[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {


            var reader = new StreamReader("input_s1_01.txt");
            
            var sizes = reader.ReadLine().Split();
            int w = int.Parse(sizes[0]);
            int h = int.Parse(sizes[1]);

            int[,] image = new int[h, w];   

            var firstLine = reader.ReadLine();

            if (firstLine != "Z")
            {
                for (int i = 0; i < h; i++)
                {
                    for (int j = 0; j < w; j++)
                    {
                        image[i,j] = int.Parse(firstLine);
                    }
                }
            }
            
            else
            {
                var imageParts = new Queue<int[]>();

                imageParts.Enqueue(new int []{0, 0, w, h});

                while (imageParts.Count != 0)
                {
                    var currPart = imageParts.Dequeue();

                    int x_lt = currPart[0];
                    int y_lt = currPart[1];

                    int w_curr = currPart[2];
                    int h_curr = currPart[3];

                    int w_new = ( w_curr +1) / 2;
                    int h_new = (h_curr + 1)/ 2;

                    int[][] currParts = { new int []{x_lt, y_lt, w_new, h_new},
                        new int []{x_lt + w_new, y_lt, w_curr-w_new, h_new },
                        new int []{x_lt, y_lt + h_new, w_new, h_curr - h_new },
                        new int []{x_lt + w_new,y_lt + h_new,w_curr-w_new, h_curr - h_new }
                    };

                    var currLine = reader.ReadLine().Split();


                    for (int i = 0; i < 4; i++)
                    {
                        
                        if (currLine[i] == "Z") imageParts.Enqueue(currParts[i]);
                        else if (currLine[i] == "-") continue;
                        else
                        {
                            int x_painted = currParts[i][0];
                            int y_painted = currParts[i][1];

                            int w_painted = currParts[i][2];
                            int h_painted = currParts[i][3];

                            for (int j = x_painted; j < x_painted + w_painted; j++)
                            {
                                for (int k = y_painted; k < y_painted + h_painted; k++)
                                {
                                    image[k,j] = int.Parse(currLine[i]);
                                }
                            }
                        }
                    }

                }
               
            }

            Print(image);

        }
    }
}
*/