namespace AssetTool
{
    [JsonAsset("GameInstance")]
    public class UGameInstance : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}