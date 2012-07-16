/*
Math.NETのStatistics(統計)のサンプル
MathNet.Numerics.Statistics.Statistics
(http://api.mathdotnet.com/Numerics/MathNet.Numerics.Statistics/Statistics.htm)

Author : Tadahiro Ishisaka (ishisaka@gmail.com)

The MIT License

Copyright (c) 2012 Tadahiro Ishisaka

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in
all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
THE SOFTWARE.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MathNet.Numerics.Statistics;
using System.Diagnostics;

namespace MathNetStatisticsSample
{
    class Program
    {
        static void Main(string[] args) {
            var sw = new Stopwatch();
            var rnd = new System.Random();
            double[] data = new double[10000000];

            int i;
            for (i = 0; i < 10000000; i++) {
                data[i] = rnd.NextDouble();
                //Console.Write(data[i] + ",");
            }
            //標本標準偏差
            sw.Start();
            var stddiv = Statistics.StandardDeviation(data);
            sw.Stop();
            Console.WriteLine("Standard Deviation = {0}", stddiv);
            Console.WriteLine("{1}件入力で標本標準偏差の計算時間: {0}", sw.Elapsed, i);
            //母標準偏差
            sw.Reset();
            sw.Start();
            var pstddiv = Statistics.PopulationStandardDeviation(data);
            sw.Stop();
            Console.WriteLine("Population Standard Deviation = {0}", pstddiv);
            Console.WriteLine("{1}件入力で母標準偏差の計算時間: {0}", sw.Elapsed, i);
            //標本分散
            var variance = Statistics.Variance(data);
            Console.WriteLine("Variance = {0}", variance);
            //母分散
            var pVariance = Statistics.PopulationVariance(data);
            Console.WriteLine("Population Variance = {0}", pVariance);
            //最大値・最小値
            var max = Statistics.Maximum(data);
            Console.WriteLine("Maximum = {0}", max);
            var min = Statistics.Minimum(data);
            Console.WriteLine("Minimum = {0}", min);
            //平均
            var mean = Statistics.Mean(data);
            Console.WriteLine("Mean = {0}", mean);
            //メジアン(中央値)
            var median = Statistics.Median(data);
            Console.WriteLine("Median = {0}", median);
            //順序統計量
            var orderStatistic = Statistics.OrderStatistic(data, 123);
            Console.WriteLine("Order Statisitc(i-Order = 123) = {0}", orderStatistic);

            Console.ReadLine();

        }
    }
}
