namespace lab8
{
    public delegate void OverflowDelegat();
    class Pool
    {
        public int CurrentVolume { get; private set; }
        public int Height { get; }
        public int Width { get; }
        public int Length { get; }

        public event OverflowDelegat Overflowing = null;

        public Pool(int height, int width, int length)
        {
            Height = height;
            Width = width;
            Length = length;
        }

        public int CalculateVolume()
        {
            return Height * Width * Length;
        }

        public void EventDelegate()
        {
            Overflowing.Invoke();
        }

        public void AddingWater(int volumeOfAddingWater, int MaxVolume)
        {
            CurrentVolume += volumeOfAddingWater;
            if (CurrentVolume > MaxVolume)
            {
                EventDelegate();
            }
        }

        public int DrainWater(int currentVolume, int volumeOfDrainedWater)
        {
            currentVolume -= volumeOfDrainedWater;
            return currentVolume;
        }
    }
}
