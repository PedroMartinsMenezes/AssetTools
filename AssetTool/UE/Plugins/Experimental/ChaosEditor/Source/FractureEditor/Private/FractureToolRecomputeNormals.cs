namespace AssetTool
{
    [JsonAsset("FractureRecomputeNormalsSettings")]
    public class UFractureRecomputeNormalsSettings : UFractureToolSettings
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("FractureToolRecomputeNormals")]
    public class UFractureToolRecomputeNormals : UFractureToolCutterBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}