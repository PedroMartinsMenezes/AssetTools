namespace AssetTool
{
    public class FPlane : FVector
    {
        public double W;

        public override ITransferible Move(Transfer transfer)
        {
            base.Move(transfer);
            if (Supports.LARGE_WORLD_COORDINATES)
            {
                transfer.Move(ref W);
            }
            else
            {
                W = transfer.Move((float)W);
            }
            return this;
        }
    }
}
