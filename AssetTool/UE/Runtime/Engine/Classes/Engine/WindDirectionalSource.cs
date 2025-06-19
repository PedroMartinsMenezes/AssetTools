namespace AssetTool
{
    [JsonAsset("WindDirectionalSource")]
    public class AWindDirectionalSource : AInfo
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}