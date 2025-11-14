namespace AssetTool
{
    [JsonAsset("ActorElementsCopy")]
    public class UActorElementsCopy : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("ActorElementsExporterT3D")]
    public class UActorElementsExporterT3D : UExporter
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}