namespace AssetTool
{
    [JsonAsset("CEClonerEffectorSettings")]
    public class UCEClonerEffectorSettings : UDeveloperSettings
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}