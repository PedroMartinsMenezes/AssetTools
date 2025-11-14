namespace AssetTool
{
    [JsonAsset("MediaBundle")]
    public class UMediaBundle : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}