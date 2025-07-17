namespace AssetTool
{
    [JsonAsset("LyraInventoryManagerComponent")]
    public class ULyraInventoryManagerComponent : UActorComponent
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}