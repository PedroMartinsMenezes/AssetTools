namespace AssetTool
{
    [JsonAsset("OptimusSettings")]
    public class UOptimusSettings : UDeveloperSettings
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}