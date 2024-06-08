namespace AssetTool
{
    public class FPlane : FVector3d
    {
        public double W;

        public override FVector3d Move(Transfer transfer)
        {
            transfer.Move(ref W);
            return this;
        }
    }
}
