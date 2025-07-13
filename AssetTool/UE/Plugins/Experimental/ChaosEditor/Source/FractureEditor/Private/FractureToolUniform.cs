namespace AssetTool
{
    [JsonAsset("FractureUniformSettings")]
    public class UFractureUniformSettings : UFractureToolSettings
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("FractureToolUniform")]
    public class UFractureToolUniform : UFractureToolVoronoiCutterBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}