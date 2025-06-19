namespace AssetTool
{
    [JsonAsset("HLODProxy")]
    public class UHLODProxy : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}