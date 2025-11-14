namespace AssetTool
{
    [JsonAsset("PawnActionsComponent")]
    public class UDEPRECATED_PawnActionsComponent : UActorComponent
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}