namespace AssetTool
{
    [JsonAsset("PCGUserParameterGetSettings")]
    public class UPCGUserParameterGetSettings : UPCGSettings
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("PCGGenericUserParameterGetSettings")]
    public class UPCGGenericUserParameterGetSettings : UPCGSettings
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}