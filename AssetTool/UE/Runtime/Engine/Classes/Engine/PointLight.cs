namespace AssetTool
{
    [JsonAsset("PointLight")]
    public class APointLight : ALight
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}