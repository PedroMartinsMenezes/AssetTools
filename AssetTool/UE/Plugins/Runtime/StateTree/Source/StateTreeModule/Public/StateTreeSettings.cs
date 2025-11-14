namespace AssetTool
{
    [JsonAsset("StateTreeSettings")]
    public class UStateTreeSettings : UDeveloperSettings
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}