namespace AssetTool
{
    [JsonAsset("FractureProximitySettings")]
    public class UFractureProximitySettings : UFractureToolSettings
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("FractureProximityActions")]
    public class UFractureProximityActions : UFractureToolSettings
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("FractureToolProximity")]
    public class UFractureToolProximity : UFractureModalTool
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}