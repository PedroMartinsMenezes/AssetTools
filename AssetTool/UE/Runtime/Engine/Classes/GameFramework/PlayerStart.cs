namespace AssetTool
{
    [JsonAsset("PlayerStart")]
    public class APlayerStart : ANavigationObjectBase
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}