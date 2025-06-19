namespace AssetTool
{
    [JsonAsset("AutoReimportManager")]
    public class UAutoReimportManager : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}