namespace AssetTool
{
    [JsonAsset("SpotLight")]
    public class ASpotLight : ALight
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}