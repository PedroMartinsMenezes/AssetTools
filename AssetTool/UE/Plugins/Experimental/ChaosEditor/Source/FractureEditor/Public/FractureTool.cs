namespace AssetTool
{
    [JsonAsset("FractureToolSettings")]
    public class UFractureToolSettings : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("FractureActionTool")]
    public class UFractureActionTool : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("FractureModalTool")]
    public class UFractureModalTool : UFractureActionTool
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("FractureInteractiveTool")]
    public class UFractureInteractiveTool : UFractureModalTool
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}