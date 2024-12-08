namespace AssetTool
{
    [JsonAsset("PointLight")]
    public class APointLight : ALight
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}