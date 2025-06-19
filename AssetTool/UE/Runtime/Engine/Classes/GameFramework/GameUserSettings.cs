namespace AssetTool
{
    [JsonAsset("GameUserSettings")]
    public class UGameUserSettings : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}