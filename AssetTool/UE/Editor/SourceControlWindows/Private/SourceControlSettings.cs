namespace AssetTool
{
    [JsonAsset("SourceControlSettings")]
    public class USourceControlSettings : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}