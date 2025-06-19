namespace AssetTool
{
    [JsonAsset("ActorElementsCopy")]
    public class UActorElementsCopy : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("ActorElementsExporterT3D")]
    public class UActorElementsExporterT3D : UExporter
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}