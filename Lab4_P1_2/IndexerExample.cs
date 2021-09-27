namespace Lab4_P1_2
{
    public class IndexerExample
    {
        public int[] intList = new int[10];
        public int this[int index]
        {
            get{return intList[index];}
            set{intList[index] = value;}
        }
    }
}