namespace AssetTool
{
    [JsonAsset("PlayerStart")]
    public class APlayerStart : ANavigationObjectBase
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}