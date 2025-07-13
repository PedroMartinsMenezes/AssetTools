namespace AssetTool
{
    [JsonAsset("FractureSelectionSettings")]
    public class UFractureSelectionSettings : UFractureToolSettings
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("RectangleMarqueeManager")]
    public class URectangleMarqueeManager : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("FractureToolSelection")]
    public class UFractureToolSelection : UFractureToolCutterBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}