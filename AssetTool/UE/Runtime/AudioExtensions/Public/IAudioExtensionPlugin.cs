namespace AssetTool
{
    [JsonAsset("SpatializationPluginSourceSettingsBase")]
    public class USpatializationPluginSourceSettingsBase : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("SourceDataOverridePluginSourceSettingsBase")]
    public class USourceDataOverridePluginSourceSettingsBase : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("OcclusionPluginSourceSettingsBase")]
    public class UOcclusionPluginSourceSettingsBase : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("ReverbPluginSourceSettingsBase")]
    public class UReverbPluginSourceSettingsBase : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}