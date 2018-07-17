﻿using System;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace BignumArithmetics.Tests
{
    [TestClass]
    public class BigFLoatOperationsTests
    {
        public enum Operation { sum, sub, mul, div, mod }
        public static Random rnd = new Random((int)DateTime.Now.Ticks);
        public static void DoOperationTesting(string left, string right, string result, Operation op)
        {
            BigFloat A = BigFloat.CreateFromString(left);
            BigFloat B = BigFloat.CreateFromString(right);

            BigFloat C;
            switch (op)
            {
                case Operation.sum:
                    C = A + B;
                    break;
                case Operation.sub:
                    C = A + B;
                    break;
                case Operation.mul:
                    C = A + B;
                    break;
                case Operation.div:
                    C = A + B;
                    break;
                case Operation.mod:
                    C = A + B;
                    break;
                default:
                    C = new BigFloat();
                    break;
            }
            Assert.AreEqual(C.ToString(), result);
        }
        public static string DecimalToString(decimal number)
        {
            string str = number.ToString();
            if (!str.Contains(","))
                return str;
            str = str.Replace(",", ".");
            StringBuilder sb = new StringBuilder(str);
            while (sb[sb.Length - 1] == '0')
                sb.Remove(sb.Length - 1, 1);
            if (sb[sb.Length - 1] == '.')
                sb.Remove(sb.Length - 1, 1);
            return sb.ToString();
        }
        /*static void Test()
        {
            int a = BFTestingTools.rnd.Next(0, Int32.MaxValue);
            int b = BFTestingTools.rnd.Next(0, Int32.MaxValue);
            a -= Int32.MaxValue / 2;
            b -= Int32.MaxValue / 2;
            decimal A = a;
            decimal B = b;
            A /= 10000;
            B /= 100000;
            decimal C = A + B;
            decimal D = A - B;
            decimal E = A * B;

            DoTesting(DecimalToString(A),
                    DecimalToString(B),
                    DecimalToString(C),
                    DecimalToString(D),
                    DecimalToString(E));
        }

        [TestMethod]
        public void Zero_Zero()
        {
            DoTesting("0", "0", "0", "0", "0");
        }
        [TestMethod]
        public void Zero_m5()
        {
            DoTesting("0", "-5", "-5", "5", "0");
        }
        [TestMethod]
        public void m5_zero()
        {
            DoTesting("-5", "0", "-5", "-5", "0");
        }
        [TestMethod]
        public void m5_p6()
        {
            DoTesting("-5", "6", "1", "-11", "-30");
        }
        [TestMethod]
        public void p123D45_p45D678()
        {
            DoTesting("123.45", "45.678", "169.128", "77.772", "5638.9491");
        }
        [TestMethod]
        public void m3D1_p10D005()
        {
            DoTesting("-3.1", "10.005", "6.905", "-13.105", "-31.0155");
        }
        [TestMethod]
        public void m10D005_m3D1()
        {
            DoTesting("-10.005", "-3.1", "-13.105", "-6.905", "31.0155");
        }
        [TestMethod]
        public void random_10000_tests()
        {
            for (int i = 0; i < 10000; i++)
                Test();
        }*/
    }
}
