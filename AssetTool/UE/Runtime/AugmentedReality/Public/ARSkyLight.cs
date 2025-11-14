namespace AssetTool
{
    [JsonAsset("ARSkyLight")]
    public class AARSkyLight : ASkyLight
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}