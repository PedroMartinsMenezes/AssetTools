namespace AssetTool
{
    [JsonAsset("ActorExporterT3D")]
    public class UActorExporterT3D : UExporter
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("GroupActorExporterT3D")]
    public class UGroupActorExporterT3D : UActorExporterT3D
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("PhysicsVolumeExporterT3D")]
    public class UPhysicsVolumeExporterT3D : UActorExporterT3D
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}