namespace AssetTool
{
    [JsonAsset("GeneralEngineSettings")]
    public class UGeneralEngineSettings : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}