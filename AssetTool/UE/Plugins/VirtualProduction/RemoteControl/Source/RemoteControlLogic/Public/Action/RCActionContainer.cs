namespace AssetTool
{
    [JsonAsset("RCActionContainer")]
    public class URCActionContainer : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}