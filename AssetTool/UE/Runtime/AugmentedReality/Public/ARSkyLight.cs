namespace AssetTool
{
    [JsonAsset("ARSkyLight")]
    public class AARSkyLight : ASkyLight
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}