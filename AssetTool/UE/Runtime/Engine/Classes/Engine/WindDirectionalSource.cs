namespace AssetTool
{
    [JsonAsset("WindDirectionalSource")]
    public class AWindDirectionalSource : AInfo
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}