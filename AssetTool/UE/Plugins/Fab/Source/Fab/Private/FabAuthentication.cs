namespace AssetTool
{
    [JsonAsset("EosConstants")]
    public class UEosConstants : UDataAsset
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}