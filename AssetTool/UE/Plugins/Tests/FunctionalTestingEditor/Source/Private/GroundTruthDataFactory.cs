namespace AssetTool
{
    [JsonAsset("GroundTruthDataFactory")]
    public class UGroundTruthDataFactory : UFactory
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}