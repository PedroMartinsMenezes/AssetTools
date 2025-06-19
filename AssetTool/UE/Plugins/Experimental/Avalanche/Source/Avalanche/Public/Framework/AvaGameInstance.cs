namespace AssetTool
{
    [JsonAsset("AvaGameInstance")]
    public class UAvaGameInstance : UGameInstance
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}