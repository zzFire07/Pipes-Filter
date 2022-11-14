namespace CompAndDel
{
    public class ConvultionType
    {
        public int[,] kernelarray;
        public int kernel;
        public int divider;
        public int complement;

        public ConvultionType (int kernel, int divider, int complement)
        {
            this.kernel = kernel;
            this.divider = divider;
            this.complement = complement;
            kernelarray = new int[kernel,kernel];
        }
    }
}