namespace AssetTool
{
    [JsonAsset("GroundTruthData")]
    public class UGroundTruthData : UObject
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}