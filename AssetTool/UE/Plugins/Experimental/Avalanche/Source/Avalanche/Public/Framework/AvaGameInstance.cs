namespace AssetTool
{
    [JsonAsset("AvaGameInstance")]
    public class UAvaGameInstance : UGameInstance
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}