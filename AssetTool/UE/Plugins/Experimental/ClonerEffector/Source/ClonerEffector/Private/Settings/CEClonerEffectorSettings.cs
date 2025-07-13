namespace AssetTool
{
    [JsonAsset("CEClonerEffectorSettings")]
    public class UCEClonerEffectorSettings : UDeveloperSettings
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}