namespace AssetTool
{
    [JsonAsset("DEPRECATED_PawnActionsComponent")]
    public class UDEPRECATED_PawnActionsComponent : UActorComponent
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}