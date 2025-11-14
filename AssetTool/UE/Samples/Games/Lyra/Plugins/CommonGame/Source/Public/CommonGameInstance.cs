namespace AssetTool
{
    [JsonAsset("CommonGameInstance")]
    public class UCommonGameInstance : UGameInstance
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}