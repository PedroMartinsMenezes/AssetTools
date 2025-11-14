namespace AssetTool
{
    [JsonAsset("PCGDataAttributesAndTagsSettingsBase")]
    public class UPCGDataAttributesAndTagsSettingsBase : UPCGSettings
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("PCGDataAttributesToTagsSettings")]
    public class UPCGDataAttributesToTagsSettings : UPCGDataAttributesAndTagsSettingsBase
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("PCGTagsToDataAttributesSettings")]
    public class UPCGTagsToDataAttributesSettings : UPCGDataAttributesAndTagsSettingsBase
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}