namespace AssetTool
{
    [JsonAsset("PawnActionsComponent")]
    public class UDEPRECATED_PawnActionsComponent : UActorComponent
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}