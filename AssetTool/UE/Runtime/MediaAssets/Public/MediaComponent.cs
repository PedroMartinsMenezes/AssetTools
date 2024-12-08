namespace AssetTool
{
    [JsonAsset("MediaComponent")]
    public class UMediaComponent : UActorComponent
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}