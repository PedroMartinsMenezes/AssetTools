namespace AssetTool
{
    [JsonAsset("FractureCutterSettings")]
    public class UFractureCutterSettings : UFractureToolSettings
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("FractureCollisionSettings")]
    public class UFractureCollisionSettings : UFractureToolSettings
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("FractureToolCutterBase")]
    public class UFractureToolCutterBase : UFractureInteractiveTool
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("FractureToolVoronoiCutterBase")]
    public class UFractureToolVoronoiCutterBase : UFractureToolCutterBase
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("FractureTransformGizmoSettings")]
    public class UFractureTransformGizmoSettings : UFractureToolSettings
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}