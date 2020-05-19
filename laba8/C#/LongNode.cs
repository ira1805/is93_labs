namespace laba8
{
    public class LongNode
    {
        public long Node { get; set; }
        public LongNode Previous { get; set; }
        public LongNode Next { get; set; }

        public LongNode(long data) => Node = data;
    }
}