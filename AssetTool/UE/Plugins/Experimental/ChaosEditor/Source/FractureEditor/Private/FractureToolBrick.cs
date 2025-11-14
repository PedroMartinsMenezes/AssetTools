namespace AssetTool
{
    [JsonAsset("FractureBrickSettings")]
    public class UFractureBrickSettings : UFractureToolSettings
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("FractureToolBrick")]
    public class UFractureToolBrick : UFractureToolCutterBase
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}