namespace AssetTool
{
    [JsonAsset("EosConstants")]
    public class UEosConstants : UDataAsset
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}