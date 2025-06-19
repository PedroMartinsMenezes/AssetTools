namespace AssetTool
{
    [JsonAsset("GroundTruthData")]
    public class UGroundTruthData : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}