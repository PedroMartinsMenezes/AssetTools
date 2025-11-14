namespace AssetTool
{
    [JsonAsset("VehicleDefaultInputProducer")]
    public class UVehicleDefaultInputProducer : UVehicleInputProducerBase
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("VehiclePlaybackInputProducer")]
    public class UVehiclePlaybackInputProducer : UVehicleInputProducerBase
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("VehicleRandomInputProducer")]
    public class UVehicleRandomInputProducer : UVehicleInputProducerBase
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}