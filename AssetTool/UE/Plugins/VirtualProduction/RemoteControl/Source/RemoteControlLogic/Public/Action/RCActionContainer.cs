namespace AssetTool
{
    [JsonAsset("RCActionContainer")]
    public class URCActionContainer : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}