namespace AssetTool
{
    [JsonAsset("GameSessionSettings")]
    public class UGameSessionSettings : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}