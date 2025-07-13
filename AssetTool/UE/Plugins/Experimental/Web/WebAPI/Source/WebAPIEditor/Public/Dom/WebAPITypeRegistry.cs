namespace AssetTool
{
    [JsonAsset("WebAPIStaticTypeRegistry")]
    public class UWebAPIStaticTypeRegistry : UEngineSubsystem
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("WebAPITypeRegistry")]
    public class UWebAPITypeRegistry : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}