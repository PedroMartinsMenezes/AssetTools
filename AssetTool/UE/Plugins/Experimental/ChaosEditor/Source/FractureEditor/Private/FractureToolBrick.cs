namespace AssetTool
{
    [JsonAsset("FractureBrickSettings")]
    public class UFractureBrickSettings : UFractureToolSettings
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("FractureToolBrick")]
    public class UFractureToolBrick : UFractureToolCutterBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}