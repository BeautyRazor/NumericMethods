﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NumericMethods.Methods;
using NumericMethods.Objects;

namespace Lab9
{
    class Program {
        private const int STUDENT_NUMBER = 8;
        private const int GROUP_NUMBER = 1;

        static void Main(string[] args) {
            var data = GenerateArray(STUDENT_NUMBER, GROUP_NUMBER);
            var lagrange = LagrangePolynomial.Calculate(data[0], data[1]);

            Console.WriteLine("Points (x/y): ");
            var points_x = new VectorRow(data[0]);
            var points_y = new VectorRow(data[1]);

            points_x.Print();
            points_y.Print();
            Console.Write("L(x) = ");
            lagrange.Print();
            lagrange.FindDerivative().FindDerivative().Print();

            Console.WriteLine("\nCheck: ");
            for (int i = 0; i < data[0].Length; i++)
                Console.WriteLine("L({0}) = {1}", data[0][i], lagrange.Calculate(data[0][i]));
            Console.Read();

        }

        private static double[][] GenerateArray(int N, int k) {
            return new double[2][] {
                new double[] {3.5,   4.1,     4.3,   5},
                new double[] {N + k, N + 2*k, N - k, N}
            };
        }
    }
}
