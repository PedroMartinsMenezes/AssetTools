namespace AssetTool
{
    [JsonAsset("FractureSelectionSettings")]
    public class UFractureSelectionSettings : UFractureToolSettings
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("RectangleMarqueeManager")]
    public class URectangleMarqueeManager : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("FractureToolSelection")]
    public class UFractureToolSelection : UFractureToolCutterBase
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}