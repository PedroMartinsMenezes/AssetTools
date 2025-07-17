namespace AssetTool
{
    [JsonAsset("GameSetting")]
    public class UGameSetting : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}