namespace AssetTool
{
    [JsonAsset("GeneralProjectSettings")]
    public class UGeneralProjectSettings : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}