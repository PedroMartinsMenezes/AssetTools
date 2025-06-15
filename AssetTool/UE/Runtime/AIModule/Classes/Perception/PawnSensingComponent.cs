namespace AssetTool
{
    [JsonAsset("PawnSensingComponent")]
    public class UPawnSensingComponent : UActorComponent
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}