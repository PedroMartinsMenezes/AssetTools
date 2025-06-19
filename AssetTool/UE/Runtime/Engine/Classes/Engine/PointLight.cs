namespace AssetTool
{
    [JsonAsset("PointLight")]
    public class APointLight : ALight
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}