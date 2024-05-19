namespace AssetTool
{
    public class FPlane : FVector
    {
        public double W;

        public override FVector Move(Transfer transfer)
        {
            transfer.Move(ref W);
            return this;
        }
    }
}
