using System;

namespace Task3
{
    public class Pool
    {
        private double[] _size;  // Size of the pool
        private double _volumeOfPool;  // Volume of the pool(parallelepiped)
        private double _volumeOfWater;
        
        public Pool(double[] userSize)
        {
            if (userSize.Length == 3)  // Pool has 3 properties - width, length, depth
            {
                _size = userSize;
                _volumeOfPool = _size[0] * _size[1] * _size[2];
            }
            else
            { throw new ArgumentException("Wrong amount of sizes");}
        }
        // Create delegate for checking for overflow
        public delegate void OverflowHandler(string msg);
        private OverflowHandler _del; 
        public void RegisterHandler(OverflowHandler del) => _del = del;
        
        public void AddWater(double addWater)  // Add water to the pool
        {
            if (addWater > 0){ _volumeOfWater += addWater;}
            else{throw new ArgumentException("Wrong sign of amount of water to add");}
            if (_del != null)
            {
                if (_volumeOfPool < _volumeOfWater)  // Check for overflow
                { _del("The pool is overflowed");}
            }
        }
        public void DrainWater(double removeWater)  // Drain the pool
        {
            if (removeWater > 0)
            { _volumeOfWater -= removeWater;}
            else
            { _volumeOfWater += removeWater;}
        }

    }
}