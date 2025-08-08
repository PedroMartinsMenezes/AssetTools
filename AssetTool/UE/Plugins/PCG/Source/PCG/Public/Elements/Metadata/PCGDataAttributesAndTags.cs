namespace AssetTool
{
    [JsonAsset("PCGDataAttributesAndTagsSettingsBase")]
    public class UPCGDataAttributesAndTagsSettingsBase : UPCGSettings
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("PCGDataAttributesToTagsSettings")]
    public class UPCGDataAttributesToTagsSettings : UPCGDataAttributesAndTagsSettingsBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("PCGTagsToDataAttributesSettings")]
    public class UPCGTagsToDataAttributesSettings : UPCGDataAttributesAndTagsSettingsBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}