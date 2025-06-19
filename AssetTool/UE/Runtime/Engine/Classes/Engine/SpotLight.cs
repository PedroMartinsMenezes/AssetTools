namespace AssetTool
{
    [JsonAsset("SpotLight")]
    public class ASpotLight : ALight
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}