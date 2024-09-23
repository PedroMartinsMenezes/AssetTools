namespace AssetTool
{
    public class FPlane : FVector3d
    {
        public double W;

        public override ITransferible Move(Transfer transfer)
        {
            transfer.Move(ref W);
            return this;
        }
    }
}
