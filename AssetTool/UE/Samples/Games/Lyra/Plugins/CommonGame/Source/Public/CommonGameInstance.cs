namespace AssetTool
{
    [JsonAsset("CommonGameInstance")]
    public class UCommonGameInstance : UGameInstance
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}