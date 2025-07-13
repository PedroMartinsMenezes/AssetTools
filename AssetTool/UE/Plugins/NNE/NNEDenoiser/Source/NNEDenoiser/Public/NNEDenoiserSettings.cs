namespace AssetTool
{
    [JsonAsset("NNEDenoiserSettings")]
    public class UNNEDenoiserSettings : UDeveloperSettingsBackedByCVars
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}