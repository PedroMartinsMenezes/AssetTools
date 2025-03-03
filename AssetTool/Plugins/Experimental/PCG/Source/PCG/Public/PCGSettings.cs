namespace AssetTool
{
    [JsonAsset("PCGSettingsInterface")]
    public class UPCGSettingsInterface : UPCGData
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("PCGSettings")]
    public class UPCGSettings : UPCGSettingsInterface
    {
        [Location("void UPCGSettings::Serialize(FArchive& Ar)")]
        public override UObject Move(Transfer transfer)
        {
            //TODO complete this
            return base.Move(transfer);
        }
    }

    [JsonAsset("PCGSettingsInstance")]
    public class UPCGSettingsInstance : UPCGSettingsInterface
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("PCGTrivialSettings")]
    public class UPCGTrivialSettings : UPCGSettings
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}