namespace AssetTool
{
    [JsonAsset("FabSettings")]
    public class UFabSettings : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}