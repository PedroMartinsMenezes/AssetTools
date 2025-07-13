namespace AssetTool
{
    [JsonAsset("GameSessionSettings")]
    public class UGameSessionSettings : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}