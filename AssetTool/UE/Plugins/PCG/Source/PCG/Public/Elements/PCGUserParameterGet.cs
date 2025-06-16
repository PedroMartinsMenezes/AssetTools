namespace AssetTool
{
    [JsonAsset("PCGUserParameterGetSettings")]
    public class UPCGUserParameterGetSettings : UPCGSettings
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("PCGGenericUserParameterGetSettings")]
    public class UPCGGenericUserParameterGetSettings : UPCGSettings
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}