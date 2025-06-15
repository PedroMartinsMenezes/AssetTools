namespace AssetTool
{
    [JsonAsset("DEPRECATED_PawnAction_BlueprintBase")]
    public class UDEPRECATED_PawnAction_BlueprintBase : UDEPRECATED_PawnAction
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}