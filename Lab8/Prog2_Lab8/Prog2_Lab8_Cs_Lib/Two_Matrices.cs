using System;

namespace Prog2_Lab8_Cs_Lib
{
    public class Two_Matrices
    {
        private int[] A;
        private int[] B;

        public Two_Matrices(int[] A_in, int[] B_in)
        {
            A = A_in;
            B = B_in;
        }

        // Екземплярний метод
        public bool instance_matrix_comparitor(int i) { return A[i] == B[i]; }

        // Статичний метод
        public static bool static_matrix_comparitor(int[] A, int[] B, int i) { return A[i] == B[i]; }
    }
}
