namespace AssetTool
{
    [JsonAsset("PawnAction_Move")]
    public class UDEPRECATED_PawnAction_Move : UDEPRECATED_PawnAction
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}