namespace AssetTool
{
    [JsonAsset("FractureRecomputeNormalsSettings")]
    public class UFractureRecomputeNormalsSettings : UFractureToolSettings
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("FractureToolRecomputeNormals")]
    public class UFractureToolRecomputeNormals : UFractureToolCutterBase
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}