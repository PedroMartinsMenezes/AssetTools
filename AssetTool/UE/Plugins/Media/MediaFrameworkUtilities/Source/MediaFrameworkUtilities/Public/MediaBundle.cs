namespace AssetTool
{
    [JsonAsset("MediaBundle")]
    public class UMediaBundle : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}