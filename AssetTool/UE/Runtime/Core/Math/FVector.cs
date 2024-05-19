namespace AssetTool
{
    public class FVector
    {
        public double X;
        public double Y;
        public double Z;

        public virtual FVector Move(Transfer transfer)
        {
            transfer.Move(ref X);
            transfer.Move(ref Y);
            transfer.Move(ref Z);
            return this;
        }
    }
}
