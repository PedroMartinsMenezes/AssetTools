namespace AssetTool
{
    [JsonAsset("GeneralProjectSettings")]
    public class UGeneralProjectSettings : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}