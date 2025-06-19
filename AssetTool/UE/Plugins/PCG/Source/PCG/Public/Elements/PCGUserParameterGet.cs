namespace AssetTool
{
    [JsonAsset("PCGUserParameterGetSettings")]
    public class UPCGUserParameterGetSettings : UPCGSettings
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("PCGGenericUserParameterGetSettings")]
    public class UPCGGenericUserParameterGetSettings : UPCGSettings
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}