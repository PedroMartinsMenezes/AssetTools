namespace AssetTool
{
    [JsonAsset("FractureUniformSettings")]
    public class UFractureUniformSettings : UFractureToolSettings
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("FractureToolUniform")]
    public class UFractureToolUniform : UFractureToolVoronoiCutterBase
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}