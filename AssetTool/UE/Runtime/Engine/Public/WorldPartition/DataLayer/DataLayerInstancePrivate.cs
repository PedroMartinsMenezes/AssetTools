namespace AssetTool
{
    [JsonAsset("DataLayerInstancePrivate")]
    public class UDataLayerInstancePrivate : UDataLayerInstance
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}