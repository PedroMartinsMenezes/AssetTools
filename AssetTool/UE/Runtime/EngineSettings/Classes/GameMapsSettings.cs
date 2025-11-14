namespace AssetTool
{
    [JsonAsset("GameMapsSettings")]
    public class UGameMapsSettings : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}