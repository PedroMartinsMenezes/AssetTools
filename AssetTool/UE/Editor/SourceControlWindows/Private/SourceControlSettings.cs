namespace AssetTool
{
    [JsonAsset("SourceControlSettings")]
    public class USourceControlSettings : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}