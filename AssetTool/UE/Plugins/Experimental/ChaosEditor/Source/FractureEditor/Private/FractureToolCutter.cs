namespace AssetTool
{
    [JsonAsset("FractureCutterSettings")]
    public class UFractureCutterSettings : UFractureToolSettings
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("FractureCollisionSettings")]
    public class UFractureCollisionSettings : UFractureToolSettings
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("FractureToolCutterBase")]
    public class UFractureToolCutterBase : UFractureInteractiveTool
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("FractureToolVoronoiCutterBase")]
    public class UFractureToolVoronoiCutterBase : UFractureToolCutterBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("FractureTransformGizmoSettings")]
    public class UFractureTransformGizmoSettings : UFractureToolSettings
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}