namespace AssetTool
{
    [JsonAsset("ActorElementsCopy")]
    public class UActorElementsCopy : UObject
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("ActorElementsExporterT3D")]
    public class UActorElementsExporterT3D : UExporter
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}