/*
Math.NETのSystemRandomExtensionsクラスの拡張メソッドを使ってInt64の乱数値を得るサンプル
MathNet.Numerics.Random.SystemRandomExtensions 
(http://api.mathdotnet.com/Numerics/MathNet.Numerics.Random/SystemRandomExtensions.htm)

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
using MathNet.Numerics.Random;

namespace SystemRundomExtensionsSample
{
    class Program
    {
        static void Main(string[] args) {
            var rnd = new System.Random();
            for (int i = 0; i < 100; i++) {
                //追加された拡張メソッドでInt64の乱数を得ることが出来る
                var longRnd = rnd.NextFullRangeInt64();
                Console.WriteLine("{0}", longRnd);
            }
            Console.Write("\r\n何か入力してください");
            Console.Read();
        }
    }
}
