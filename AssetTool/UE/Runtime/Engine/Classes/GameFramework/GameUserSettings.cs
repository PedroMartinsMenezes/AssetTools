namespace AssetTool
{
    [JsonAsset("GameUserSettings")]
    public class UGameUserSettings : UObject
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}