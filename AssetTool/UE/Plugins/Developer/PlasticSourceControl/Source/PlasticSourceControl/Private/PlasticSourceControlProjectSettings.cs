namespace AssetTool
{
    [JsonAsset("PlasticSourceControlProjectSettings")]
    public class UPlasticSourceControlProjectSettings : UDeveloperSettings
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}