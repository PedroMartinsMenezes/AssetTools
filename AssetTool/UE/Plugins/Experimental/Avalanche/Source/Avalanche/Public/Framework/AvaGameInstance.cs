namespace AssetTool
{
    [JsonAsset("AvaGameInstance")]
    public class UAvaGameInstance : UGameInstance
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}