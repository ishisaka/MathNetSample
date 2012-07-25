using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MathNet.Numerics.Statistics;

namespace MathNetStatisticsSample2
{
    class Program
    {
        static void Main(string[] args) {
            var rnd = new System.Random();
            double[] data = new double[10000000];

            int i;
            for (i = 0; i < 10000000; i++) {
                data[i] = rnd.NextDouble();
            }

            //宣言的に記述する
            Console.WriteLine("宣言的な記述をするためにDescriptiveStatisticsクラスを使用する。");
            
            var stat = new DescriptiveStatistics(data);　//重い！
            //標準偏差
            Console.WriteLine("Standard Deviation = {0}", stat.StandardDeviation);
            //平均
            Console.WriteLine("Mean = {0}", stat.Mean);
            //メジアン
            Console.WriteLine("Median = {0}", stat.Median);
            //分散
            Console.WriteLine("Variance = {0}", stat.Variance);
            //歪度
            Console.WriteLine("Skewness = {0}", stat.Skewness);
            //尖度
            Console.WriteLine("Kurtosis = {0}", stat.Kurtosis);

            //以上のようにDescriptiveStatisticsクラスはStatisticsとは1:1ではないので注意が必要

            //拡張メソッドを使用する
            Console.WriteLine("\r\nStatisticsクラスのメソッドを拡張メソッドとして使用する。");
            //標準偏差
            Console.WriteLine("Standard Deviation = {0}", data.StandardDeviation());
            //母標準偏差
            Console.WriteLine("Population Standard Deviation = {0}", data.PopulationStandardDeviation());
            //標本分散
            Console.WriteLine("Variance = {0}", data.Variance());
            //メジアン(中央値)
            Console.WriteLine("Median = {0}", data.Median());
            //順序統計量
            //Console.WriteLine("Order Statisitc(i-Order = 123) = {0}", data.OrderStatistic(123));
            //OrderStatisticは拡張メソッドに対応していない。

            Console.Write("何か入力してください...");
            Console.Read();
        }
    }
}
