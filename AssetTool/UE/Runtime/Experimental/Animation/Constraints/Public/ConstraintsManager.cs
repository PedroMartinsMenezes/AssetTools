namespace AssetTool
{
    [JsonAsset("TickableConstraint")]
    public class UTickableConstraint : UObject
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("ConstraintsManager")]
    public class UConstraintsManager : UObject
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}