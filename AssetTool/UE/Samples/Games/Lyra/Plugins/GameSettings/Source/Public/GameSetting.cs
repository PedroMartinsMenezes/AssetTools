namespace AssetTool
{
    [JsonAsset("GameSetting")]
    public class UGameSetting : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}