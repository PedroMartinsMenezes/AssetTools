namespace AssetTool
{
    [JsonAsset("FracturePlaneCutSettings")]
    public class UFracturePlaneCutSettings : UFractureToolSettings
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("FractureToolPlaneCut")]
    public class UFractureToolPlaneCut : UFractureToolCutterBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}