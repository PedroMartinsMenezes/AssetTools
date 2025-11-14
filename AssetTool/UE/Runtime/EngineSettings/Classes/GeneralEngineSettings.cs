namespace AssetTool
{
    [JsonAsset("GeneralEngineSettings")]
    public class UGeneralEngineSettings : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}