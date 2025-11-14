namespace AssetTool
{
    [JsonAsset("GameUserSettings")]
    public class UGameUserSettings : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}