namespace AssetTool
{
    [JsonAsset("CreateActorSampleToolBuilder")]
    public class UCreateActorSampleToolBuilder : UInteractiveToolBuilder
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("CreateActorSampleToolProperties")]
    public class UCreateActorSampleToolProperties : UInteractiveToolPropertySet
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("CreateActorSampleTool")]
    public class UCreateActorSampleTool : USingleClickTool
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}