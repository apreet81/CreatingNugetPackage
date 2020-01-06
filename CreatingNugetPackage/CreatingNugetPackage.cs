using System;
using System.Collections.Generic;

namespace CreatingNugetPackage
{
    public class CreatingNugetPackage
    {
        public static T PlusGrandePlace2<T, U>(IEnumerable<T> collection, Func<T, U> criteria) where U : IComparable
        {
            T result = default(T);
            U valeuPlusGrande = default(U);
            foreach (T item in collection)
            {
                if (criteria(item).CompareTo(valeuPlusGrande) > 0)
                {
                    valeuPlusGrande = criteria(item);
                    result = item;
                }
            }
            return result;
        }

        // After this from project setting in Build tab update configuration to release and from Package tab
        // fill required fields and also check Generate nuget package on build.
    }
}
