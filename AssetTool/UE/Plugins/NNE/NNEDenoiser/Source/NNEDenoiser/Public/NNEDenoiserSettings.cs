namespace AssetTool
{
    [JsonAsset("NNEDenoiserSettings")]
    public class UNNEDenoiserSettings : UDeveloperSettingsBackedByCVars
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}