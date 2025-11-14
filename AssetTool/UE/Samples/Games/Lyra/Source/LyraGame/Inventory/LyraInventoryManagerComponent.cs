namespace AssetTool
{
    [JsonAsset("LyraInventoryManagerComponent")]
    public class ULyraInventoryManagerComponent : UActorComponent
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}