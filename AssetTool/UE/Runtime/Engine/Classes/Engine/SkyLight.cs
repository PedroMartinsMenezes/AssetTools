namespace AssetTool
{
    [JsonAsset("SkyLight")]
    public class ASkyLight : AInfo
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}