namespace AssetTool
{
    [JsonAsset("GameInstance")]
    public class UGameInstance : UObject
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}