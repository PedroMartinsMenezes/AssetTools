namespace AssetTool
{
    [JsonAsset("GroundTruthData")]
    public class UGroundTruthData : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}