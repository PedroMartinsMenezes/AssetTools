namespace AssetTool
{
    [JsonAsset("FractureInitialDynamicStateSettings")]
    public class UFractureInitialDynamicStateSettings : UFractureToolSettings
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("FractureToolSetInitialDynamicState")]
    public class UFractureToolSetInitialDynamicState : UFractureModalTool
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("FractureRemoveOnBreakSettings")]
    public class UFractureRemoveOnBreakSettings : UFractureToolSettings
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("FractureToolSetRemoveOnBreak")]
    public class UFractureToolSetRemoveOnBreak : UFractureModalTool
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}