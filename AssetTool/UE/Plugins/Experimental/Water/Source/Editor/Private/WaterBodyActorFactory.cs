namespace AssetTool
{
    [JsonAsset("WaterBodyActorFactory")]
    public class UWaterBodyActorFactory : UActorFactory
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("WaterBodyRiverActorFactory")]
    public class UWaterBodyRiverActorFactory : UWaterBodyActorFactory
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("WaterBodyOceanActorFactory")]
    public class UWaterBodyOceanActorFactory : UWaterBodyActorFactory
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("WaterBodyLakeActorFactory")]
    public class UWaterBodyLakeActorFactory : UWaterBodyActorFactory
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("WaterBodyCustomActorFactory")]
    public class UWaterBodyCustomActorFactory : UWaterBodyActorFactory
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}