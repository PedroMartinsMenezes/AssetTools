namespace AssetTool
{
    [JsonAsset("TickableConstraint")]
    public class UTickableConstraint : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("ConstraintsManager")]
    public class UConstraintsManager : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}