using System.Collections.Generic;

namespace SortClassNamespace
{
    class SortClass
    {
        
        static public List<int> SortStatic(List<int> arr)   //static method of sorting
        {
            arr.Sort();
            return arr;
        }

        public List<int> SortDynamic(List<int> arr) //dynamic method of sorting
        {
            arr.Sort();
            return arr;
        }
    }
}
