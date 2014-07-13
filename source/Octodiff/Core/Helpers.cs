using System;
using System.Collections;
using System.Collections.Generic;

namespace Octodiff.Core
{
    internal static class Helpers
    {
        public static bool IsNullOrWhiteSpace(String value)
        {
            if (value == null) return true;

            for (int i = 0; i < value.Length; i++)
            {
                if (!Char.IsWhiteSpace(value[i])) return false;
            }

            return true;
        }

        public static bool ArraysEqual<T>(T[] first, T[] second)
        {
            if (first == second)
            {
                return true;
            }
            if (first == null || second == null)
            {
                return false;
            }
            if (first.Length != second.Length)
            {
                return false;
            }
            IEqualityComparer comparer = EqualityComparer<T>.Default;
            for (int i = 0; i < first.Length; i++)
            {
                if (!comparer.Equals(first[i], second[i]))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
