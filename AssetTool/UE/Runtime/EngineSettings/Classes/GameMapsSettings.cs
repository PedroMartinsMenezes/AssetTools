namespace AssetTool
{
    [JsonAsset("GameMapsSettings")]
    public class UGameMapsSettings : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}